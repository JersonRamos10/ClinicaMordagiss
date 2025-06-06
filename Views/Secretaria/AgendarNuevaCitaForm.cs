using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using SistemaDeCitasMordagiss.Views.Admin;
using SistemaDeCitasMordagiss.Servicios;
using System.Globalization;

namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class AgendarNuevaCitaForm : Form
    {
        // ————— Repositorios —————
        private readonly PacienteRepo _pacienteRepo = new PacienteRepo();
        private readonly ServicioRepo _servicioRepo = new ServicioRepo();
        private readonly MedicoRepo _medicoRepo = new MedicoRepo();
        private readonly HorarioRepo _horarioRepo = new HorarioRepo();
        private readonly CitaRepo _citaRepo = new CitaRepo();

        private readonly ErrorProvider _ep = new ErrorProvider();

        // ————— Estado interno —————
        private Paciente? _pacienteSeleccionado = null;
        private int _idServicioSeleccionado = 0;
        private int _idMedicoSeleccionado = 0;

        private readonly int _idUsuarioLogueado;


        //campos necesarios para generar la boleta Pdf que utilizara la secretarias
        private string _boletaPacienteNombre = "";
        private string _boletaPacienteApellidos = "";
        private string _boletaMedicoNombre = "";
        private DateTime _boletaFecha;
        private string _boletaHoraInicio = "";
        private string _boletaHoraFin = "";
        public AgendarNuevaCitaForm(int idUsuarioLogueado)
        {
            InitializeComponent();

            _idUsuarioLogueado = idUsuarioLogueado;

            btnImprimirBoleta.Click += BtnImprimirBoleta_Click;
            btnDescargarBoleta.Click += BtnDescargarBoleta_Click;

            // Suscribiendo eventos
            btnBuscarPaciente.Click += BtnBuscarPaciente_Click;
            lklRegistrarNuevoPaciente.Click += LklRegistrarNuevoPaciente_Click;
            btnCancelarCita.Click += BtnCancelarCita_Click;
            btnAgendarCita.Click += BtnAgendarCita_Click;
            cmbServicio.SelectedIndexChanged += CmbServicio_SelectedIndexChanged;
            cmbMedico.SelectedIndexChanged += CmbMedico_SelectedIndexChanged;
            dtpFechaCita.ValueChanged += DtpFechaCita_ValueChanged;

            cmbHoraDisponible.SelectedIndexChanged += CmbHoraDisponible_SelectedIndexChanged;


            btnAgendarCita.Enabled = false;
            lblMensajeExito.Text = "";
            lblMensajeExito.Visible = false;
            panelBoleta.Visible = false;
            lblBoletaTitulo.Visible = false;
            btnImprimirBoleta.Visible = false;
            btnDescargarBoleta.Visible = false;

            this.Load += AgendarNuevaCitaForm_Load;

            // Configurando el  ErrorProvider para los datos invalidos
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.SetIconAlignment(cmbServicio, ErrorIconAlignment.MiddleRight);
            _ep.SetIconAlignment(cmbMedico, ErrorIconAlignment.MiddleRight);
            _ep.SetIconAlignment(dtpFechaCita, ErrorIconAlignment.MiddleRight);
            _ep.SetIconAlignment(cmbHoraDisponible, ErrorIconAlignment.MiddleRight);


        }

        private void AgendarNuevaCitaForm_Load(object sender, EventArgs e)
        {
            // Inicializa el texto y visibilidad
            lblResultadoBusqueda.Text = "";
            lklRegistrarNuevoPaciente.Visible = false;
            txtPacienteSeleccionado.Text = "";
            txtPacienteSeleccionado.ReadOnly = true;

            // 1) Cargar lista de servicios sin filtrar
            List<Servicio> servicios = _servicioRepo.TraerTodos();

            // Desconecta temporalmente el evento
            cmbServicio.SelectedIndexChanged -= CmbServicio_SelectedIndexChanged;

            cmbServicio.ValueMember = "IdServicio";
            cmbServicio.DisplayMember = "NombreServicio";
            cmbServicio.DataSource = servicios;
            cmbServicio.SelectedIndex = -1;

            // Reconecta el evento
            cmbServicio.SelectedIndexChanged += CmbServicio_SelectedIndexChanged;

            // Deshabilita combos y controles dependientes
            cmbServicio.Enabled = false;            // se habilita tras buscar paciente
            cmbMedico.Enabled = false;              // se habilitara despuess de elegir servicio
            dtpFechaCita.Enabled = false;
            cmbHoraDisponible.Enabled = false;
            btnAgendarCita.Enabled = false;

            // Ocultar mensajes y panel de boleta
            lblSinDisponibilidad.Text = "";
            lblSinDisponibilidad.Visible = false;
            lblMensajeExito.Text = "";
            lblMensajeExito.Visible = false;
            panelBoleta.Visible = false;
            lblBoletaTitulo.Visible = false;
            btnImprimirBoleta.Visible = false;
            btnDescargarBoleta.Visible = false;
        }
        private void CmbHoraDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si hay una hora seleccionada (indice >= 0), el boton  se habilita
            if (cmbHoraDisponible.SelectedIndex >= 0)
            {
                _ep.SetError(cmbHoraDisponible, ""); // Limpia cualquier error previo
                btnAgendarCita.Enabled = true;
            }
            else
            {
                btnAgendarCita.Enabled = false;
            }
        }
        private void BtnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarPaciente.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show(
                    "Por favor escribe un nombre, apellido o identidad para buscar.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Paciente> resultados = _pacienteRepo.BuscarPacientes(filtro);

            if (resultados.Count == 0)
            {
                // No se encontro ningun paciente mensaje
                lblResultadoBusqueda.ForeColor = Color.Red;
                lblResultadoBusqueda.Text = "No se encontro ningun paciente.";
                lklRegistrarNuevoPaciente.Visible = true;

                txtPacienteSeleccionado.Text = "";
                _pacienteSeleccionado = null;

                DeshabilitarSeccionesPosteriores();
            }
            else
            {
                // Toma el primer resultado
                _pacienteSeleccionado = resultados[0];

                lblResultadoBusqueda.ForeColor = Color.DarkGreen;
                lblResultadoBusqueda.Text =
                    $"Paciente encontrado: {_pacienteSeleccionado.Nombre} {_pacienteSeleccionado.Apellidos}";
                lklRegistrarNuevoPaciente.Visible = false;

                txtPacienteSeleccionado.Text =
                    $"{_pacienteSeleccionado.Nombre} {_pacienteSeleccionado.Apellidos}";

                // Habilita la seccion de Servicios
                cmbServicio.Enabled = true;
                cmbServicio.SelectedIndex = -1;

                cmbMedico.Enabled = false;
                cmbMedico.DataSource = null;
                dtpFechaCita.Enabled = false;
                cmbHoraDisponible.Enabled = false;
                btnAgendarCita.Enabled = false;
                lblSinDisponibilidad.Visible = false;
                lblMensajeExito.Visible = false;
                panelBoleta.Visible = false;
            }
        }

        private void LklRegistrarNuevoPaciente_Click(object sender, EventArgs e)
        {
            //abre el formo de registro de paciente
            var formNuevo = new RegistrarPacienteForm();
            formNuevo.ShowDialog();

            BtnBuscarPaciente_Click(null!, null!);
        }

        private void DeshabilitarSeccionesPosteriores()
        {
            cmbServicio.Enabled = false;
            cmbMedico.Enabled = false;
            dtpFechaCita.Enabled = false;
            cmbHoraDisponible.Enabled = false;
            btnAgendarCita.Enabled = false;
            lblSinDisponibilidad.Visible = false;
        }

        private void CmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay servicio seleccionado, muestro error y deshabilito dependientes
            if (cmbServicio.SelectedIndex < 0 || cmbServicio.SelectedValue == null)
            {
                _ep.SetError(cmbServicio, "Debe seleccionar un servicio");
                cmbMedico.Enabled = false;
                cmbMedico.DataSource = null;
                dtpFechaCita.Enabled = false;
                cmbHoraDisponible.Enabled = false;
                btnAgendarCita.Enabled = false;
                return;
            }

            //  Limpio error de servicio
            _ep.SetError(cmbServicio, "");

            //  Obtener ID de servicio 
            _idServicioSeleccionado = (int)cmbServicio.SelectedValue!;

            // Carga todos los medicos en memoria
            List<ProfesionalMedico> medDisponibles = _medicoRepo.TraerTodos();

            // Si no hay ningun medico registrado
            if (medDisponibles.Count == 0)
            {
                MessageBox.Show(
                    "No hay ningún medico registrado en el sistema.\n" +
                    "Consulta con el administrador.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbServicio.SelectedIndex = -1;
                _idServicioSeleccionado = 0;
                cmbMedico.DataSource = null;
                cmbMedico.Enabled = false;
                dtpFechaCita.Enabled = false;
                cmbHoraDisponible.Enabled = false;
                btnAgendarCita.Enabled = false;
                return;
            }

            //
            cmbMedico.DisplayMember = "Nombre";              
            cmbMedico.ValueMember = "IdProfesionalMedico";

            // asignando el DataSource con la lista completa de medicos
            cmbMedico.DataSource = medDisponibles;
            cmbMedico.SelectedIndex = -1;
            cmbMedico.Enabled = true;

            // Deshabilito fecha/hora hasta que se elija un medico
            dtpFechaCita.Enabled = false;
            cmbHoraDisponible.Enabled = false;
            btnAgendarCita.Enabled = false;

            // Limpiar cualquier posible error previo en el combo de medicos
            _ep.SetError(cmbMedico, "");
        }




        private void CmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Si no hay medico seleccionado, muestro error y deshabilito dependientes
            if (cmbMedico.SelectedIndex < 0 || cmbMedico.SelectedValue == null)
            {
                _ep.SetError(cmbMedico, "Debes seleccionar un medico");
                dtpFechaCita.Enabled = false;
                cmbHoraDisponible.Enabled = false;
                btnAgendarCita.Enabled = false;
                return;
            }

            // Medico valido 
            _ep.SetError(cmbMedico, "");
            _idMedicoSeleccionado = (int)cmbMedico.SelectedValue!;

            // Habilito selector de fecha
            dtpFechaCita.Enabled = true;

            // Limpio combo de horas y boton de agendar
            cmbHoraDisponible.Items.Clear();
            cmbHoraDisponible.Enabled = false;
            btnAgendarCita.Enabled = false;
            lblSinDisponibilidad.Visible = false;
        }


        // En AgendarNuevaCitaForm.cs
        private void DtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            // Verificaciones iniciales
            if (_idMedicoSeleccionado <= 0)
            {
                _ep.SetError(dtpFechaCita, "Selecciona primero un medico");
                return;
            }
            if (_idServicioSeleccionado <= 0)
            {
                _ep.SetError(dtpFechaCita, "Selecciona primero un servicio");
                return;
            }
            _ep.SetError(dtpFechaCita, "");

          
            DateTime fecha = dtpFechaCita.Value.Date;
            lblSinDisponibilidad.Visible = false;
            cmbHoraDisponible.DataSource = null; // Limpiar DataSource para evitar errores
            cmbHoraDisponible.Items.Clear();
            cmbHoraDisponible.Enabled = false;
            btnAgendarCita.Enabled = false;

           
            var culturaEs = new CultureInfo("es-ES");
            string diaSemana = culturaEs.TextInfo.ToTitleCase(fecha.ToString("dddd", culturaEs));
          

            List<HorarioProfesionalMedico> franjas =
                _horarioRepo.TraerHorariosPorProfesional(_idMedicoSeleccionado)
                            .Where(h =>
                                h.DiaSemana.Equals(diaSemana, StringComparison.OrdinalIgnoreCase))
                            .ToList();

            if (franjas.Count == 0)
            {
                lblSinDisponibilidad.ForeColor = Color.Red;
                lblSinDisponibilidad.Text = $"El medico no tiene horario para el dia {diaSemana}.";
                lblSinDisponibilidad.Visible = true;
                _ep.SetError(dtpFechaCita, "Este medico no trabaja ese dia");
                return;
            }

            var servicioSeleccionado = _servicioRepo.TraerTodos().FirstOrDefault(s => s.IdServicio == _idServicioSeleccionado);
            if (servicioSeleccionado == null)
            {
                lblSinDisponibilidad.Text = "Error: No se pudo encontrar la duracion del servicio seleccionado.";
                lblSinDisponibilidad.Visible = true;
                return;
            }
            TimeSpan duracionTurno = TimeSpan.FromMinutes(servicioSeleccionado.DuracionEstimadaMin);
           
            // Obtiene todas las citas existentes para ese medico en esa fecha
            List<Cita> citasExistentes =
                _citaRepo.TraerCitasCompletasPorProfesionalYFecha(_idMedicoSeleccionado, fecha);

            var horasLibres = new List<string>();

            foreach (var franja in franjas)
            {
                TimeSpan inicio = TimeSpan.Parse(franja.HoraInicioTrabajo);
                TimeSpan fin = TimeSpan.Parse(franja.HoraFinTrabajo);
                TimeSpan slotActual = inicio;

               
                while (slotActual.Add(duracionTurno) <= fin)
                {
                    TimeSpan slotFin = slotActual.Add(duracionTurno);
                    bool ocupado = citasExistentes.Any(c => {
                        TimeSpan inicioCitaExistente = TimeSpan.Parse(c.HoraInicio);
                        TimeSpan finCitaExistente = TimeSpan.Parse(c.HoraFin);
                    
                        return slotActual < finCitaExistente && slotFin > inicioCitaExistente;
                    });

                    if (!ocupado)
                    {
                     
                        if (fecha.Date == DateTime.Today && slotActual <= DateTime.Now.TimeOfDay)
                        {
                          
                        }
                        else
                        {
                            horasLibres.Add(slotActual.ToString(@"hh\:mm"));
                        }
                    }
                  
                    slotActual = slotActual.Add(TimeSpan.FromMinutes(15));
                }
            }

            if (horasLibres.Count == 0)
            {
                lblSinDisponibilidad.ForeColor = Color.Red;
                lblSinDisponibilidad.Text = $"No hay horarios disponibles para {cmbMedico.Text} en {fecha:dd/MM/yyyy}.";
                lblSinDisponibilidad.Visible = true;
                _ep.SetError(dtpFechaCita, "Este medico no tiene horas libres en la fecha seleccionada");
            }
            else
            {
                _ep.SetError(dtpFechaCita, "");
                lblSinDisponibilidad.Visible = false;
                cmbHoraDisponible.Enabled = true;
                cmbHoraDisponible.Items.AddRange(horasLibres.ToArray());
                cmbHoraDisponible.SelectedIndex = -1;
            }
        }

        private void BtnAgendarCita_Click(object sender, EventArgs e)
        {
            bool formularioValido = true;
            _ep.Clear();

          //validacione necesarias 
            if (_pacienteSeleccionado == null)
            {
                MessageBox.Show("Debes buscar y seleccionar un paciente primero.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formularioValido = false;
            }
            if (cmbServicio.SelectedIndex < 0)
            {
                _ep.SetError(cmbServicio, "Selecciona un servicio");
                formularioValido = false;
            }
            if (cmbMedico.SelectedIndex < 0)
            {
                _ep.SetError(cmbMedico, "Selecciona un medico");
                formularioValido = false;
            }
            if (!dtpFechaCita.Enabled)
            {
                _ep.SetError(dtpFechaCita, "Selecciona una fecha valida");
                formularioValido = false;
            }
            if (cmbHoraDisponible.SelectedIndex < 0)
            {
                _ep.SetError(cmbHoraDisponible, "Selecciona una hora disponible");
                formularioValido = false;
            }
            if (!formularioValido)
                return;

            // validar turno libre 
            DateTime fecha = dtpFechaCita.Value.Date;
            string horaIni = cmbHoraDisponible.SelectedItem!.ToString()!; 
            bool disponible = _citaRepo.TurnoDisponible(_idMedicoSeleccionado, fecha, horaIni);
            if (!disponible)
            {
                MessageBox.Show("El turno ya fue reservado. Elige otra hora.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtpFechaCita_ValueChanged(null!, null!); // Recalcula horas libres
                return;
            }

            // calcular HoraFin (turno de 30 minutos) 
            TimeSpan tIni = TimeSpan.Parse(horaIni);
            TimeSpan tFin = tIni.Add(TimeSpan.FromMinutes(30));
            string horaFin = tFin.ToString(@"hh\:mm"); 

            // armar objeto Cita con todos los campos requeridos 
            var nuevaCita = new Cita
            {
                IdPaciente = _pacienteSeleccionado!.IdPaciente,
                IdServicio = _idServicioSeleccionado,
                IdProfesionalMedico = _idMedicoSeleccionado,
                FechaCita = fecha.ToString("yyyy-MM-dd"),
                HoraInicio = horaIni,
                HoraFin = horaFin,
                EstadoCita = "Programada",
                IdUsuarioRegistra = _idUsuarioLogueado,   
                FechaRegistroCita = DateTime.Now
            };

            // insertar en BD
            _citaRepo.CrearCita(nuevaCita);

            // ASIGNAR valores para la boleta PDF despues de crear la cita 
            _boletaPacienteNombre = _pacienteSeleccionado.Nombre;
            _boletaPacienteApellidos = _pacienteSeleccionado.Apellidos;
            var prof = (ProfesionalMedico)cmbMedico.SelectedItem!;
            _boletaMedicoNombre = $"{prof.Nombre} {prof.Apellidos}";
            _boletaFecha = fecha;
            _boletaHoraInicio = horaIni;
            _boletaHoraFin = horaFin;

            // mostrar mensaje de exito y habilitar los botones de boleta 
            lblMensajeExito.ForeColor = Color.DarkGreen;
            lblMensajeExito.Text =
                $"Cita agendada: {_pacienteSeleccionado.Nombre} " +
                $"{_pacienteSeleccionado.Apellidos} con {cmbMedico.Text} " +
                $"el {fecha:dd/MM/yyyy} de {horaIni} a {horaFin}.";
            lblMensajeExito.Visible = true;
            lblBoletaTitulo.Text =
                $"Boleta de cita para {_pacienteSeleccionado.Nombre} " +
                $"{_pacienteSeleccionado.Apellidos}:";
            panelBoleta.Visible = true;
            lblBoletaTitulo.Visible = true;
            btnImprimirBoleta.Visible = true;
            btnDescargarBoleta.Visible = true;
        }



        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImprimirBoleta_Click(object sender, EventArgs e)
        {
            try
            {
                // Esto genera y abre el PDF temporal con el visor predeterminado.
                PdfGenerator.GenerarYMostrarBoletaPdf(
                    _boletaPacienteNombre,
                    _boletaPacienteApellidos,
                    _boletaMedicoNombre,
                    _boletaFecha,
                    _boletaHoraInicio,
                    _boletaHoraFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar/abrir la boleta:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDescargarBoleta_Click(object sender, EventArgs e)
        {
            // Ahora si existe _boletaPacienteNombre, etc.
            using var sfd = new SaveFileDialog();
            sfd.Filter = "Archivos PDF|*.pdf";
            sfd.Title = "Guardar Boleta de Cita";
            sfd.FileName = $"Boleta_{_boletaPacienteNombre}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfGenerator.GenerarBoletaPdf(
                        sfd.FileName,
                        _boletaPacienteNombre,
                        _boletaPacienteApellidos,
                        _boletaMedicoNombre,
                        _boletaFecha,
                        _boletaHoraInicio,
                        _boletaHoraFin);
                    MessageBox.Show("PDF guardado correctamente.", "Exito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al generar el PDF:\n{ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
