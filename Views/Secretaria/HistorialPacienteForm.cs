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

namespace SistemaDeCitasMordagiss.Views.Secretaria 
{
    public partial class HistorialPacienteForm : Form
    {
        private readonly int _idPaciente;
        private readonly PacienteRepo _pacienteRepo;
        private readonly CitaRepo _citaRepo;



        public HistorialPacienteForm(int idPaciente)
        {
            InitializeComponent(); 
            _idPaciente = idPaciente;
            _pacienteRepo = new PacienteRepo();
            _citaRepo = new CitaRepo();

            this.Text = "Historial del Paciente"; 

            CargarDatosPaciente();
            ConfigurarDataGridViewCitas(); 
            CargarHistorialCitas();
        }

        private void CargarDatosPaciente()
        {
            try
            {
                
                Paciente? paciente = _pacienteRepo.ObtenerPorId(_idPaciente);

                if (paciente != null)
                {
                    lblNombrePaciente.Text = $"{paciente.Nombre} {paciente.Apellidos}";
                    lblFechaNacimientoPaciente.Text = paciente.FechaNacimiento.ToString("dd/MM/yyyy");
                    lblGeneroPaciente.Text = paciente.Genero;
                    lblTelefonoPaciente.Text = paciente.Telefono;
                    lblDuiPaciente.Text = string.IsNullOrEmpty(paciente.NumeroIdentidad) ? "N/A" : paciente.NumeroIdentidad;
                    lblDireccionPaciente.Text = string.IsNullOrEmpty(paciente.Direccion) ? "N/A" : paciente.Direccion;
                    lblCorreoPaciente.Text = string.IsNullOrEmpty(paciente.CorreoElectronico) ? "N/A" : paciente.CorreoElectronico;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la información del paciente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    lblNombrePaciente.Text = "Paciente no encontrado";
                    lblFechaNacimientoPaciente.Text = "N/A";
                    lblGeneroPaciente.Text = "N/A";
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Paciente? ObtenerPacientePorIdLocal(int idPaciente)
        {

            List<Paciente> todosLosPacientes = _pacienteRepo.BuscarPacientes("");
            return todosLosPacientes.FirstOrDefault(p => p.IdPaciente == idPaciente);
        }

        private void ConfigurarDataGridViewCitas()
        {
            dgvHistorialCitas.Columns.Clear(); 
            dgvHistorialCitas.AutoGenerateColumns = false; 

            dgvHistorialCitas.ReadOnly = true;
            dgvHistorialCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialCitas.MultiSelect = false;
            dgvHistorialCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialCitas.AllowUserToAddRows = false;

            dgvHistorialCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaCita",
                HeaderText = "Fecha",
                FillWeight = 20 
            });
            dgvHistorialCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HoraInicio",
                HeaderText = "Hora",
                FillWeight = 15
            });
            dgvHistorialCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreProfesional",
                HeaderText = "Profesional",
                FillWeight = 30
            });
            dgvHistorialCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreServicio",
                HeaderText = "Servicio",
                FillWeight = 25
            });
            dgvHistorialCitas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EstadoCita",
                HeaderText = "Estado",
                FillWeight = 20
            });
        }

        private void CargarHistorialCitas()
        {
            try
            {
                List<CitaHistorialVista> historial = _citaRepo.TraerCitasCompletasPorPaciente(_idPaciente);
                dgvHistorialCitas.DataSource = historial;

                if (historial.Count == 0)
                {
                    grpHistorialCitas.Text = "Historial de Citas (No hay registros)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial de citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarHistorial_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}