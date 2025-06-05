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
    public partial class EditarMedicoForm: Form
    {
        private readonly MedicoRepo _repo = new();
        private readonly ProfesionalMedico _medicoOriginal;

        public EditarMedicoForm()
        {
            InitializeComponent();

            btnGuardar.Click += GuardarCambios;
            btnCancelar.Click += (s, e) => Close();
        }

        public EditarMedicoForm(ProfesionalMedico medico) : this()
        {
            _medicoOriginal = medico ?? throw new ArgumentNullException(nameof(medico));

            lblTitulo.Text = "Editar Profesional Médico";
            txtNombre.Text = medico.Nombre;
            txtApellidos.Text = medico.Apellidos;
            txtEspecialidad.Text = medico.Especialidad;
            txtTelefono.Text = medico.TelefonoContacto;
            txtCorreo.Text = medico.CorreoElectronico;
            chkActivo.Checked = medico.Activo.Equals("Si", StringComparison.OrdinalIgnoreCase);
        }


        private void GuardarCambios(object? sender, EventArgs e)
        {
            ep.Clear();
            lblError.Text = "";

            bool valido = true;

            //validaciones basicas para campos nulos o vacios de los text box 
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { ep.SetError(txtNombre, "Obligatorio"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            { ep.SetError(txtApellidos, "Obligatorio"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtEspecialidad.Text) || txtEspecialidad.Text.Length < 3)
            { ep.SetError(txtEspecialidad, "Mínimo 3 caracteres"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                !(txtTelefono.Text.All(char.IsDigit) && txtTelefono.Text.Length == 8))
            { ep.SetError(txtTelefono, "8 dígitos"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                !txtCorreo.Text.Contains('@') || !txtCorreo.Text.Contains('.'))
            { ep.SetError(txtCorreo, "Correo invalido"); valido = false; }

            // correo duplicado si cambió
            bool correoCambio = !txtCorreo.Text.Trim()
                                    .Equals(_medicoOriginal.CorreoElectronico,
                                            StringComparison.OrdinalIgnoreCase);

            if (correoCambio)
            {
                bool duplicado = _repo.TraerTodos()
                      .Any(pm => pm.CorreoElectronico.Equals(
                                txtCorreo.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                if (duplicado)
                { ep.SetError(txtCorreo, "Correo ya existe"); valido = false; }
            }

            if (!valido)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Corrige los campos marcados.";
                return;
            }

            var actualizado = new ProfesionalMedico
            {
                IdProfesionalMedico = _medicoOriginal.IdProfesionalMedico,
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Especialidad = txtEspecialidad.Text.Trim(),
                TelefonoContacto = txtTelefono.Text.Trim(),
                CorreoElectronico = txtCorreo.Text.Trim(),
                Activo = chkActivo.Checked ? "Si" : "No",
                IdUsuarioSistema = _medicoOriginal.IdUsuarioSistema
            };

            _repo.Actualizar(actualizado);

            MessageBox.Show("Datos guardados.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Close();
        }
    }
}
