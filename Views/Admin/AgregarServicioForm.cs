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
using SistemaDeCitasMordagiss.DataAccess;

namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class AgregarServicioForm : Form
    {
        private readonly ServicioRepo repositorioServicio = new ServicioRepo();
        public AgregarServicioForm()
        {
            InitializeComponent();

            chkActivo.Checked = true;  
            btnGuardarServicio.Click += GuardarServicio;
            btnCancelarServicio.Click += (s, e) => Close();
        }

        private void GuardarServicio(object? sender, EventArgs e)
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
                lblError.Text = "Correjir los campos obligatorios.";
                return;
            }

            // Verificar duplicado por nombre de servicio
            bool existeNombre = repositorioServicio.TraerTodos()
                .Any(s => s.NombreServicio.Equals(
                    txtNombreServicio.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (existeNombre)
            {
                MessageBox.Show(
                    "Ya existe un servicio con ese nombre.",
                    "Duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto Servicio
            var servicioNuevo = new Servicio
            {
                NombreServicio = txtNombreServicio.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Costo = numCosto.Value,
                DuracionEstimadaMin = (int)numDuracion.Value,
                Activo = chkActivo.Checked ? "Si" : "No"
            };

            repositorioServicio.Crear(servicioNuevo);

            MessageBox.Show(
                "Servicio registrado con exito.",
                "Exito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {

        }
    }
}

