using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;

namespace SistemaDeCitasMordagiss.Views
{
    public partial class DashboardMedicoForm : Form
    {
        private readonly CitaRepo citaRepo = new CitaRepo();
        private readonly ProfesionalMedico medicoActual;
        private readonly string rolUsuario;
        public DashboardMedicoForm(ProfesionalMedico profesionalMedico, string rol)
        {
            InitializeComponent();

            medicoActual = profesionalMedico
                ?? throw new ArgumentNullException(nameof(profesionalMedico));
            rolUsuario = rol;

            // Suscribir eventos
            btnCerrarSesionMedico.Click += btnCerrarSesionMedico_Click;
            dtpSeleccionFechaCitas.ValueChanged += (s, e) =>
                CargarCitasParaFecha(dtpSeleccionFechaCitas.Value.Date);
            this.rolUsuario = rolUsuario;
        }

        private void DashboardMedicoForm_Load(object sender, EventArgs e)
        {
            // Mensaje de bienvenida
            lblBienvenidoMedico.Text = $"Bienvenido, Dr. {medicoActual.Apellidos}";
            // Mostrar fecha y hora actuales
            lblFechaHoraActual.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            
            lblRol.Text = $"Rol: {rolUsuario}";


            lblTituloAgenda.Text = $"Mi Agenda para Hoy – {DateTime.Today:dd/MM/yyyy}";
            // Fijar el DateTimePicker a hoy y cargar citas de hoy
            dtpSeleccionFechaCitas.Value = DateTime.Today;
            CargarCitasParaFecha(DateTime.Today);
        }

        private void CargarCitasParaFecha(DateTime fecha)
        {
            lblErrorMedico.Text = string.Empty;
            dgvCitasMedico.DataSource = null;

            List<CitaVistaMedico> listaCitas;
            try
            {
                // Llamamos al repositorio que devuelve solo los campos requeridos
                listaCitas = citaRepo.TraerCitasVistaMedico(
                    medicoActual.IdProfesionalMedico, fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar las citas: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (listaCitas.Count == 0)
            {
                lblErrorMedico.ForeColor = Color.DarkBlue;
                lblErrorMedico.Text = "No tiene citas para esta fecha.";
                return;
            }

            // Asignar la lista al DataGridView
            dgvCitasMedico.DataSource = listaCitas;

            // Ocultamos todas las columnas automáticas y dejamos solo las cuatro:
            foreach (DataGridViewColumn col in dgvCitasMedico.Columns)
            {
                col.Visible = false;
            }

            // Hora
            if (dgvCitasMedico.Columns.Contains("HoraInicio"))
            {
                var c = dgvCitasMedico.Columns["HoraInicio"];
                c.Visible = true;
                c.HeaderText = "Hora";
            }

            // Paciente
            if (dgvCitasMedico.Columns.Contains("NombrePaciente"))
            {
                var c = dgvCitasMedico.Columns["NombrePaciente"];
                c.Visible = true;
                c.HeaderText = "Paciente";
            }

            // Servicio
            if (dgvCitasMedico.Columns.Contains("NombreServicio"))
            {
                var c = dgvCitasMedico.Columns["NombreServicio"];
                c.Visible = true;
                c.HeaderText = "Servicio";
            }

            // Estado
            if (dgvCitasMedico.Columns.Contains("EstadoCita"))
            {
                var c = dgvCitasMedico.Columns["EstadoCita"];
                c.Visible = true;
                c.HeaderText = "Estado";
            }
        }

        private void btnCerrarSesionMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new LoginForm();
            login.Show();
        }
    }
}
