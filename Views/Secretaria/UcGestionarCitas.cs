using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class UcGestionarCitas : UserControl
    {
        private readonly CitaRepo _citaRepo;
        private readonly HorarioRepo _horarioRepo;
        private readonly ServicioRepo _servicioRepo;
        private List<CitaGestionVista> _listaCitasActual;
        private CitaGestionVista? _citaSeleccionada;
      
     

        public UcGestionarCitas()
        {
            InitializeComponent();
            _citaRepo = new CitaRepo();
            _horarioRepo = new HorarioRepo();
            _servicioRepo = new ServicioRepo();
            _listaCitasActual = new List<CitaGestionVista>();

            ConfigurarControlesIniciales();
            ConfigurarDataGridView();

            // Suscribir eventos
            btnFiltrarCitas.Click += BtnFiltrarCitas_Click;
            dgvCitasGestion.SelectionChanged += DgvCitasGestion_SelectionChanged;
            chkReprogramarCita.CheckedChanged += ChkReprogramarCita_CheckedChanged;
            dtpNuevaFechaReprogramacion.ValueChanged += DtpNuevaFechaReprogramacion_ValueChanged;
            btnGuardarCambiosCita.Click += BtnGuardarCambiosCita_Click;

            chkConfirmarCita.CheckedChanged += AccionCheckBox_CheckedChanged;
            chkCancelarCita.CheckedChanged += AccionCheckBox_CheckedChanged;
            chkMarcarRealizada.CheckedChanged += AccionCheckBox_CheckedChanged;

            CargarCitas(); // Carga inicial de citas
        }

        private void ConfigurarControlesIniciales()
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today.AddDays(7);

            cmbEstadoFiltro.Items.Clear();
            cmbEstadoFiltro.Items.Add("Todos");
            cmbEstadoFiltro.Items.Add("Programada");
            cmbEstadoFiltro.Items.Add("Confirmada");
            cmbEstadoFiltro.Items.Add("Cancelada por Secretaria"); 
            cmbEstadoFiltro.Items.Add("Realizada");
            cmbEstadoFiltro.Items.Add("No Asistio");
            cmbEstadoFiltro.SelectedIndex = 0;

            grpAccionesCita.Enabled = false;
            pnlReprogramacion.Visible = false;
            lblInfoCitaSeleccionada.Text = "Seleccione una cita de la lista.";

            dtpNuevaFechaReprogramacion.MinDate = DateTime.Today;
            dtpNuevaFechaReprogramacion.Value = DateTime.Today;
            cmbNuevaHoraReprogramacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigurarDataGridView()
        {
            dgvCitasGestion.Columns.Clear();
            dgvCitasGestion.AutoGenerateColumns = false;
            dgvCitasGestion.ReadOnly = true;
            dgvCitasGestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitasGestion.MultiSelect = false;
            dgvCitasGestion.AllowUserToAddRows = false;
            dgvCitasGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCitasGestion.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdCitaCol", DataPropertyName = "IdCita", HeaderText = "ID Cita", Visible = false });
            dgvCitasGestion.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaCitaCol", DataPropertyName = "FechaCita", HeaderText = "Fecha", FillWeight = 15 });
            dgvCitasGestion.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoraInicioCol", DataPropertyName = "HoraInicio", HeaderText = "Hora", FillWeight = 10 });
            dgvCitasGestion.Columns.Add(new DataGridViewTextBoxColumn { Name = "PacienteCol", DataPropertyName = "NombrePaciente", HeaderText = "Paciente", FillWeight = 25 });
            dgvCitasGestion.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProfesionalCol", DataPropertyName = "NombreProfesional", HeaderText = "Profesional", FillWeight = 25 });
            dgvCitasGestion.Columns.Add(new DataGridViewTextBoxColumn { Name = "ServicioCol", DataPropertyName = "NombreServicio", HeaderText = "Servicio", FillWeight = 20 });
            dgvCitasGestion.Columns.Add(new DataGridViewTextBoxColumn { Name = "EstadoCol", DataPropertyName = "EstadoCita", HeaderText = "Estado", FillWeight = 15 });
        }

        private void BtnFiltrarCitas_Click(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void CargarCitas()
        {
            DateTime fechaDesde = dtpFechaDesde.Value.Date;
            DateTime fechaHasta = dtpFechaHasta.Value.Date;
            string? estado = cmbEstadoFiltro.SelectedItem?.ToString();

            if (estado == "Todos") estado = null; // Si es "Todos", no se filtra por estado

            try
            {
                _listaCitasActual = _citaRepo.TraerCitasParaGestion(fechaDesde, fechaHasta, estado);
                dgvCitasGestion.DataSource = new BindingList<CitaGestionVista>(_listaCitasActual);

                DgvCitasGestion_SelectionChanged(null, EventArgs.Empty); // Forzar actualizacion de panel de acciones

                if (!_listaCitasActual.Any() && (estado != null || fechaDesde != DateTime.MinValue || fechaHasta != DateTime.MaxValue))
                {
                    MessageBox.Show("No se encontraron citas con los filtros aplicados.", "Busqueda de Citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar citas: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCitasGestion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCitasGestion.SelectedRows.Count > 0)
            {
                _citaSeleccionada = dgvCitasGestion.SelectedRows[0].DataBoundItem as CitaGestionVista;
                if (_citaSeleccionada != null)
                {
                    grpAccionesCita.Enabled = true;
                    lblInfoCitaSeleccionada.Text = $"Cita para: {_citaSeleccionada.NombrePaciente} el {_citaSeleccionada.FechaCita} a las {_citaSeleccionada.HoraInicio}";

                    // Resetear checkboxes y panel de reprogramacion
                    chkConfirmarCita.Checked = false;
                    chkCancelarCita.Checked = false;
                    chkMarcarRealizada.Checked = false;
                    chkReprogramarCita.Checked = false;
                    // pnlReprogramacion.Visible = false; // Se maneja en ChkReprogramarCita_CheckedChanged

                    // Habilitar/deshabilitar acciones segun estado actual
                    bool esModificable = !(_citaSeleccionada.EstadoCita.StartsWith("Cancelada") || _citaSeleccionada.EstadoCita == "Realizada" || _citaSeleccionada.EstadoCita == "No Asistio");

                    chkConfirmarCita.Enabled = esModificable && _citaSeleccionada.EstadoCita != "Confirmada";
                    chkCancelarCita.Enabled = esModificable;
                    // Marcar realizada solo si esta confirmada y la fecha es hoy o pasada
                    bool puedeMarcarRealizada = false;
                    if (DateTime.TryParseExact(_citaSeleccionada.FechaCita, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaCitaDt))
                    {
                        puedeMarcarRealizada = (_citaSeleccionada.EstadoCita == "Confirmada" && fechaCitaDt.Date <= DateTime.Today);
                    }
                    chkMarcarRealizada.Enabled = puedeMarcarRealizada;
                    chkReprogramarCita.Enabled = esModificable;
                }
            }
            else
            {
                _citaSeleccionada = null;
                grpAccionesCita.Enabled = false;
                lblInfoCitaSeleccionada.Text = "Seleccione una cita de la lista.";
                pnlReprogramacion.Visible = false;
            }
        }

        private void AccionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb && cb.Checked)
            {
                // Desmarcar los otros checkboxes de accion (excepto reprogramar)
                if (cb == chkConfirmarCita)
                {
                    chkCancelarCita.Checked = false;
                    chkMarcarRealizada.Checked = false;
                    chkReprogramarCita.Checked = false;
                }
                else if (cb == chkCancelarCita)
                {
                    chkConfirmarCita.Checked = false;
                    chkMarcarRealizada.Checked = false;
                    chkReprogramarCita.Checked = false;
                }
                else if (cb == chkMarcarRealizada)
                {
                    chkConfirmarCita.Checked = false;
                    chkCancelarCita.Checked = false;
                    chkReprogramarCita.Checked = false;
                }
            }
        }

        private void ChkReprogramarCita_CheckedChanged(object sender, EventArgs e)
        {
            pnlReprogramacion.Visible = chkReprogramarCita.Checked;
            if (chkReprogramarCita.Checked)
            {
                chkConfirmarCita.Checked = false;
                chkCancelarCita.Checked = false;
                chkMarcarRealizada.Checked = false;

                if (_citaSeleccionada != null)
                {
                    if (DateTime.TryParseExact(_citaSeleccionada.FechaCita, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaActualCita))
                    {
                        dtpNuevaFechaReprogramacion.Value = fechaActualCita >= DateTime.Today ? fechaActualCita : DateTime.Today;
                    }
                    else
                    {
                        dtpNuevaFechaReprogramacion.Value = DateTime.Today;
                    }
                    PoblarHorasDisponiblesParaReprogramacion();
                }
            }
            else
            {
                cmbNuevaHoraReprogramacion.DataSource = null;
                lblInfoDisponibilidad.Text = "";
            }
        }

        private void DtpNuevaFechaReprogramacion_ValueChanged(object sender, EventArgs e)
        {
            if (chkReprogramarCita.Checked && _citaSeleccionada != null)
            {
                PoblarHorasDisponiblesParaReprogramacion();
            }
        }

        private void PoblarHorasDisponiblesParaReprogramacion()
        {
            cmbNuevaHoraReprogramacion.DataSource = null;
            lblInfoDisponibilidad.Text = "Verificando disponibilidad...";
            if (_citaSeleccionada == null)
            {
                lblInfoDisponibilidad.Text = "Seleccione una cita primero.";
                return;
            }

            DateTime fechaSeleccionadaParaReprog = dtpNuevaFechaReprogramacion.Value.Date;
            int idProfesional = _citaSeleccionada.IdProfesionalMedico;

            var servicioCita = _servicioRepo.TraerTodos().FirstOrDefault(s => s.IdServicio == _citaSeleccionada.IdServicio);
            if (servicioCita == null)
            {
                lblInfoDisponibilidad.Text = "Error: No se encontro el servicio de la cita.";
                return;
            }
            int duracionCitaMinutos = servicioCita.DuracionEstimadaMin;

            string diaSemanaSeleccionadoDB = fechaSeleccionadaParaReprog.ToString("dddd", new CultureInfo("en-US"));
            var horariosTrabajoDelDia = _horarioRepo.TraerHorariosPorProfesional(idProfesional)
                                            .Where(h => h.DiaSemana.Equals(diaSemanaSeleccionadoDB, StringComparison.OrdinalIgnoreCase))
                                            .ToList();

            if (!horariosTrabajoDelDia.Any())
            {
                lblInfoDisponibilidad.Text = "El profesional no trabaja en la fecha seleccionada.";
                cmbNuevaHoraReprogramacion.Items.Clear(); // Limpiar por si acaso
                return;
            }

            var citasExistentesProfesionalFecha = _citaRepo.TraerCitasCompletasPorProfesionalYFecha(idProfesional, fechaSeleccionadaParaReprog)
                                                .Where(c => c.IdCita != _citaSeleccionada.IdCita && c.EstadoCita != "Cancelada por Paciente" && c.EstadoCita != "Cancelada por Clinica" && c.EstadoCita != "Cancelada por Secretaria")
                                                .ToList();

            List<string> slotsDisponibles = new List<string>();
            foreach (var rangoTrabajo in horariosTrabajoDelDia)
            {
                if (!TimeSpan.TryParse(rangoTrabajo.HoraInicioTrabajo, out TimeSpan horaInicioTrabajo) ||
                    !TimeSpan.TryParse(rangoTrabajo.HoraFinTrabajo, out TimeSpan horaFinTrabajo))
                {
                    continue; // Saltar si las horas de trabajo no son validas
                }

                TimeSpan slotActual = horaInicioTrabajo;
                while (slotActual.Add(TimeSpan.FromMinutes(duracionCitaMinutos)) <= horaFinTrabajo)
                {
                    TimeSpan slotFin = slotActual.Add(TimeSpan.FromMinutes(duracionCitaMinutos));
                    bool estaOcupado = false;
                    foreach (var citaExistente in citasExistentesProfesionalFecha)
                    {
                        if (TimeSpan.TryParse(citaExistente.HoraInicio, out TimeSpan inicioCitaExistente) &&
                            TimeSpan.TryParse(citaExistente.HoraFin, out TimeSpan finCitaExistente))
                        {
                            // Verificar superposicion
                            if (slotActual < finCitaExistente && slotFin > inicioCitaExistente)
                            {
                                estaOcupado = true;
                                break;
                            }
                        }
                    }

                    if (!estaOcupado)
                    {
                        if (fechaSeleccionadaParaReprog.Date == DateTime.Today && slotActual <= DateTime.Now.TimeOfDay)
                        {
                            // No agregar slots pasados para hoy
                        }
                        else
                        {
                            slotsDisponibles.Add(slotActual.ToString(@"hh\:mm"));
                        }
                    }
                    // El incremento debe ser segun la granularidad deseada para los slots
                    slotActual = slotActual.Add(TimeSpan.FromMinutes(15)); // Ejemplo: slots cada 15 minutos
                }
            }

            if (slotsDisponibles.Any())
            {
                cmbNuevaHoraReprogramacion.DataSource = slotsDisponibles.Distinct().OrderBy(s => s).ToList();
                lblInfoDisponibilidad.Text = "Horarios disponibles:";
            }
            else
            {
                cmbNuevaHoraReprogramacion.DataSource = null;
                cmbNuevaHoraReprogramacion.Items.Clear();
                lblInfoDisponibilidad.Text = "No hay horarios disponibles para esta fecha/duracion.";
            }
        }

        private void BtnGuardarCambiosCita_Click(object sender, EventArgs e)
        {
            if (_citaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una cita para gestionar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            int? idUsuarioLogueado = ObtenerIdUsuarioActual();

            try
            {
                bool operacionRealizada = false;
                string mensajeExito = "";

                if (chkReprogramarCita.Checked)
                {
                    if (cmbNuevaHoraReprogramacion.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione una nueva hora para reprogramar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string nuevaHoraInicioStr = cmbNuevaHoraReprogramacion.SelectedItem.ToString();
                    string nuevaFechaStrBD = dtpNuevaFechaReprogramacion.Value.ToString("yyyy-MM-dd");

                    var servicioCita = _servicioRepo.TraerTodos().FirstOrDefault(s => s.IdServicio == _citaSeleccionada.IdServicio);
                    if (servicioCita == null)
                    {
                        MessageBox.Show("Error: No se pudo encontrar el servicio de la cita para calcular la hora fin.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    TimeSpan horaInicioTimeSpan = TimeSpan.Parse(nuevaHoraInicioStr);
                    TimeSpan horaFinTimeSpan = horaInicioTimeSpan.Add(TimeSpan.FromMinutes(servicioCita.DuracionEstimadaMin));
                    string nuevaHoraFinStr = horaFinTimeSpan.ToString(@"hh\:mm");

                    // Al reprogramar, usualmente vuelve a "Programada" o "Confirmada" si se desea confirmar de inmediato
                    if (_citaRepo.ReprogramarCita(_citaSeleccionada.IdCita, nuevaFechaStrBD, nuevaHoraInicioStr, nuevaHoraFinStr, "Programada", idUsuarioLogueado))
                    {
                        operacionRealizada = true;
                        mensajeExito = "Cita reprogramada exitosamente al estado 'Programada'.";
                    }
                }
                else if (chkConfirmarCita.Checked)
                {
                    if (_citaRepo.ActualizarEstadoCita(_citaSeleccionada.IdCita, "Confirmada", idUsuarioLogueado))
                    {
                        operacionRealizada = true;
                        mensajeExito = "Cita confirmada exitosamente.";
                    }
                }
                else if (chkCancelarCita.Checked)
                {
                    // Podrias anadir un ComboBox para el motivo de cancelacion si quieres diferenciar
                    if (_citaRepo.ActualizarEstadoCita(_citaSeleccionada.IdCita, "Cancelada por Secretaria", idUsuarioLogueado))
                    {
                        operacionRealizada = true;
                        mensajeExito = "Cita cancelada exitosamente.";
                    }
                }
                else if (chkMarcarRealizada.Checked)
                {
                    if (_citaRepo.ActualizarEstadoCita(_citaSeleccionada.IdCita, "Realizada", idUsuarioLogueado))
                    {
                        operacionRealizada = true;
                        mensajeExito = "Cita marcada como realizada.";
                    }
                }
                else
                {
                    MessageBox.Show("No se selecciono ninguna accion (Confirmar, Cancelar, Realizada o Reprogramar).", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (operacionRealizada)
                {
                    MessageBox.Show(mensajeExito, "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCitas(); // Refrescar la lista de citas
                    // Resetear el panel de acciones
                    grpAccionesCita.Enabled = false;
                    lblInfoCitaSeleccionada.Text = "Seleccione una cita de la lista.";
                    pnlReprogramacion.Visible = false;
                    chkConfirmarCita.Checked = false;
                    chkCancelarCita.Checked = false;
                    chkMarcarRealizada.Checked = false;
                    chkReprogramarCita.Checked = false;
                }
                else
                {
                    MessageBox.Show("La operacion no pudo completarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cambios: {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? ObtenerIdUsuarioActual()
        {
            
            if (this.ParentForm is DashboardSecretariaForm dashboard)
            {
                var usuario = dashboard.ObtenerUsuarioActual(); 
                return usuario?.IdUsuarioSistema;
            }
           
            return 2; 
        }
    }
}