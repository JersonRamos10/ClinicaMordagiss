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
        }

        private void UcAgendaGeneral_Load(object sender, EventArgs e)
        {

            dtpFechaAgendaGeneral.Value = DateTime.Today;

          
            CargarAgendaFecha(DateTime.Today);

          
            ActualizarRecordatorios();
        }

        private void DtpFechaAgendaGeneral_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaAgendaGeneral.Value.Date;

            // Cargar la grilla según la fecha seleccionada
            CargarAgendaFecha(fechaSeleccionada);

          
        }

        
        private void CargarAgendaFecha(DateTime fecha)
        {
            try
            {
                List<CitaVistaGeneral> citas = _citaRepo.TraerCitasVistaGeneral(fecha);
                dgvAgendaGeneral.DataSource = citas;

                // Ajustar encabezados
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

                // Si no hay citas, simplemente dejamos la grilla vacía.
                // No modificamos los labels de recordatorio aquí.
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

                // 1) Contamos las citas por confirmar para mañana
                int porConfirmar = _citaRepo.ContarCitasPorConfirmar(manana);
                // Partimos del texto original en el diseñador:
                //   "Citas por confirmar para : 0"
                // Queremos reemplazar todo tras "para " con "[FECHA]: [NÚMERO]".
                string prefixConfirmar = "Citas por confirmar para ";
                lblRecordCitasPorConfirmar.Text =
                    prefixConfirmar
                    + $"{manana:dd/MM/yyyy}: {porConfirmar}";

                // 2) Contamos las citas sin asistir que vencieron hoy
                int sinAsistir = _citaRepo.ContarCitasSinAsistirHoy();
                // El diseñador dejó:
                //   "Citas de hoy sin registrar asistencia: 0"
                // Aquí solo reemplazamos el número después de ": "
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
