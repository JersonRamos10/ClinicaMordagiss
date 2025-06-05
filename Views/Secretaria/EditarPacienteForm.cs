using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using System;
using System.Drawing; 
using System.Windows.Forms;

namespace SistemaDeCitasMordagiss.Views.Secretaria 
{
    public partial class EditarPacienteForm : Form
    {
        private readonly PacienteRepo _pacienteRepo;
        private readonly int _idPacienteAEditar;
        private Paciente? _pacienteActual; 

      

        public EditarPacienteForm(int idPaciente)
        {
            InitializeComponent();
            _pacienteRepo = new PacienteRepo();
            _idPacienteAEditar = idPaciente;

            InicializarComboBoxGenero();
        
            this.Text = "Editar Paciente";
            btnGuardarPaciente.Text = "Guardar Cambios"; 

            // Cargar los datos del paciente
            CargarDatosDelPaciente();

     
            btnGuardarPaciente.Click += BtnGuardarCambios_Click;
            btnCancelarPaciente.Click += BtnCancelar_Click;
        }
        private void InicializarComboBoxGenero()
        {
            cmbGenero.Items.Clear(); 
            cmbGenero.Items.AddRange(new object[] {
                "Masculino",
                "Femenino",
                "Otro"
            });
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList; 
        }
        private void CargarDatosDelPaciente()
        {
            _pacienteActual = _pacienteRepo.ObtenerPorId(_idPacienteAEditar);

            if (_pacienteActual != null)
            {
                txtNombre.Text = _pacienteActual.Nombre;
                txtApellidos.Text = _pacienteActual.Apellidos;
                dtpFechaNacimiento.Value = _pacienteActual.FechaNacimiento;
               
                cmbGenero.SelectedItem = _pacienteActual.Genero;

                txtNumeroIdentidad.Text = _pacienteActual.NumeroIdentidad;
                txtTelefono.Text = _pacienteActual.Telefono;
                txtDireccion.Text = _pacienteActual.Direccion;
                txtCorreoElectronico.Text = _pacienteActual.CorreoElectronico;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los datos del paciente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); 
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            epPacientes.Clear(); 
            bool esValido = true;

            // Validaciones (campos obligatorios: Nombre, Apellidos, Género, Teléfono)
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                epPacientes.SetError(txtNombre, "El nombre es obligatorio.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                epPacientes.SetError(txtApellidos, "Los apellidos son obligatorios.");
                esValido = false;
            }
            if (cmbGenero.SelectedItem == null || string.IsNullOrWhiteSpace(cmbGenero.SelectedItem.ToString()))
            {
                epPacientes.SetError(cmbGenero, "Seleccione un genero.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                epPacientes.SetError(txtTelefono, "El telefono es obligatorio.");
                esValido = false;
            }
       

            if (!esValido)
            {
                MessageBox.Show("Por favor, corrija los campos marcados.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_pacienteActual == null) // Doble chequeo por si acaso
            {
                MessageBox.Show("Error: No hay datos de paciente cargados para actualizar.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar el objeto _pacienteActual con los nuevos datos del formulario
            _pacienteActual.Nombre = txtNombre.Text.Trim();
            _pacienteActual.Apellidos = txtApellidos.Text.Trim();
            _pacienteActual.FechaNacimiento = dtpFechaNacimiento.Value;
            _pacienteActual.Genero = cmbGenero.SelectedItem.ToString();
            _pacienteActual.NumeroIdentidad = txtNumeroIdentidad.Text.Trim(); 
            _pacienteActual.Telefono = txtTelefono.Text.Trim();
            _pacienteActual.Direccion = txtDireccion.Text.Trim();
            _pacienteActual.CorreoElectronico = txtCorreoElectronico.Text.Trim(); 

            try
            {
                bool actualizado = _pacienteRepo.Actualizar(_pacienteActual);
                if (actualizado)
                {
                    MessageBox.Show("Paciente actualizado exitosamente.", "Edicion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el paciente. Verifique los datos o intente mas tarde.", "Error de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al actualizar el paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}