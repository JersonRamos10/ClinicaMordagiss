namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class UcGestionarHorariosMedico
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
            lblSeleccioneProfesional = new Label();
            cmbProfesionales = new ComboBox();
            cmbAccionHorario = new ComboBox();
            label1 = new Label();
            pnlAgregarHorario = new Panel();
            pnlVerModificarHorarios = new Panel();
            dgvHorariosProfesional = new DataGridView();
            lblSeleccioneAccion = new Label();
            lblDiaSeleccionadoEdicion = new Label();
            grpEditarHorarioSeleccionado = new GroupBox();
            btnEliminarHorarioSeleccionado = new Button();
            lblHoraInicioEdicion = new Label();
            dtpHoraInicioEdicion = new DateTimePicker();
            dtpHoraFinEdicion = new DateTimePicker();
            btnActualizarHorarioSeleccionado = new Button();
            lblHoraFinEdicion = new Label();
            btnAgregarHorarioDia = new Button();
            label3 = new Label();
            dtpHoraFinNuevo = new DateTimePicker();
            label2 = new Label();
            dtpHoraInicioNuevo = new DateTimePicker();
            lblDiaSemanaNuevo = new Label();
            cmbDiaSemanaNuevo = new ComboBox();
            pnlAgregarHorario.SuspendLayout();
            pnlVerModificarHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorariosProfesional).BeginInit();
            grpEditarHorarioSeleccionado.SuspendLayout();
            SuspendLayout();
            // 
            // lblSeleccioneProfesional
            // 
            lblSeleccioneProfesional.AutoSize = true;
            lblSeleccioneProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSeleccioneProfesional.Location = new Point(297, 89);
            lblSeleccioneProfesional.Name = "lblSeleccioneProfesional";
            lblSeleccioneProfesional.Size = new Size(135, 15);
            lblSeleccioneProfesional.TabIndex = 0;
            lblSeleccioneProfesional.Text = "Seleccione Profesional:";
            // 
            // cmbProfesionales
            // 
            cmbProfesionales.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfesionales.FormattingEnabled = true;
            cmbProfesionales.Location = new Point(297, 111);
            cmbProfesionales.Name = "cmbProfesionales";
            cmbProfesionales.Size = new Size(195, 23);
            cmbProfesionales.TabIndex = 1;
            // 
            // cmbAccionHorario
            // 
            cmbAccionHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccionHorario.FormattingEnabled = true;
            cmbAccionHorario.Location = new Point(530, 110);
            cmbAccionHorario.Name = "cmbAccionHorario";
            cmbAccionHorario.Size = new Size(195, 23);
            cmbAccionHorario.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(530, 89);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 4;
            label1.Text = "Seleccione una Accion: ";
            // 
            // pnlAgregarHorario
            // 
            pnlAgregarHorario.Controls.Add(btnAgregarHorarioDia);
            pnlAgregarHorario.Controls.Add(label3);
            pnlAgregarHorario.Controls.Add(dtpHoraFinNuevo);
            pnlAgregarHorario.Controls.Add(label2);
            pnlAgregarHorario.Controls.Add(dtpHoraInicioNuevo);
            pnlAgregarHorario.Controls.Add(lblDiaSemanaNuevo);
            pnlAgregarHorario.Controls.Add(cmbDiaSemanaNuevo);
            pnlAgregarHorario.Location = new Point(296, 146);
            pnlAgregarHorario.Name = "pnlAgregarHorario";
            pnlAgregarHorario.Size = new Size(462, 260);
            pnlAgregarHorario.TabIndex = 6;
            // 
            // pnlVerModificarHorarios
            // 
            pnlVerModificarHorarios.Controls.Add(dgvHorariosProfesional);
            pnlVerModificarHorarios.Controls.Add(lblSeleccioneAccion);
            pnlVerModificarHorarios.Controls.Add(lblDiaSeleccionadoEdicion);
            pnlVerModificarHorarios.Controls.Add(grpEditarHorarioSeleccionado);
            pnlVerModificarHorarios.Location = new Point(293, 160);
            pnlVerModificarHorarios.Name = "pnlVerModificarHorarios";
            pnlVerModificarHorarios.Size = new Size(462, 395);
            pnlVerModificarHorarios.TabIndex = 13;
            // 
            // dgvHorariosProfesional
            // 
            dgvHorariosProfesional.BackgroundColor = SystemColors.ControlLightLight;
            dgvHorariosProfesional.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorariosProfesional.Location = new Point(32, 30);
            dgvHorariosProfesional.Name = "dgvHorariosProfesional";
            dgvHorariosProfesional.Size = new Size(413, 150);
            dgvHorariosProfesional.TabIndex = 13;
            // 
            // lblSeleccioneAccion
            // 
            lblSeleccioneAccion.AutoSize = true;
            lblSeleccioneAccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccioneAccion.Location = new Point(32, 9);
            lblSeleccioneAccion.Name = "lblSeleccioneAccion";
            lblSeleccioneAccion.Size = new Size(125, 15);
            lblSeleccioneAccion.TabIndex = 7;
            lblSeleccioneAccion.Text = "Horarios Registrados:";
            // 
            // lblDiaSeleccionadoEdicion
            // 
            lblDiaSeleccionadoEdicion.AutoSize = true;
            lblDiaSeleccionadoEdicion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiaSeleccionadoEdicion.Location = new Point(32, 190);
            lblDiaSeleccionadoEdicion.Name = "lblDiaSeleccionadoEdicion";
            lblDiaSeleccionadoEdicion.Size = new Size(181, 15);
            lblDiaSeleccionadoEdicion.TabIndex = 9;
            lblDiaSeleccionadoEdicion.Text = "Editando Dia: [Nombre del Dia])";
            // 
            // grpEditarHorarioSeleccionado
            // 
            grpEditarHorarioSeleccionado.Controls.Add(btnEliminarHorarioSeleccionado);
            grpEditarHorarioSeleccionado.Controls.Add(lblHoraInicioEdicion);
            grpEditarHorarioSeleccionado.Controls.Add(dtpHoraInicioEdicion);
            grpEditarHorarioSeleccionado.Controls.Add(dtpHoraFinEdicion);
            grpEditarHorarioSeleccionado.Controls.Add(btnActualizarHorarioSeleccionado);
            grpEditarHorarioSeleccionado.Controls.Add(lblHoraFinEdicion);
            grpEditarHorarioSeleccionado.Location = new Point(32, 210);
            grpEditarHorarioSeleccionado.Name = "grpEditarHorarioSeleccionado";
            grpEditarHorarioSeleccionado.Size = new Size(412, 179);
            grpEditarHorarioSeleccionado.TabIndex = 7;
            grpEditarHorarioSeleccionado.TabStop = false;
            grpEditarHorarioSeleccionado.Text = "Edicion";
            // 
            // btnEliminarHorarioSeleccionado
            // 
            btnEliminarHorarioSeleccionado.BackColor = Color.Crimson;
            btnEliminarHorarioSeleccionado.FlatStyle = FlatStyle.Flat;
            btnEliminarHorarioSeleccionado.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarHorarioSeleccionado.Location = new Point(212, 138);
            btnEliminarHorarioSeleccionado.Name = "btnEliminarHorarioSeleccionado";
            btnEliminarHorarioSeleccionado.Size = new Size(80, 30);
            btnEliminarHorarioSeleccionado.TabIndex = 15;
            btnEliminarHorarioSeleccionado.Text = "Eliminar";
            btnEliminarHorarioSeleccionado.UseVisualStyleBackColor = false;
            // 
            // lblHoraInicioEdicion
            // 
            lblHoraInicioEdicion.AutoSize = true;
            lblHoraInicioEdicion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoraInicioEdicion.Location = new Point(17, 31);
            lblHoraInicioEdicion.Name = "lblHoraInicioEdicion";
            lblHoraInicioEdicion.Size = new Size(109, 15);
            lblHoraInicioEdicion.TabIndex = 14;
            lblHoraInicioEdicion.Text = "Nueva Hora Inicio:";
            // 
            // dtpHoraInicioEdicion
            // 
            dtpHoraInicioEdicion.Format = DateTimePickerFormat.Time;
            dtpHoraInicioEdicion.Location = new Point(17, 49);
            dtpHoraInicioEdicion.Name = "dtpHoraInicioEdicion";
            dtpHoraInicioEdicion.Size = new Size(200, 23);
            dtpHoraInicioEdicion.TabIndex = 8;
            // 
            // dtpHoraFinEdicion
            // 
            dtpHoraFinEdicion.Format = DateTimePickerFormat.Time;
            dtpHoraFinEdicion.Location = new Point(17, 109);
            dtpHoraFinEdicion.Name = "dtpHoraFinEdicion";
            dtpHoraFinEdicion.Size = new Size(200, 23);
            dtpHoraFinEdicion.TabIndex = 10;
            // 
            // btnActualizarHorarioSeleccionado
            // 
            btnActualizarHorarioSeleccionado.BackColor = SystemColors.HotTrack;
            btnActualizarHorarioSeleccionado.FlatStyle = FlatStyle.Flat;
            btnActualizarHorarioSeleccionado.ForeColor = SystemColors.ControlLightLight;
            btnActualizarHorarioSeleccionado.Location = new Point(310, 137);
            btnActualizarHorarioSeleccionado.Name = "btnActualizarHorarioSeleccionado";
            btnActualizarHorarioSeleccionado.Size = new Size(79, 31);
            btnActualizarHorarioSeleccionado.TabIndex = 12;
            btnActualizarHorarioSeleccionado.Text = "Actualizar";
            btnActualizarHorarioSeleccionado.UseVisualStyleBackColor = false;
            // 
            // lblHoraFinEdicion
            // 
            lblHoraFinEdicion.AutoSize = true;
            lblHoraFinEdicion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoraFinEdicion.Location = new Point(17, 91);
            lblHoraFinEdicion.Name = "lblHoraFinEdicion";
            lblHoraFinEdicion.Size = new Size(95, 15);
            lblHoraFinEdicion.TabIndex = 11;
            lblHoraFinEdicion.Text = "Nueva Hora Fin:";
            // 
            // btnAgregarHorarioDia
            // 
            btnAgregarHorarioDia.BackColor = SystemColors.HotTrack;
            btnAgregarHorarioDia.FlatStyle = FlatStyle.Flat;
            btnAgregarHorarioDia.ForeColor = SystemColors.ControlLightLight;
            btnAgregarHorarioDia.Location = new Point(321, 206);
            btnAgregarHorarioDia.Name = "btnAgregarHorarioDia";
            btnAgregarHorarioDia.Size = new Size(82, 29);
            btnAgregarHorarioDia.TabIndex = 12;
            btnAgregarHorarioDia.Text = "Agregar Horario";
            btnAgregarHorarioDia.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 143);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 11;
            label3.Text = "Hora Fin:";
            // 
            // dtpHoraFinNuevo
            // 
            dtpHoraFinNuevo.Format = DateTimePickerFormat.Time;
            dtpHoraFinNuevo.Location = new Point(28, 161);
            dtpHoraFinNuevo.Name = "dtpHoraFinNuevo";
            dtpHoraFinNuevo.Size = new Size(300, 23);
            dtpHoraFinNuevo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 9;
            label2.Text = "Hora Inicio:";
            // 
            // dtpHoraInicioNuevo
            // 
            dtpHoraInicioNuevo.Format = DateTimePickerFormat.Time;
            dtpHoraInicioNuevo.Location = new Point(28, 102);
            dtpHoraInicioNuevo.Name = "dtpHoraInicioNuevo";
            dtpHoraInicioNuevo.Size = new Size(300, 23);
            dtpHoraInicioNuevo.TabIndex = 8;
            // 
            // lblDiaSemanaNuevo
            // 
            lblDiaSemanaNuevo.AutoSize = true;
            lblDiaSemanaNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaSemanaNuevo.Location = new Point(28, 14);
            lblDiaSemanaNuevo.Name = "lblDiaSemanaNuevo";
            lblDiaSemanaNuevo.Size = new Size(104, 15);
            lblDiaSemanaNuevo.TabIndex = 7;
            lblDiaSemanaNuevo.Text = "Dia de la Semana:";
            // 
            // cmbDiaSemanaNuevo
            // 
            cmbDiaSemanaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiaSemanaNuevo.FormattingEnabled = true;
            cmbDiaSemanaNuevo.Location = new Point(28, 45);
            cmbDiaSemanaNuevo.Name = "cmbDiaSemanaNuevo";
            cmbDiaSemanaNuevo.Size = new Size(300, 23);
            cmbDiaSemanaNuevo.TabIndex = 7;
            // 
            // UcGestionarHorariosMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(pnlVerModificarHorarios);
            Controls.Add(pnlAgregarHorario);
            Controls.Add(cmbAccionHorario);
            Controls.Add(label1);
            Controls.Add(cmbProfesionales);
            Controls.Add(lblSeleccioneProfesional);
            Name = "UcGestionarHorariosMedico";
            Size = new Size(892, 639);
            pnlAgregarHorario.ResumeLayout(false);
            pnlAgregarHorario.PerformLayout();
            pnlVerModificarHorarios.ResumeLayout(false);
            pnlVerModificarHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorariosProfesional).EndInit();
            grpEditarHorarioSeleccionado.ResumeLayout(false);
            grpEditarHorarioSeleccionado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSeleccioneProfesional;
        private ComboBox cmbProfesionales;
        private ComboBox cmbAccionHorario;
        private Label label1;
        private Panel pnlAgregarHorario;
        private ComboBox cmbDiaSemanaNuevo;
        private DateTimePicker dtpHoraInicioNuevo;
        private Label lblDiaSemanaNuevo;
        private Button btnAgregarHorarioDia;
        private Label label3;
        private DateTimePicker dtpHoraFinNuevo;
        private Label label2;
        private Panel pnlVerModificarHorarios;
        private DataGridView dgvHorariosProfesional;
        private Label lblSeleccioneAccion;
        private Label lblDiaSeleccionadoEdicion;
        private GroupBox grpEditarHorarioSeleccionado;
        private Button btnEliminarHorarioSeleccionado;
        private Label lblHoraInicioEdicion;
        private DateTimePicker dtpHoraInicioEdicion;
        private DateTimePicker dtpHoraFinEdicion;
        private Button btnActualizarHorarioSeleccionado;
        private Label lblHoraFinEdicion;
    }
}
