namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class UcGestionarCitas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblFechaDesde = new Label();
            dtpFechaDesde = new DateTimePicker();
            lblFechaHasta = new Label();
            dtpFechaHasta = new DateTimePicker();
            lblEstadoFiltro = new Label();
            cmbEstadoFiltro = new ComboBox();
            btnFiltrarCitas = new Button();
            dgvCitasGestion = new DataGridView();
            grpAccionesCita = new GroupBox();
            chkReprogramarCita = new CheckBox();
            chkMarcarRealizada = new CheckBox();
            chkCancelarCita = new CheckBox();
            chkConfirmarCita = new CheckBox();
            lblInfoCitaSeleccionada = new Label();
            pnlReprogramacion = new Panel();
            btnGuardarCambiosCita = new Button();
            cmbNuevaHoraReprogramacion = new ComboBox();
            lblInfoDisponibilidad = new Label();
            lblNuevaHora = new Label();
            dtpNuevaFechaReprogramacion = new DateTimePicker();
            lblNuevaFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCitasGestion).BeginInit();
            grpAccionesCita.SuspendLayout();
            pnlReprogramacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(241, 103);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(76, 15);
            lblFechaDesde.TabIndex = 0;
            lblFechaDesde.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(241, 121);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(200, 23);
            dtpFechaDesde.TabIndex = 1;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Location = new Point(240, 164);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(77, 15);
            lblFechaHasta.TabIndex = 2;
            lblFechaHasta.Text = "Fecha Hasta: ";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(241, 182);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(200, 23);
            dtpFechaHasta.TabIndex = 3;
            // 
            // lblEstadoFiltro
            // 
            lblEstadoFiltro.AutoSize = true;
            lblEstadoFiltro.Location = new Point(467, 103);
            lblEstadoFiltro.Name = "lblEstadoFiltro";
            lblEstadoFiltro.Size = new Size(99, 15);
            lblEstadoFiltro.TabIndex = 4;
            lblEstadoFiltro.Text = "Filtrar por Estado:";
            // 
            // cmbEstadoFiltro
            // 
            cmbEstadoFiltro.FormattingEnabled = true;
            cmbEstadoFiltro.Location = new Point(467, 121);
            cmbEstadoFiltro.Name = "cmbEstadoFiltro";
            cmbEstadoFiltro.Size = new Size(121, 23);
            cmbEstadoFiltro.TabIndex = 5;
            // 
            // btnFiltrarCitas
            // 
            btnFiltrarCitas.FlatStyle = FlatStyle.Popup;
            btnFiltrarCitas.Location = new Point(606, 120);
            btnFiltrarCitas.Name = "btnFiltrarCitas";
            btnFiltrarCitas.Size = new Size(75, 23);
            btnFiltrarCitas.TabIndex = 6;
            btnFiltrarCitas.Text = "Filtrar Citas";
            btnFiltrarCitas.UseVisualStyleBackColor = true;
            // 
            // dgvCitasGestion
            // 
            dgvCitasGestion.BackgroundColor = SystemColors.ControlLightLight;
            dgvCitasGestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasGestion.Location = new Point(241, 213);
            dgvCitasGestion.Name = "dgvCitasGestion";
            dgvCitasGestion.Size = new Size(590, 164);
            dgvCitasGestion.TabIndex = 7;
            // 
            // grpAccionesCita
            // 
            grpAccionesCita.Controls.Add(chkReprogramarCita);
            grpAccionesCita.Controls.Add(chkMarcarRealizada);
            grpAccionesCita.Controls.Add(chkCancelarCita);
            grpAccionesCita.Controls.Add(chkConfirmarCita);
            grpAccionesCita.Controls.Add(lblInfoCitaSeleccionada);
            grpAccionesCita.Location = new Point(241, 380);
            grpAccionesCita.Name = "grpAccionesCita";
            grpAccionesCita.Size = new Size(297, 162);
            grpAccionesCita.TabIndex = 8;
            grpAccionesCita.TabStop = false;
            grpAccionesCita.Text = "Gestionar Cita Seleccionada";
            // 
            // chkReprogramarCita
            // 
            chkReprogramarCita.AutoSize = true;
            chkReprogramarCita.Location = new Point(13, 107);
            chkReprogramarCita.Name = "chkReprogramarCita";
            chkReprogramarCita.Size = new Size(119, 19);
            chkReprogramarCita.TabIndex = 13;
            chkReprogramarCita.Text = "Reprogramar Cita";
            chkReprogramarCita.UseVisualStyleBackColor = true;
            // 
            // chkMarcarRealizada
            // 
            chkMarcarRealizada.AutoSize = true;
            chkMarcarRealizada.Location = new Point(13, 86);
            chkMarcarRealizada.Name = "chkMarcarRealizada";
            chkMarcarRealizada.Size = new Size(99, 19);
            chkMarcarRealizada.TabIndex = 12;
            chkMarcarRealizada.Text = "Cita Realizada";
            chkMarcarRealizada.UseVisualStyleBackColor = true;
            // 
            // chkCancelarCita
            // 
            chkCancelarCita.AutoSize = true;
            chkCancelarCita.Location = new Point(13, 65);
            chkCancelarCita.Name = "chkCancelarCita";
            chkCancelarCita.Size = new Size(96, 19);
            chkCancelarCita.TabIndex = 11;
            chkCancelarCita.Text = "Cancelar Cita";
            chkCancelarCita.UseVisualStyleBackColor = true;
            // 
            // chkConfirmarCita
            // 
            chkConfirmarCita.AutoSize = true;
            chkConfirmarCita.Location = new Point(13, 42);
            chkConfirmarCita.Name = "chkConfirmarCita";
            chkConfirmarCita.Size = new Size(104, 19);
            chkConfirmarCita.TabIndex = 10;
            chkConfirmarCita.Text = "Confirmar Cita";
            chkConfirmarCita.UseVisualStyleBackColor = true;
            // 
            // lblInfoCitaSeleccionada
            // 
            lblInfoCitaSeleccionada.AutoSize = true;
            lblInfoCitaSeleccionada.Location = new Point(13, 19);
            lblInfoCitaSeleccionada.Name = "lblInfoCitaSeleccionada";
            lblInfoCitaSeleccionada.Size = new Size(16, 15);
            lblInfoCitaSeleccionada.TabIndex = 9;
            lblInfoCitaSeleccionada.Text = "...";
            // 
            // pnlReprogramacion
            // 
            pnlReprogramacion.Controls.Add(cmbNuevaHoraReprogramacion);
            pnlReprogramacion.Controls.Add(lblInfoDisponibilidad);
            pnlReprogramacion.Controls.Add(lblNuevaHora);
            pnlReprogramacion.Controls.Add(dtpNuevaFechaReprogramacion);
            pnlReprogramacion.Controls.Add(lblNuevaFecha);
            pnlReprogramacion.Location = new Point(544, 389);
            pnlReprogramacion.Name = "pnlReprogramacion";
            pnlReprogramacion.Size = new Size(287, 153);
            pnlReprogramacion.TabIndex = 9;
            pnlReprogramacion.Visible = false;
            // 
            // btnGuardarCambiosCita
            // 
            btnGuardarCambiosCita.Location = new Point(486, 548);
            btnGuardarCambiosCita.Name = "btnGuardarCambiosCita";
            btnGuardarCambiosCita.Size = new Size(102, 23);
            btnGuardarCambiosCita.TabIndex = 13;
            btnGuardarCambiosCita.Text = "Aplicar Cambios";
            btnGuardarCambiosCita.UseVisualStyleBackColor = true;
            // 
            // cmbNuevaHoraReprogramacion
            // 
            cmbNuevaHoraReprogramacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNuevaHoraReprogramacion.FormattingEnabled = true;
            cmbNuevaHoraReprogramacion.Location = new Point(15, 84);
            cmbNuevaHoraReprogramacion.Name = "cmbNuevaHoraReprogramacion";
            cmbNuevaHoraReprogramacion.Size = new Size(121, 23);
            cmbNuevaHoraReprogramacion.TabIndex = 12;
            // 
            // lblInfoDisponibilidad
            // 
            lblInfoDisponibilidad.AutoSize = true;
            lblInfoDisponibilidad.Location = new Point(16, 105);
            lblInfoDisponibilidad.Name = "lblInfoDisponibilidad";
            lblInfoDisponibilidad.Size = new Size(16, 15);
            lblInfoDisponibilidad.TabIndex = 12;
            lblInfoDisponibilidad.Text = "...";
            // 
            // lblNuevaHora
            // 
            lblNuevaHora.AutoSize = true;
            lblNuevaHora.Location = new Point(17, 66);
            lblNuevaHora.Name = "lblNuevaHora";
            lblNuevaHora.Size = new Size(73, 15);
            lblNuevaHora.TabIndex = 11;
            lblNuevaHora.Text = "Nueva Hora:";
            // 
            // dtpNuevaFechaReprogramacion
            // 
            dtpNuevaFechaReprogramacion.Format = DateTimePickerFormat.Short;
            dtpNuevaFechaReprogramacion.Location = new Point(17, 33);
            dtpNuevaFechaReprogramacion.Name = "dtpNuevaFechaReprogramacion";
            dtpNuevaFechaReprogramacion.Size = new Size(200, 23);
            dtpNuevaFechaReprogramacion.TabIndex = 10;
            // 
            // lblNuevaFecha
            // 
            lblNuevaFecha.AutoSize = true;
            lblNuevaFecha.Location = new Point(17, 15);
            lblNuevaFecha.Name = "lblNuevaFecha";
            lblNuevaFecha.Size = new Size(78, 15);
            lblNuevaFecha.TabIndex = 10;
            lblNuevaFecha.Text = "Nueva Fecha:";
            // 
            // UcGestionarCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnGuardarCambiosCita);
            Controls.Add(pnlReprogramacion);
            Controls.Add(grpAccionesCita);
            Controls.Add(dgvCitasGestion);
            Controls.Add(btnFiltrarCitas);
            Controls.Add(cmbEstadoFiltro);
            Controls.Add(lblEstadoFiltro);
            Controls.Add(dtpFechaHasta);
            Controls.Add(lblFechaHasta);
            Controls.Add(dtpFechaDesde);
            Controls.Add(lblFechaDesde);
            Name = "UcGestionarCitas";
            Size = new Size(892, 639);
            ((System.ComponentModel.ISupportInitialize)dgvCitasGestion).EndInit();
            grpAccionesCita.ResumeLayout(false);
            grpAccionesCita.PerformLayout();
            pnlReprogramacion.ResumeLayout(false);
            pnlReprogramacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaDesde;
        private DateTimePicker dtpFechaDesde;
        private Label lblFechaHasta;
        private DateTimePicker dtpFechaHasta;
        private Label lblEstadoFiltro;
        private ComboBox cmbEstadoFiltro;
        private Button btnFiltrarCitas;
        private DataGridView dgvCitasGestion;
        private GroupBox grpAccionesCita;
        private CheckBox chkReprogramarCita;
        private CheckBox chkMarcarRealizada;
        private CheckBox chkCancelarCita;
        private CheckBox chkConfirmarCita;
        private Label lblInfoCitaSeleccionada;
        private Panel pnlReprogramacion;
        private ComboBox cmbNuevaHoraReprogramacion;
        private Label lblNuevaHora;
        private DateTimePicker dtpNuevaFechaReprogramacion;
        private Label lblNuevaFecha;
        private Label lblInfoDisponibilidad;
        private Button btnGuardarCambiosCita;
    }
}
