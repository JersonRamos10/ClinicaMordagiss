using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;

namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class RegistrarPacienteForm : Form
    {
        private readonly PacienteRepo _pacienteRepo = new PacienteRepo();

        public RegistrarPacienteForm()
        {
            InitializeComponent();

            // Suscribir eventos
            btnGuardarPaciente.Click += BtnGuardarPaciente_Click;
            btnCancelarPaciente.Click += (s, e) => this.Close();

            // Configurar ErrorProvider
            epPacientes.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epPacientes.SetIconAlignment(txtNombre, ErrorIconAlignment.MiddleRight);
            epPacientes.SetIconAlignment(txtApellidos, ErrorIconAlignment.MiddleRight);
            epPacientes.SetIconAlignment(cmbGenero, ErrorIconAlignment.MiddleRight);
            epPacientes.SetIconAlignment(dtpFechaNacimiento, ErrorIconAlignment.MiddleRight);
            epPacientes.SetIconAlignment(txtTelefono, ErrorIconAlignment.MiddleRight);
            epPacientes.SetIconAlignment(txtDireccion, ErrorIconAlignment.MiddleRight);
            epPacientes.SetIconAlignment(txtNumeroIdentidad, ErrorIconAlignment.MiddleRight);
            epPacientes.SetIconAlignment(txtCorreoElectronico, ErrorIconAlignment.MiddleRight);

            // Inicializar ComboBox de Género
            cmbGenero.Items.AddRange(new[] { "Masculino", "Femenino", "Otro" });
            cmbGenero.SelectedIndex = -1;

            // Configurar DateTimePicker
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.MaxDate = DateTime.Today;
        }

        private void BtnGuardarPaciente_Click(object sender, EventArgs e)
        {
            bool formularioValido = true;
            epPacientes.Clear();

            // 1) Nombre (obligatorio)
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                epPacientes.SetError(txtNombre, "El nombre es obligatorio");
                formularioValido = false;
            }

            // 2) Apellidos (obligatorio)
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                epPacientes.SetError(txtApellidos, "Los apellidos son obligatorios");
                formularioValido = false;
            }

            // 3) Género (obligatorio)
            if (cmbGenero.SelectedIndex < 0)
            {
                epPacientes.SetError(cmbGenero, "Selecciona un género");
                formularioValido = false;
            }

            // 4) Fecha de nacimiento (obligatorio y debe ser anterior a hoy)
            DateTime fechaNac = dtpFechaNacimiento.Value.Date;
            if (fechaNac >= DateTime.Today)
            {
                epPacientes.SetError(dtpFechaNacimiento, "Fecha inválida");
                formularioValido = false;
            }

            // 5) Teléfono (obligatorio, mínimo 7 dígitos)
            string telefono = txtTelefono.Text.Trim();
            if (string.IsNullOrWhiteSpace(telefono))
            {
                epPacientes.SetError(txtTelefono, "El teléfono es obligatorio");
                formularioValido = false;
            }
            else if (telefono.Length < 7)
            {
                epPacientes.SetError(txtTelefono, "Debe tener al menos 7 dígitos");
                formularioValido = false;
            }

            // 6) Dirección (obligatorio)
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                epPacientes.SetError(txtDireccion, "La dirección es obligatoria");
                formularioValido = false;
            }

            // 7) Número de Identidad (opcional, pero si se ingresa, validar longitud mínima)
            string dui = txtNumeroIdentidad.Text.Trim();
            if (!string.IsNullOrEmpty(dui) && dui.Length < 8)
            {
                epPacientes.SetError(txtNumeroIdentidad, "Número de identidad inválido");
                formularioValido = false;
            }

            // 8) Correo Electrónico (opcional, si se ingresa, validar formato básico)
            string correo = txtCorreoElectronico.Text.Trim();
            if (!string.IsNullOrEmpty(correo))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(correo);
                    if (addr.Address != correo)
                        throw new FormatException();
                }
                catch
                {
                    epPacientes.SetError(txtCorreoElectronico, "Correo inválido");
                    formularioValido = false;
                }
            }

            if (!formularioValido)
                return;

            // 9) Construir objeto Paciente
            var paciente = new Paciente
            {
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Genero = cmbGenero.Text,
                FechaNacimiento = fechaNac,
                Telefono = telefono,
                Direccion = txtDireccion.Text.Trim(),
                NumeroIdentidad = dui,
                CorreoElectronico = correo
            };

            // 10) Guardar en BD
            try
            {
                _pacienteRepo.Crear(paciente);
                MessageBox.Show(
                    "Paciente guardado exitosamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al guardar el paciente:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}