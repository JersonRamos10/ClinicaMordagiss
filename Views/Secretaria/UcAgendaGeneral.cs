using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;

namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class UcAgendaGeneral : UserControl
    {
        private readonly CitaRepo _citaRepo = new CitaRepo();

        public UcAgendaGeneral()
        {
            InitializeComponent();

            // Suscribir el evento para cuando cambie la fecha
            dtpFechaAgendaGeneral.ValueChanged += DtpFechaAgendaGeneral_ValueChanged;

            this.Load += UcAgendaGeneral_Load;
        }

        //metodo para cargar la angenda general
        private void UcAgendaGeneral_Load(object sender, EventArgs e)
        {

            dtpFechaAgendaGeneral.Value = DateTime.Today;

          
            CargarAgendaFecha(DateTime.Today);

          
            ActualizarRecordatorios();
        }

        private void DtpFechaAgendaGeneral_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaAgendaGeneral.Value.Date;

     
            CargarAgendaFecha(fechaSeleccionada);

          
        }

        
        private void CargarAgendaFecha(DateTime fecha)
        {
            try
            {
                List<CitaVistaGeneral> citas = _citaRepo.TraerCitasVistaGeneral(fecha);
                dgvAgendaGeneral.DataSource = citas;

                // Ajusta encabezados
                if (dgvAgendaGeneral.Columns.Contains("HoraInicio"))
                    dgvAgendaGeneral.Columns["HoraInicio"].HeaderText = "Hora";
                if (dgvAgendaGeneral.Columns.Contains("NombrePaciente"))
                    dgvAgendaGeneral.Columns["NombrePaciente"].HeaderText = "Paciente";
                if (dgvAgendaGeneral.Columns.Contains("NombreProfesional"))
                    dgvAgendaGeneral.Columns["NombreProfesional"].HeaderText = "Médico";
                if (dgvAgendaGeneral.Columns.Contains("NombreServicio"))
                    dgvAgendaGeneral.Columns["NombreServicio"].HeaderText = "Servicio";
                if (dgvAgendaGeneral.Columns.Contains("EstadoCita"))
                    dgvAgendaGeneral.Columns["EstadoCita"].HeaderText = "Estado";

               
                if (citas.Count == 0)
                {
                    dgvAgendaGeneral.Visible = true; 
                }
                else
                {
                    dgvAgendaGeneral.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar la agenda: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void ActualizarRecordatorios()
        {
            try
            {
                DateTime hoy = DateTime.Today;
                DateTime manana = hoy.AddDays(1);

                
                int porConfirmar = _citaRepo.ContarCitasPorConfirmar(manana);
               
                string prefixConfirmar = "Citas por confirmar para ";
                lblRecordCitasPorConfirmar.Text =
                    prefixConfirmar
                    + $"{manana:dd/MM/yyyy}: {porConfirmar}";

                
                int sinAsistir = _citaRepo.ContarCitasSinAsistirHoy();
              
                string prefixSinAsistir = "Citas de hoy sin registrar asistencia: ";
                lblRecordCitasSinAsistir.Text =
                    prefixSinAsistir
                    + $"{sinAsistir}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al actualizar recordatorios: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
