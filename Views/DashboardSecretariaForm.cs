using System;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.Models;
using SistemaDeCitasMordagiss.Views.Secretaria; 

namespace SistemaDeCitasMordagiss.Views
{
    public partial class DashboardSecretariaForm : Form
    {

        private readonly UsuarioSistema _usuarioLogueado;

        public DashboardSecretariaForm(UsuarioSistema usuarioLogueado)
        {
            InitializeComponent();

            _usuarioLogueado = usuarioLogueado;

            // eventos de los LinkLabels
            lklConsultarAgenda.Click += LklConsultarAgenda_Click;
            lklAgendarCita.Click += LklAgendarCita_Click;
            lklGestionarPacientes.Click += LklGestionarPacientes_Click;
            lklGestionarHorarios.Click += LklGestionarHorarios_Click;
            lklConfirmarCitas.Click += LklConfirmarCitas_Click;
            lklReporteCitas.Click += LklReporteCitas_Click;

            btnCerrarSesionSecretaria.Click += (s, e) =>
            {
                this.Hide();
                var login = new LoginForm();
                login.Show();
            };


        }
        public UsuarioSistema ObtenerUsuarioActual()
        {
            return _usuarioLogueado;
        }

        private void DashboardSecretariaForm_Load(object sender, EventArgs e)
        {

            lblBienvenidaSecretaria.Text = $"Bienvenida, {_usuarioLogueado.NombreCompleto}";
            lblRolSecretaria.Text = $"Rol: {_usuarioLogueado.Rol}";
            lblFechaHoraSecretaria.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Cargar por defecto la "Agenda del Dia"
            MostrarUserControl(new UcAgendaGeneral());
        }


        private void MostrarUserControl(UserControl uc)
        {
            panelContenedorSecretaria.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContenedorSecretaria.Controls.Add(uc);


        }



        private void LklConsultarAgenda_Click(object sender, EventArgs e)
        {

            var uc = new UcAgendaGeneral();

            MostrarUserControl(uc);
        }

        private void LklAgendarCita_Click(object sender, EventArgs e)
        {
            // Muestra el UserControl para Agendar Cita
            var uc = new UcAgendarCita(_usuarioLogueado.IdUsuarioSistema);
            uc.Dock = DockStyle.Fill;
            MostrarUserControl(uc);
        }

        private void LklGestionarPacientes_Click(object sender, EventArgs e)
        {
            // Muestra el UserControl para Gestionar Pacientes
            var uc = new UcGestionarPacientes();
            MostrarUserControl(uc);
        }

        private void LklGestionarHorarios_Click(object sender, EventArgs e)
        {
            // Muestra el UserControl para Gestionar Horarios Medicos
            var uc = new UcGestionarHorariosMedico();
            MostrarUserControl(uc);
        }

        private void LklConfirmarCitas_Click(object sender, EventArgs e)
        {
            // Muestra el UserControl para Confirmar Citas Pendientes
            var uc = new UcGestionarCitas();
            MostrarUserControl(uc);
        }

        private void LklReporteCitas_Click(object sender, EventArgs e)
        {
            // Muestra el UserControl para Generar Reporte de Citas
            var uc = new UcReportesCitas();
            MostrarUserControl(uc);
        }

        private void panelContenedorSecretaria_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
