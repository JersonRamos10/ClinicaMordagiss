using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using SistemaDeCitasMordagiss.Views.Admin;

namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class UcServicios : UserControl
    {
        // Instancia del repositorio (no estático)
        private readonly ServicioRepo repositorioServicio = new ServicioRepo();

        public UcServicios()
        {
            InitializeComponent();

            // Asignar eventos a los botones
            btnBuscarServicio.Click += (s, e) => CargarServicios(txtBuscarServicio.Text);
            btnAgregarServicio.Click += (s, e) => { AbrirFormularioAgregar(); CargarServicios(); };
            btnEditarServicio.Click += (s, e) => AbrirFormularioEditar();
            btnEliminarServicio.Click += (s, e) => EliminarServicio();

            // Configurar DataGridView
            dgvServicios.ReadOnly = true;
            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.MultiSelect = false;
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarServicios();
        }

        private void CargarServicios(string filtro = "")
        {
            // Usar la instancia para llamar TraerTodos()
            List<Servicio> listaDeServicios = repositorioServicio.TraerTodos();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                listaDeServicios = listaDeServicios
                    .Where(serv =>
                        serv.NombreServicio.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                        serv.Descripcion.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvServicios.DataSource = listaDeServicios;

            // Renombrar encabezados de columnas si existen
            void Renombrar(string columnaInterna, string encabezado)
            {
                if (dgvServicios.Columns.Contains(columnaInterna))
                    dgvServicios.Columns[columnaInterna].HeaderText = encabezado;
            }

            Renombrar("IdServicio", "ID");
            Renombrar("NombreServicio", "Servicio");
            Renombrar("Descripcion", "Descripción");
            Renombrar("Costo", "Costo ($)");
            Renombrar("DuracionEstimadaMin", "Duración (min)");
            Renombrar("Activo", "Estado");

            // Convertir “si”/“no” a “Activo”/“Inactivo”
            foreach (DataGridViewRow fila in dgvServicios.Rows)
            {
                string? valor = fila.Cells["Activo"].Value?.ToString()?.ToLower();
                fila.Cells["Activo"].Value = valor == "si" ? "Activo" : "Inactivo";
            }
        }

        private Servicio? ServicioSeleccionado()
        {
            return dgvServicios.CurrentRow?.DataBoundItem as Servicio;
        }

        private void AbrirFormularioAgregar()
        {
            // Usar el namespace correcto para el formulario
            using var formulario = new AgregarServicioForm();
            formulario.ShowDialog();
        }

        private void AbrirFormularioEditar()
        {
            Servicio? servicio = ServicioSeleccionado();
            if (servicio == null)
            {
                MessageBox.Show("Seleccione un servicio para editar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            
            using var formulario = new EditarServicioForm(servicio);
            formulario.ShowDialog();
            CargarServicios();
        }

        private void EliminarServicio()
        {
            Servicio? servicio = ServicioSeleccionado();
            if (servicio == null)
            {
                MessageBox.Show("Seleccione un servicio para eliminar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Eliminar el servicio “{servicio.NombreServicio}”?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes) return;

            // Llamar al método Borrar de la instancia del repositorio
            bool eliminado = repositorioServicio.Borrar(servicio.IdServicio);

            MessageBox.Show(
                eliminado ? "Servicio eliminado correctamente." : "No se pudo eliminar el servicio.",
                eliminado ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                eliminado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            CargarServicios();
        }
    }
}
