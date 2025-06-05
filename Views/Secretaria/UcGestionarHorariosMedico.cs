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
using System.Globalization;

namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    public partial class UcGestionarHorariosMedico: UserControl
    {
        private readonly MedicoRepo _medicoRepo;
        private readonly HorarioRepo _horarioRepo;
        private List<HorarioProfesionalMedico> _horariosDelProfesionalActual;
        private HorarioProfesionalMedico? _horarioSeleccionadoParaEdicion;

        public UcGestionarHorariosMedico()
        {
            InitializeComponent();

            _medicoRepo = new MedicoRepo();
            _horarioRepo = new HorarioRepo();
            _horariosDelProfesionalActual = new List<HorarioProfesionalMedico>();

            ConfigurarControles();
            PoblarProfesionales();

            // Suscribir eventos
            cmbProfesionales.SelectedIndexChanged += CmbProfesionales_SelectedIndexChanged;
            cmbAccionHorario.SelectedIndexChanged += CmbAccionHorario_SelectedIndexChanged;
            btnAgregarHorarioDia.Click += BtnAgregarHorarioDia_Click;
            dgvHorariosProfesional.SelectionChanged += DgvHorariosProfesional_SelectionChanged;
            btnActualizarHorarioSeleccionado.Click += BtnActualizarHorarioSeleccionado_Click;
            btnEliminarHorarioSeleccionado.Click += BtnEliminarHorarioSeleccionado_Click;
        }

        private void ConfigurarControles()
        {
            cmbAccionHorario.Items.Clear();
            cmbAccionHorario.Items.Add("Seleccione una accion...");
            cmbAccionHorario.Items.Add("Agregar Nuevo Horario para un Dia");
            cmbAccionHorario.Items.Add("Ver y Modificar Horarios Existentes");
            cmbAccionHorario.SelectedIndex = 0;
            cmbAccionHorario.Enabled = false;
            lblSeleccioneAccion.Enabled = false; 

            pnlAgregarHorario.Visible = false;
            pnlVerModificarHorarios.Visible = false;

            dtpHoraInicioNuevo.Format = DateTimePickerFormat.Custom;
            dtpHoraInicioNuevo.CustomFormat = "HH:mm";
            dtpHoraInicioNuevo.ShowUpDown = true;
            dtpHoraFinNuevo.Format = DateTimePickerFormat.Custom;
            dtpHoraFinNuevo.CustomFormat = "HH:mm";
            dtpHoraFinNuevo.ShowUpDown = true;

            dtpHoraInicioEdicion.Format = DateTimePickerFormat.Custom;
            dtpHoraInicioEdicion.CustomFormat = "HH:mm";
            dtpHoraInicioEdicion.ShowUpDown = true;
            dtpHoraFinEdicion.Format = DateTimePickerFormat.Custom;
            dtpHoraFinEdicion.CustomFormat = "HH:mm";
            dtpHoraFinEdicion.ShowUpDown = true;

            ConfigurarDataGridViewHorarios();
            grpEditarHorarioSeleccionado.Enabled = false;
            lblDiaSeleccionadoEdicion.Text = "Dia: (Ninguno seleccionado)";
        }

        private void ConfigurarDataGridViewHorarios()
        {
            dgvHorariosProfesional.Columns.Clear();
            dgvHorariosProfesional.AutoGenerateColumns = false;
            dgvHorariosProfesional.ReadOnly = true;
            dgvHorariosProfesional.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorariosProfesional.MultiSelect = false;
            dgvHorariosProfesional.AllowUserToAddRows = false;

            dgvHorariosProfesional.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdHorarioCol",
                DataPropertyName = "IdHorario",
                HeaderText = "ID",
                Visible = false
            });
            dgvHorariosProfesional.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiaSemanaCol",
                DataPropertyName = "DiaSemana",
                HeaderText = "Dia de la Semana",
                FillWeight = 40
            });
            dgvHorariosProfesional.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoraInicioCol",
                DataPropertyName = "HoraInicioTrabajo",
                HeaderText = "Hora Inicio",
                FillWeight = 30
            });
            dgvHorariosProfesional.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoraFinCol",
                DataPropertyName = "HoraFinTrabajo",
                HeaderText = "Hora Fin",
                FillWeight = 30
            });
            dgvHorariosProfesional.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PoblarProfesionales()
        {
            try
            {
                var profesionalesActivos = _medicoRepo.TraerTodos()
                                             .Where(m => m.Activo.Equals("Si", StringComparison.OrdinalIgnoreCase))
                                             .ToList();

                // Crear una lista de objetos para el ComboBox que incluya el ID y un texto descriptivo.
                var dataSourceProfesionales = profesionalesActivos.Select(p => new
                {
                    IdProfesional = p.IdProfesionalMedico,
                    NombreMostrado = $"{p.Nombre} {p.Apellidos}" // Asumiendo que ProfesionalMedico tiene Nombre y Apellidos
                }).ToList();

                cmbProfesionales.DataSource = dataSourceProfesionales;
                cmbProfesionales.DisplayMember = "NombreMostrado";
                cmbProfesionales.ValueMember = "IdProfesional";
                cmbProfesionales.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar profesionales: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbProfesionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfesionales.SelectedValue is int idProfesionalSeleccionado)
            {
                lblSeleccioneAccion.Enabled = true;
                cmbAccionHorario.Enabled = true;
                cmbAccionHorario.SelectedIndex = 0; // Resetear a "Seleccione una accion..."
                OcultarPanelesYResetearSubcontroles();
                CargarHorariosDelProfesionalParaDGV(idProfesionalSeleccionado); // Cargar para el DGV
            }
            else
            {
                lblSeleccioneAccion.Enabled = false;
                cmbAccionHorario.Enabled = false;
                cmbAccionHorario.SelectedIndex = 0;
                OcultarPanelesYResetearSubcontroles();
            }
        }

        private void CmbAccionHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccionHorario.SelectedItem == null || cmbProfesionales.SelectedValue == null)
            {
                OcultarPanelesYResetearSubcontroles();
                return;
            }

            string accionSeleccionada = cmbAccionHorario.SelectedItem.ToString();
            OcultarPanelesYResetearSubcontroles();

            if (accionSeleccionada == "Agregar Nuevo Horario para un Dia")
            {
                pnlAgregarHorario.Visible = true;
                PoblarDiasDisponiblesParaNuevoHorario((int)cmbProfesionales.SelectedValue);
            }
            else if (accionSeleccionada == "Ver y Modificar Horarios Existentes")
            {
                pnlVerModificarHorarios.Visible = true;
            
                if (dgvHorariosProfesional.DataSource == null && cmbProfesionales.SelectedValue is int idProf)
                {
                    CargarHorariosDelProfesionalParaDGV(idProf);
                }
            }
        }

        private void OcultarPanelesYResetearSubcontroles()
        {
            pnlAgregarHorario.Visible = false;
            pnlVerModificarHorarios.Visible = false;
            grpEditarHorarioSeleccionado.Enabled = false;
            lblDiaSeleccionadoEdicion.Text = "Dia: (Ninguno seleccionado)";
            _horarioSeleccionadoParaEdicion = null;
            if (dgvHorariosProfesional.SelectedRows.Count > 0)
            {
                dgvHorariosProfesional.ClearSelection();
            }
        }

        private void CargarHorariosDelProfesionalParaDGV(int idProfesional)
        {
            try
            {
                _horariosDelProfesionalActual = _horarioRepo.TraerHorariosPorProfesional(idProfesional);
                // Ordenar los horarios por un orden logico de dias de semana
                var diasOrdenados = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                var horariosOrdenados = _horariosDelProfesionalActual
                                        .OrderBy(h => diasOrdenados.IndexOf(h.DiaSemana))
                                        .ToList();

                dgvHorariosProfesional.DataSource = new BindingList<HorarioProfesionalMedico>(horariosOrdenados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar horarios del profesional: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvHorariosProfesional.DataSource = null;
                _horariosDelProfesionalActual.Clear();
            }
        }

        private void PoblarDiasDisponiblesParaNuevoHorario(int idProfesional)
        {
            cmbDiaSemanaNuevo.DataSource = null; // Limpiar fuente de datos anterior
            cmbDiaSemanaNuevo.Items.Clear();

            // Nombres de los dias como se deben guardar en la BD (ingles, segun modelo HorarioProfesionalMedico)
            var todosLosDiasDB = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Nombres de los dias para mostrar al usuario
            var culturaEs = new CultureInfo("es-ES"); // Para nombres de dias en español
            var diasParaDisplay = todosLosDiasDB.Select(diaDB => new DiaSemanaDisplayItem(
                culturaEs.DateTimeFormat.GetDayName((DayOfWeek)Enum.Parse(typeof(DayOfWeek), diaDB, true)), // Convierte "Monday" a "lunes", luego capitaliza.
                diaDB
            )).ToList();

            
            foreach (var item in diasParaDisplay)
            {
                item.NombreParaMostrar = char.ToUpper(item.NombreParaMostrar[0]) + item.NombreParaMostrar.Substring(1);
            }


            var diasYaConHorario = _horariosDelProfesionalActual.Select(h => h.DiaSemana.ToUpperInvariant()).ToList();
            var diasDisponibles = new List<DiaSemanaDisplayItem>();

            foreach (var diaItem in diasParaDisplay)
            {
                if (!diasYaConHorario.Contains(diaItem.ValorParaGuardar.ToUpperInvariant()))
                {
                    diasDisponibles.Add(diaItem);
                }
            }

            if (diasDisponibles.Any())
            {
                cmbDiaSemanaNuevo.DataSource = diasDisponibles;
                cmbDiaSemanaNuevo.DisplayMember = "NombreParaMostrar";
                cmbDiaSemanaNuevo.ValueMember = "ValorParaGuardar";
                cmbDiaSemanaNuevo.SelectedIndex = 0;
                HabilitarControlesPanelAgregar(true);
            }
            else
            {
                cmbDiaSemanaNuevo.Items.Add("Todos los dias tienen horario");
                cmbDiaSemanaNuevo.SelectedIndex = 0;
                HabilitarControlesPanelAgregar(false);
            }
        }

        private void HabilitarControlesPanelAgregar(bool habilitar)
        {
            dtpHoraInicioNuevo.Enabled = habilitar;
            dtpHoraFinNuevo.Enabled = habilitar;
            btnAgregarHorarioDia.Enabled = habilitar;
        }

        private class DiaSemanaDisplayItem
        {
            public string NombreParaMostrar { get; set; }
            public string ValorParaGuardar { get; set; }
            public DiaSemanaDisplayItem(string nombre, string valor)
            {
                NombreParaMostrar = nombre;
                ValorParaGuardar = valor;
            }
        }

        private void BtnAgregarHorarioDia_Click(object sender, EventArgs e)
        {
            if (cmbProfesionales.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un profesional.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(cmbDiaSemanaNuevo.SelectedItem is DiaSemanaDisplayItem diaSeleccionadoItem) ||
                string.IsNullOrEmpty(diaSeleccionadoItem.ValorParaGuardar))
            {
                MessageBox.Show("Seleccione un dia valido de la semana.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime horaInicio = dtpHoraInicioNuevo.Value;
            DateTime horaFin = dtpHoraFinNuevo.Value;

            if (horaInicio.TimeOfDay >= horaFin.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio debe ser anterior a la hora de fin.", "Validacion de Horas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoHorario = new HorarioProfesionalMedico
            {
                IdProfesionalMedico = (int)cmbProfesionales.SelectedValue,
                DiaSemana = diaSeleccionadoItem.ValorParaGuardar,
                HoraInicioTrabajo = horaInicio.ToString("HH:mm"),
                HoraFinTrabajo = horaFin.ToString("HH:mm")
            };

            try
            {
                if (_horarioRepo.InsertarHorarioDia(nuevoHorario))
                {
                    MessageBox.Show("Horario agregado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHorariosDelProfesionalParaDGV((int)cmbProfesionales.SelectedValue);
                    PoblarDiasDisponiblesParaNuevoHorario((int)cmbProfesionales.SelectedValue);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el horario. Es posible que ya exista un horario para ese dia.", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar horario: {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvHorariosProfesional_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHorariosProfesional.SelectedRows.Count > 0)
            {
                _horarioSeleccionadoParaEdicion = dgvHorariosProfesional.SelectedRows[0].DataBoundItem as HorarioProfesionalMedico;
                if (_horarioSeleccionadoParaEdicion != null)
                {
                    grpEditarHorarioSeleccionado.Enabled = true;

                
                    string diaParaMostrar = _horarioSeleccionadoParaEdicion.DiaSemana;
                    try
                    {
                        var culturaEs = new CultureInfo("es-ES");
                        var diaEnum = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), _horarioSeleccionadoParaEdicion.DiaSemana, true);
                        diaParaMostrar = culturaEs.DateTimeFormat.GetDayName(diaEnum);
                        diaParaMostrar = char.ToUpper(diaParaMostrar[0]) + diaParaMostrar.Substring(1);
                    }
                    catch { }
                    lblDiaSeleccionadoEdicion.Text = $"Dia: {diaParaMostrar}";

                    if (TimeSpan.TryParse(_horarioSeleccionadoParaEdicion.HoraInicioTrabajo, out TimeSpan inicio))
                    {
                        dtpHoraInicioEdicion.Value = DateTime.Today.Add(inicio);
                    }
                    if (TimeSpan.TryParse(_horarioSeleccionadoParaEdicion.HoraFinTrabajo, out TimeSpan fin))
                    {
                        dtpHoraFinEdicion.Value = DateTime.Today.Add(fin);
                    }
                }
            }
            else
            {
                grpEditarHorarioSeleccionado.Enabled = false;
                _horarioSeleccionadoParaEdicion = null;
                lblDiaSeleccionadoEdicion.Text = "Dia: (Ninguno seleccionado)";
            }
        }

        private void BtnActualizarHorarioSeleccionado_Click(object sender, EventArgs e)
        {
            if (_horarioSeleccionadoParaEdicion == null)
            {
                MessageBox.Show("Seleccione un horario de la lista para modificar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime nuevaHoraInicio = dtpHoraInicioEdicion.Value;
            DateTime nuevaHoraFin = dtpHoraFinEdicion.Value;

            if (nuevaHoraInicio.TimeOfDay >= nuevaHoraFin.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio debe ser anterior a la hora de fin.", "Validacion de Horas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _horarioSeleccionadoParaEdicion.HoraInicioTrabajo = nuevaHoraInicio.ToString("HH:mm");
            _horarioSeleccionadoParaEdicion.HoraFinTrabajo = nuevaHoraFin.ToString("HH:mm");

            try
            {
                if (_horarioRepo.ActualizarHorario(_horarioSeleccionadoParaEdicion))
                {
                    MessageBox.Show("Horario actualizado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHorariosDelProfesionalParaDGV((int)cmbProfesionales.SelectedValue);
                    grpEditarHorarioSeleccionado.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el horario.", "Error de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar horario: {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarHorarioSeleccionado_Click(object sender, EventArgs e)
        {
            if (_horarioSeleccionadoParaEdicion == null)
            {
                MessageBox.Show("Seleccione un horario de la lista para eliminar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show($"Esta seguro de que desea eliminar el horario del dia '{_horarioSeleccionadoParaEdicion.DiaSemana}' para este profesional?",
                                     "Confirmar Eliminacion",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (_horarioRepo.EliminarHorario(_horarioSeleccionadoParaEdicion.IdHorario))
                    {
                        MessageBox.Show("Horario eliminado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarHorariosDelProfesionalParaDGV((int)cmbProfesionales.SelectedValue);
                        PoblarDiasDisponiblesParaNuevoHorario((int)cmbProfesionales.SelectedValue);
                        grpEditarHorarioSeleccionado.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el horario.", "Error de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar horario: {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
