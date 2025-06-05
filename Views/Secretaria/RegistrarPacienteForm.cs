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

            // Inicializar ComboBox de Genero
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

            
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                epPacientes.SetError(txtNombre, "El nombre es obligatorio");
                formularioValido = false;
            }

          
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                epPacientes.SetError(txtApellidos, "Los apellidos son obligatorios");
                formularioValido = false;
            }

            // 
            if (cmbGenero.SelectedIndex < 0)
            {
                epPacientes.SetError(cmbGenero, "Selecciona un genero");
                formularioValido = false;
            }

            DateTime fechaNac = dtpFechaNacimiento.Value.Date;
            if (fechaNac >= DateTime.Today)
            {
                epPacientes.SetError(dtpFechaNacimiento, "Fecha invalida");
                formularioValido = false;
            }

            string telefono = txtTelefono.Text.Trim();
            if (string.IsNullOrWhiteSpace(telefono))
            {
                epPacientes.SetError(txtTelefono, "El telefono es obligatorio");
                formularioValido = false;
            }
            else if (telefono.Length < 7)
            {
                epPacientes.SetError(txtTelefono, "Debe tener al menos 7 digitos");
                formularioValido = false;
            }

           
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                epPacientes.SetError(txtDireccion, "La direccion es obligatoria");
                formularioValido = false;
            }

        
            string dui = txtNumeroIdentidad.Text.Trim();
            if (!string.IsNullOrEmpty(dui) && dui.Length < 8)
            {
                epPacientes.SetError(txtNumeroIdentidad, "Numero de identidad invalido");
                formularioValido = false;
            }

          
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
                    epPacientes.SetError(txtCorreoElectronico, "Correo invalido");
                    formularioValido = false;
                }
            }

            if (!formularioValido)
                return;

            // Construir objeto Paciente
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

            // Guardar en BD
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