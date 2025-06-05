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

namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class UcGestionarPacientes: UserControl
    {
        private readonly PacienteRepo _pacienteRepo;
        private readonly CitaRepo _citaRepo;
  

        public UcGestionarPacientes()
        {
            InitializeComponent();
            _pacienteRepo = new PacienteRepo();
            _citaRepo = new CitaRepo();

            ConfigurarDataGridView();

            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            btnNuevoPaciente.Click += btnNuevoPaciente_Click;

            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            CargarPacientes();

        }

        private void ConfigurarDataGridView()
        {
            dgvPacientes.Columns.Clear();

            dgvPacientes.ReadOnly = true;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.MultiSelect = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.AllowUserToAddRows = false; 

           
            dgvPacientes.AutoGenerateColumns = false; 

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdPacienteCol", 
                DataPropertyName = "IdPaciente", 
                HeaderText = "ID Paciente"
            });

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCompletoCol",
                DataPropertyName = "NombreCompleto",
                HeaderText = "Nombre Completo"
            });

            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TelefonoCol",
                DataPropertyName = "Telefono",
                HeaderText = "Telefono"
            });

            
            dgvPacientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UltimaVisitaCol",
                DataPropertyName = "UltimaVisita", 
                HeaderText = "Ultima Visita" 
            });

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.Name = "EditarCol";
            colEditar.HeaderText = "Acciones";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            dgvPacientes.Columns.Add(colEditar);

            DataGridViewButtonColumn colHistorial = new DataGridViewButtonColumn();
            colHistorial.Name = "HistorialCol";
            colHistorial.HeaderText = "Acciones";
            colHistorial.Text = "Ver Historial";
            colHistorial.UseColumnTextForButtonValue = true;
            dgvPacientes.Columns.Add(colHistorial);
        }

        private void CargarPacientes(string filtro = "")
        {
            try
            {
                List<Paciente> pacientesDesdeRepo = _pacienteRepo.BuscarPacientes(filtro);
                var vistaPacientes = new List<VistaPaciente>();

                foreach (var p in pacientesDesdeRepo)
                {
                    string? ultimaVisitaRaw = _citaRepo.ObtenerUltimaFechaVisitaPorPaciente(p.IdPaciente);
                    string ultimaVisitaDisplay = "";

                    if (!string.IsNullOrEmpty(ultimaVisitaRaw))
                    {
                      
                        if (DateTime.TryParse(ultimaVisitaRaw, out DateTime fechaUltimaVisita))
                        {
                            ultimaVisitaDisplay = fechaUltimaVisita.ToString("dd/MM/yyyy"); 
                        }
                        else
                        {
                            ultimaVisitaDisplay = ultimaVisitaRaw; 
                        }
                    }
                    else
                    {
                        ultimaVisitaDisplay = "N/A"; 
                    }

                    vistaPacientes.Add(new VistaPaciente
                    {
                        IdPaciente = p.IdPaciente,
                        NombreCompleto = $"{p.Nombre} {p.Apellidos}",
                        Telefono = p.Telefono,
                        UltimaVisita = ultimaVisitaDisplay
                    });
                }

                dgvPacientes.DataSource = vistaPacientes;

                if (vistaPacientes.Count == 0 && !string.IsNullOrEmpty(filtro))
                {
                    MessageBox.Show("No se encontraron pacientes con el criterio de búsqueda.", "Búsqueda de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex < 0) return;


            if (dgvPacientes.Rows[e.RowIndex].DataBoundItem is VistaPaciente pacienteSeleccionado)
            {
           
                if (dgvPacientes.Columns[e.ColumnIndex].Name == "HistorialCol")
                {
                  
                    HistorialPacienteForm historialForm = new HistorialPacienteForm(pacienteSeleccionado.IdPaciente);
                    historialForm.ShowDialog(this);
                }
                else if (dgvPacientes.Columns[e.ColumnIndex].Name == "EditarCol")
                {
                    
                    EditarPacienteForm editarForm = new EditarPacienteForm(pacienteSeleccionado.IdPaciente);
                    if (editarForm.ShowDialog(this) == DialogResult.OK)
                    {
                        CargarPacientes(txtBuscarPaciente.Text.Trim());
                    }
                }
                
            }
        }
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            CargarPacientes(txtBuscarPaciente.Text.Trim());
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            using (var registrarPacienteForm = new RegistrarPacienteForm())
            {
                registrarPacienteForm.ShowDialog();
            }
            CargarPacientes();
        }
    }
}
