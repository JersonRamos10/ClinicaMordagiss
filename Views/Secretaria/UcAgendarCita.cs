using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;


namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class UcAgendarCita : UserControl
    {
        private readonly PacienteRepo _pacienteRepo = new PacienteRepo();
        private readonly int _idUsuarioLogueado;

        private Paciente? _pacienteSeleccionado = null;

       


        public UcAgendarCita()
        {
            InitializeComponent();

            // Suscribir eventos
            btnBuscarPaciente.Click += BtnBuscarPaciente_Click;
            dgvPacientes.CellClick += DgvPacientes_CellClick;
            btnAbrirAgendarForm.Click += BtnAbrirAgendarForm_Click;
        }

        // constructor que recibe el ID del usuario
        public UcAgendarCita(int idUsuarioLogueado) : this()
        {
            _idUsuarioLogueado = idUsuarioLogueado;
            
        }
        private void UcAgendarCita_Load(object sender, EventArgs e)
        {
            // Opcional: cargar todos los pacientes al iniciar, o dejar la grilla vacía
            dgvPacientes.DataSource = new List<Paciente>();
            btnAbrirAgendarForm.Enabled = false;
        }

        private void BtnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltroPacientes.Text.Trim();
            List<Paciente> resultados = _pacienteRepo.BuscarPacientes(filtro);

            if (resultados.Count == 0)
            {
                MessageBox.Show(
                    "No se encontró ningún paciente que coincida.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvPacientes.DataSource = new List<Paciente>();
                lblPacienteSeleccionado.Text = "";
                btnAbrirAgendarForm.Enabled = false;
                return;
            }

            // Enlazamos sólo los campos necesarios a la grilla:
            var tablaVisual = resultados
                .Select(p => new
                {
                    p.IdPaciente,      // Lo mantenemos oculto en la grilla
                    p.Nombre,
                    p.Apellidos,
                    p.Genero,
                    p.Telefono,
                    p.NumeroIdentidad
                })
                .ToList();

            dgvPacientes.DataSource = tablaVisual;

            // Ajustar columnas (ocultar IdPaciente):
            if (dgvPacientes.Columns.Contains("IdPaciente"))
                dgvPacientes.Columns["IdPaciente"].Visible = false;

            dgvPacientes.Columns["Nombre"].HeaderText = "Nombre";
            dgvPacientes.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvPacientes.Columns["Genero"].HeaderText = "Género";
            dgvPacientes.Columns["Telefono"].HeaderText = "Teléfono";
            dgvPacientes.Columns["NumeroIdentidad"].HeaderText = "Identidad";

            // Ningún paciente queda seleccionado hasta que el usuario haga clic en la grilla
            _pacienteSeleccionado = null;
            lblPacienteSeleccionado.Text = "";
            btnAbrirAgendarForm.Enabled = false;
        }

        
        private void DgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no sea el encabezado
            if (e.RowIndex < 0 || e.RowIndex >= dgvPacientes.Rows.Count)
                return;

            var fila = dgvPacientes.Rows[e.RowIndex];
            if (fila.DataBoundItem == null)
                return;

            // La DataBoundItem es un objeto anónimo con las mismas propiedades
            dynamic datos = fila.DataBoundItem;
            int id = datos.IdPaciente;

          
            _pacienteSeleccionado = _pacienteRepo
                .BuscarPacientes("") // trae todos, pero luego filtramos por ID
                .FirstOrDefault(p => p.IdPaciente == id);

            if (_pacienteSeleccionado != null)
            {
                lblPacienteSeleccionado.Text =
                    $"Paciente seleccionado: {_pacienteSeleccionado.Nombre} {_pacienteSeleccionado.Apellidos}";
                btnAbrirAgendarForm.Enabled = true;
            }
            else
            {
                lblPacienteSeleccionado.Text = "";
                btnAbrirAgendarForm.Enabled = false;
            }
        }

       
        private void BtnAbrirAgendarForm_Click(object sender, EventArgs e)
        {
            if (_pacienteSeleccionado == null)
            {
                MessageBox.Show(
                    "Debes seleccionar un paciente antes de agendar la cita.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Abrimos el formulario “Agendar Nueva Cita” y le pasamos el paciente
            int idUsuarioLogueado = _idUsuarioLogueado;
            var form = new AgendarNuevaCitaForm(idUsuarioLogueado);
            form.ShowDialog();


        }
    }
}
