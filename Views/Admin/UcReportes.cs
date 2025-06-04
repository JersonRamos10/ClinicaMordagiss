using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;

using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;

namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class UcReportes: UserControl
    {
        // Instancia del repositorio de reportes y del repositorio de medicos
        
        private readonly ReporteRepo repositorioReporte = new ReporteRepo();
        private readonly MedicoRepo repositorioMedico = new MedicoRepo();
        public UcReportes()
        {
            InitializeComponent();

            //llenar el combo con los datos de los medicos
            CargarComboProfesionales();

            // Asignar evento al boton Generar Reporte
            btnGenerarReporte.Click += (s, e) => GenerarReporte();

            btnExportarPDFReporte.Enabled = false;

            btnExportarPDFReporte.Click += (s, e) => ExportarPDF();


        }

        private void CargarComboProfesionales()
        {
            // Primero, vaciar ítems existentes
            cmbProfesionalesReporte.Items.Clear();

            // Agregar la opción "Todos"
            cmbProfesionalesReporte.Items.Add(new ComboItem
            {
                Texto = "Todos",
                Valor = null   // Valor nulo indica “todos”
            });

            // Obtener la lista completa de profesionales
            List<ProfesionalMedico> listaTodos = repositorioMedico.TraerTodos();

            // Filtrar solo los activos (si no creaste TraerActivos)
            List<ProfesionalMedico> listaActivos = listaTodos
                .Where(p => p.Activo.Equals("Si", StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Agregar cada profesional al ComboBox
            foreach (ProfesionalMedico medico in listaActivos)
            {
                cmbProfesionalesReporte.Items.Add(new ComboItem
                {
                    Texto = $"{medico.Nombre} {medico.Apellidos}",
                    Valor = medico.IdProfesionalMedico
                });
            }

            // Seleccionar por defecto “Todos”
            cmbProfesionalesReporte.SelectedIndex = 0;
        }

        // Clase auxiliar para almacenar texto y valor en el ComboBox
        private class ComboItem
        {
            public string? Texto { get; set; }
            public int? Valor { get; set; }

            public override string ToString()
                => Texto ?? string.Empty;   // Esto es lo que el ComboBox mostrará
        }

        private void GenerarReporte()
        {
            // Limpiar errores previos
            epReporte.Clear();
            lblErrorReporte.Text = string.Empty;
            dgvReporteActividades.DataSource = null;
            btnExportarPDFReporte.Enabled = false;

            // Validar rango de fechas
            DateTime fechaInicio = dtpFechaInicioCitas.Value.Date;
            DateTime fechaFin = dtpFechaFinCitas.Value.Date;

            if (fechaFin < fechaInicio)
            {
                epReporte.SetError(dtpFechaFinCitas, "La fecha fin no puede ser anterior a la fecha inicio");
                lblErrorReporte.ForeColor = Color.Red;
                lblErrorReporte.Text = "La fecha fin no puede ser anterior a la fecha inicio.";
                return;
            }

            // Obtener ID del profesional seleccionado (o null si es "Todos")
            var itemSeleccionado = cmbProfesionalesReporte.SelectedItem as ComboItem;
            int? idProfesional = itemSeleccionado?.Valor;
           

            // Invocar al repositorio y capturar la lista de resultados
            List<ReporteActividadProfesional> listaReporte;
            try
            {
                listaReporte = repositorioReporte.GenerarReporte(fechaInicio, fechaFin, idProfesional);
            }
            catch (Exception ex)
            {
                // Si algo falla en la consulta, mostrar mensaje 
                MessageBox.Show(
                    "No se pudo generar el reporte. Verifique la conexion a la base de datos.",
                    "Error al generar reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //Verificar si la lista está vacia
            if (listaReporte.Count == 0)
            {
                lblErrorReporte.ForeColor = Color.DarkBlue;
                lblErrorReporte.Text = "No hay datos para el rango y/o profesional seleccionado.";
                return;
            }

            // 5) Cargar la lista en la DataGridView
            dgvReporteActividades.DataSource = listaReporte;

            // 
            if (dgvReporteActividades.Columns.Contains("NombreCompleto"))
                dgvReporteActividades.Columns["NombreCompleto"].HeaderText = "Profesional Medico";
            if (dgvReporteActividades.Columns.Contains("TotalCitas"))
                dgvReporteActividades.Columns["TotalCitas"].HeaderText = "Total de citas";

          
            btnExportarPDFReporte.Enabled = true;
        }

        private void ExportarPDF()
        {

            if (dgvReporteActividades.DataSource == null || dgvReporteActividades.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar a PDF",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;


            }
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Guardar reporte como PDF";
                dialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dialog.FileName = $"Reporte_Citas_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return; // El usuario canceló

                string rutaArchivo = dialog.FileName;

                try
                {
                    // 2) Preparar el documento y el escritor
                    using (var fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (var documento = new Document(PageSize.A4, 36, 36, 54, 54))
                    using (var escritor = PdfWriter.GetInstance(documento, fs))
                    {
                        documento.Open();

                        // 3) Título del PDF
                        var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        var parrafoTitulo = new Paragraph("Reporte de Actividad por Profesional\n\n", fuenteTitulo)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        documento.Add(parrafoTitulo);

                        // 4) Información de rango de fechas y profesional seleccionado
                        var fuenteInfo = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                        string textoRango = $"Rango de fechas: {dtpFechaInicioCitas.Value:dd/MM/yyyy} " +
                                            $"a {dtpFechaFinCitas.Value:dd/MM/yyyy}";
                        var parrafoRango = new Paragraph(textoRango + "\n", fuenteInfo)
                        {
                            Alignment = Element.ALIGN_LEFT
                        };
                        documento.Add(parrafoRango);

                        // Obtener el texto del profesional
                        string profesionalSeleccionado = (cmbProfesionalesReporte.SelectedItem as ComboItem)?.Texto ?? "Todos";
                        var parrafoProf = new Paragraph($"Profesional: {profesionalSeleccionado}\n\n", fuenteInfo)
                        {
                            Alignment = Element.ALIGN_LEFT
                        };
                        documento.Add(parrafoProf);

                        // 5) Crear tabla en el PDF con el mismo número de columnas que la grilla
                        var tabla = new PdfPTable(dgvReporteActividades.Columns.Count)
                        {
                            WidthPercentage = 100
                        };

                        // 5.1) Añadir encabezados
                        foreach (DataGridViewColumn columna in dgvReporteActividades.Columns)
                        {
                            var celdaEncabezado = new PdfPCell(new Phrase(columna.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
                            {
                                BackgroundColor = BaseColor.LIGHT_GRAY,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 4
                            };
                            tabla.AddCell(celdaEncabezado);
                        }

                        // 5.2) Añadir filas de datos
                        foreach (DataGridViewRow fila in dgvReporteActividades.Rows)
                        {
                            // Para cada celda en la fila, convertir el valor a texto y agregar como PdfPCell
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                string textoCelda = celda.Value?.ToString() ?? "";
                                var fontDato = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                                var pdfCelda = new PdfPCell(new Phrase(textoCelda, fontDato))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    Padding = 4
                                };
                                tabla.AddCell(pdfCelda);
                            }
                        }

                        documento.Add(tabla);

                        documento.Close();
                    }

                    MessageBox.Show($"PDF generado correctamente en:\n{rutaArchivo}",
                                    "Exportar a PDF",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al generar el PDF:\n{ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
