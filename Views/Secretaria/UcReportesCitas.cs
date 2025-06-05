using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using SistemaDeCitasMordagiss.Servicios;

namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class UcReportesCitas: UserControl
    {

        private readonly CitaRepo _citaRepo;
        private readonly MedicoRepo _medicoRepo;
        private readonly ServicioRepo _servicioRepo;
        private List<CitaGestionVista> _citasDelReporteActual;
        public UcReportesCitas()
        {
            InitializeComponent();

            _citaRepo = new CitaRepo();
            _medicoRepo = new MedicoRepo();
            _servicioRepo = new ServicioRepo();
            _citasDelReporteActual = new List<CitaGestionVista>();

            ConfigurarControlesIniciales();
            PoblarComboBoxesFiltro();

            btnGenerarReporteCitas.Click += BtnGenerarReporteCitas_Click;
            btnDescargarPdfReporte.Click += BtnDescargarPdfReporte_Click;
            btnImprimirReporte.Click += BtnImprimirReporte_Click; 
        }

        private void ConfigurarControlesIniciales()
        {
            dtpFechaInicioReporte.Value = DateTime.Today.AddDays(-7); // Por defecto, ultima semana
            dtpFechaFinReporte.Value = DateTime.Today;
            pnlResultadosReporte.Visible = false;
            lblErrorFiltros.Text = "";

            ConfigurarDataGridViewReporte();
        }

        private class ComboItem 
        {
            public string Texto { get; set; } = "";
            public int? Valor { get; set; } // Nullable para la opcion "Todos"
            public override string ToString() => Texto;
        }

        private void PoblarComboBoxesFiltro()
        {
            // Medicos
            try
            {
                var medicos = _medicoRepo.TraerTodos()
                                .Where(m => m.Activo.Equals("Si", StringComparison.OrdinalIgnoreCase))
                                .Select(m => new ComboItem { Texto = $"{m.Nombre} {m.Apellidos}", Valor = m.IdProfesionalMedico })
                                .ToList();
                medicos.Insert(0, new ComboItem { Texto = "Todos los Medicos", Valor = null });
                cmbMedicoReporte.DataSource = medicos;
                cmbMedicoReporte.DisplayMember = "Texto";
                cmbMedicoReporte.ValueMember = "Valor"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar medicos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Servicios
            try
            {
                var servicios = _servicioRepo.TraerTodos()
                                 .Where(s => s.Activo.Equals("Si", StringComparison.OrdinalIgnoreCase))
                                 .Select(s => new ComboItem { Texto = s.NombreServicio, Valor = s.IdServicio })
                                 .ToList();
                servicios.Insert(0, new ComboItem { Texto = "Todos los Servicios", Valor = null });
                cmbServicioReporte.DataSource = servicios;
                cmbServicioReporte.DisplayMember = "Texto";
                cmbServicioReporte.ValueMember = "Valor";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar servicios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridViewReporte()
        {
            dgvReporteCitasSecretaria.AutoGenerateColumns = false;
            dgvReporteCitasSecretaria.ReadOnly = true;
            dgvReporteCitasSecretaria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteCitasSecretaria.AllowUserToAddRows = false;
            dgvReporteCitasSecretaria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporteCitasSecretaria.Columns.Clear();
            // Mismas columnas que CitaGestionVista
            dgvReporteCitasSecretaria.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FechaCita", HeaderText = "Fecha", FillWeight = 15 });
            dgvReporteCitasSecretaria.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoraInicio", HeaderText = "Hora", FillWeight = 10 });
            dgvReporteCitasSecretaria.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombrePaciente", HeaderText = "Paciente", FillWeight = 25 });
            dgvReporteCitasSecretaria.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreProfesional", HeaderText = "Profesional", FillWeight = 20 });
            dgvReporteCitasSecretaria.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreServicio", HeaderText = "Servicio", FillWeight = 15 });
            dgvReporteCitasSecretaria.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EstadoCita", HeaderText = "Estado", FillWeight = 15 });
        }

        private void BtnGenerarReporteCitas_Click(object sender, EventArgs e)
        {
            lblErrorFiltros.Text = "";
            epReporteSecretaria.Clear(); 

            if (dtpFechaInicioReporte.Value.Date > dtpFechaFinReporte.Value.Date)
            {
                epReporteSecretaria.SetError(dtpFechaFinReporte, "La fecha fin no puede ser anterior a la fecha de inicio.");
                lblErrorFiltros.Text = "Corrija las fechas.";
                pnlResultadosReporte.Visible = false;
                return;
            }

            DateTime fechaDesde = dtpFechaInicioReporte.Value.Date;
            DateTime fechaHasta = dtpFechaFinReporte.Value.Date;

            int? idMedico = (cmbMedicoReporte.SelectedItem as ComboItem)?.Valor;
            string textoMedicoSeleccionado = (cmbMedicoReporte.SelectedItem as ComboItem)?.Texto ?? "N/A";

           
            int? idServicio = (cmbServicioReporte.SelectedItem as ComboItem)?.Valor;
            string textoServicioSeleccionado = (cmbServicioReporte.SelectedItem as ComboItem)?.Texto ?? "N/A";


            try
            {
                _citasDelReporteActual = _citaRepo.TraerCitasParaGestion(fechaDesde, fechaHasta, null, idMedico);

                // Filtrar por servicio si se selecciono uno especifico
                if (idServicio.HasValue)
                {
                    _citasDelReporteActual = _citasDelReporteActual.Where(c => c.IdServicio == idServicio.Value).ToList();
                }

                dgvReporteCitasSecretaria.DataSource = new BindingList<CitaGestionVista>(_citasDelReporteActual);

                if (_citasDelReporteActual.Any())
                {
                    pnlResultadosReporte.Visible = true;
                    lblPeriodoReporte.Text = $"PERIODO: {fechaDesde:dd/MM/yyyy} - {fechaHasta:dd/MM/yyyy}";
                    lblProfesionalSeleccionadoReporte.Text = $"PROFESIONAL MEDICO: {textoMedicoSeleccionado}";
                    lblServicioSeleccionadoReporte.Text = $"SERVICIO: {textoServicioSeleccionado}";
                    btnDescargarPdfReporte.Enabled = true;
                    btnImprimirReporte.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron citas con los criterios especificados.", "Reporte Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlResultadosReporte.Visible = false;
                    btnDescargarPdfReporte.Enabled = false;
                    btnImprimirReporte.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlResultadosReporte.Visible = false;
            }
        }


        private void BtnDescargarPdfReporte_Click(object sender, EventArgs e)
        {
            if (_citasDelReporteActual == null || !_citasDelReporteActual.Any())
            {
                MessageBox.Show("No hay datos en el reporte para exportar a PDF.", "Exportar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.FileName = $"ReporteCitas_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                sfd.Title = "Guardar Reporte de Citas como PDF";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Obtener la informacion de los filtros de los labels que ya llenaste
                        string periodo = lblPeriodoReporte.Text;
                        string profesional = lblProfesionalSeleccionadoReporte.Text;
                        string servicio = lblServicioSeleccionadoReporte.Text;

                        // Llamar al metodo en PdfGenerator
                        PdfGenerator.GenerarReporteCitasPdf(sfd.FileName, _citasDelReporteActual, periodo, profesional, servicio);

                        MessageBox.Show("Reporte PDF generado y guardado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // para preguntar si se desea abrir el archivo
                        if (MessageBox.Show("Desea abrir el archivo generado?", "Abrir PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var psi = new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true
                            };
                            System.Diagnostics.Process.Start(psi);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el archivo PDF: {ex.Message}", "Error de Exportacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

         private void BtnImprimirReporte_Click(object sender, EventArgs e)
    {
        if (_citasDelReporteActual == null || !_citasDelReporteActual.Any())
        {
            MessageBox.Show("No hay datos en el reporte para imprimir.", "Imprimir Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            // Obtener la informacion de los filtros de los labels
            string periodo = lblPeriodoReporte.Text;
            string profesional = lblProfesionalSeleccionadoReporte.Text;
            string servicio = lblServicioSeleccionadoReporte.Text;

            // Llamar al  metodo de PdfGenerator para generar e imprimir
            bool impresionIniciada = PdfGenerator.GenerarEImprimirReporte(_citasDelReporteActual, periodo, profesional, servicio);

            if (impresionIniciada)
            {
                MessageBox.Show("El reporte ha sido enviado a la cola de impresion.\n" +
                                "Por favor, revise el dialogo de su impresora.",
                                "Impresion Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo iniciar el proceso de impresion.\n" +
                                "...",
                                "Error de Impresion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocurrio un error inesperado al intentar imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }

}

