using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class EditarServicioForm: Form
    {
        private readonly ServicioRepo repositorioServicio = new ServicioRepo();
        private readonly Servicio servicioOriginal;
        public EditarServicioForm()
        {
            InitializeComponent();

            btnGuardarServicio.Click += GuardarCambios;
            btnCancelarServicio.Click += (s, e) => Close();
        }
        public EditarServicioForm(Servicio servicio) : this()
        {
            servicioOriginal = servicio ?? throw new ArgumentNullException(nameof(servicio));

            lblTitulo.Text = "Editar Servicio";
            txtNombreServicio.Text = servicioOriginal.NombreServicio;
            txtDescripcion.Text = servicioOriginal.Descripcion;
            numCosto.Value = servicioOriginal.Costo;
            numDuracion.Value = servicioOriginal.DuracionEstimadaMin;
            chkActivo.Checked = servicioOriginal.Activo.Equals("Si", StringComparison.OrdinalIgnoreCase);
        }

        // Evento Guardar: valida y actualiza
        private void GuardarCambios(object? sender, EventArgs e)
        {
            epServicio.Clear();
            lblError.Text = string.Empty;

            bool formularioValido = true;

            // Validar NOMBRE (obligatorio)
            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text))
            {
                epServicio.SetError(txtNombreServicio, "El nombre es obligatorio");
                formularioValido = false;
            }

            // Validar COSTO (obligatorio y > 0)
            if (numCosto.Value <= 0)
            {
                epServicio.SetError(numCosto, "El costo debe ser mayor que 0");
                formularioValido = false;
            }

            if (!formularioValido)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Corrija los campos obligatorios.";
                return;
            }

            // Verificar duplicado de NOMBRE si cambió
            string nuevoNombre = txtNombreServicio.Text.Trim();
            bool nombreCambio = !nuevoNombre.Equals(
                servicioOriginal.NombreServicio, StringComparison.OrdinalIgnoreCase);

            if (nombreCambio)
            {
                bool existeDuplicado = repositorioServicio
                    .TraerTodos()
                    .Any(s => s.NombreServicio.Equals(
                        nuevoNombre, StringComparison.OrdinalIgnoreCase));

                if (existeDuplicado)
                {
                    epServicio.SetError(txtNombreServicio, "Ya existe un servicio con ese nombre");
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "El nombre de servicio ya está en uso.";
                    return;
                }
            }

            // Construir objeto actualizado
            var servicioActualizado = new Servicio
            {
                IdServicio = servicioOriginal.IdServicio,
                NombreServicio = nuevoNombre,
                Descripcion = txtDescripcion.Text.Trim(),       // opcional
                Costo = numCosto.Value,
                DuracionEstimadaMin = (int)numDuracion.Value,
                Activo = chkActivo.Checked ? "Si" : "No"
            };

            repositorioServicio.Actualizar(servicioActualizado);

            MessageBox.Show(
                "Servicio actualizado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

    }
}
