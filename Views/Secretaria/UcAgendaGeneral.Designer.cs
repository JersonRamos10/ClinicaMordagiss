namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class UcAgendaGeneral
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
            dtpFechaAgendaGeneral = new DateTimePicker();
            dgvAgendaGeneral = new DataGridView();
            lblRecordCitasPorConfirmar = new Label();
            lblRecordCitasSinAsistir = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAgendaGeneral).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaAgendaGeneral
            // 
            dtpFechaAgendaGeneral.Format = DateTimePickerFormat.Short;
            dtpFechaAgendaGeneral.Location = new Point(489, 102);
            dtpFechaAgendaGeneral.Name = "dtpFechaAgendaGeneral";
            dtpFechaAgendaGeneral.Size = new Size(200, 23);
            dtpFechaAgendaGeneral.TabIndex = 0;
            // 
            // dgvAgendaGeneral
            // 
            dgvAgendaGeneral.AllowUserToAddRows = false;
            dgvAgendaGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgendaGeneral.BackgroundColor = SystemColors.ControlLightLight;
            dgvAgendaGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendaGeneral.Location = new Point(289, 131);
            dgvAgendaGeneral.Name = "dgvAgendaGeneral";
            dgvAgendaGeneral.ReadOnly = true;
            dgvAgendaGeneral.Size = new Size(439, 233);
            dgvAgendaGeneral.TabIndex = 1;
            // 
            // lblRecordCitasPorConfirmar
            // 
            lblRecordCitasPorConfirmar.AutoSize = true;
            lblRecordCitasPorConfirmar.BackColor = SystemColors.MenuBar;
            lblRecordCitasPorConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecordCitasPorConfirmar.ForeColor = Color.DodgerBlue;
            lblRecordCitasPorConfirmar.Location = new Point(289, 412);
            lblRecordCitasPorConfirmar.Name = "lblRecordCitasPorConfirmar";
            lblRecordCitasPorConfirmar.Size = new Size(156, 15);
            lblRecordCitasPorConfirmar.TabIndex = 2;
            lblRecordCitasPorConfirmar.Text = "Citas por confirmar para : 0";
            // 
            // lblRecordCitasSinAsistir
            // 
            lblRecordCitasSinAsistir.AutoSize = true;
            lblRecordCitasSinAsistir.BackColor = SystemColors.MenuBar;
            lblRecordCitasSinAsistir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecordCitasSinAsistir.ForeColor = Color.DodgerBlue;
            lblRecordCitasSinAsistir.Location = new Point(289, 442);
            lblRecordCitasSinAsistir.Name = "lblRecordCitasSinAsistir";
            lblRecordCitasSinAsistir.Size = new Size(211, 15);
            lblRecordCitasSinAsistir.TabIndex = 3;
            lblRecordCitasSinAsistir.Text = "Citas de hoy sin registrar asistencia: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(289, 382);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 4;
            label1.Text = "Recordatorios / Pacientes";
            // 
            // UcAgendaGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label1);
            Controls.Add(lblRecordCitasSinAsistir);
            Controls.Add(lblRecordCitasPorConfirmar);
            Controls.Add(dgvAgendaGeneral);
            Controls.Add(dtpFechaAgendaGeneral);
            Name = "UcAgendaGeneral";
            Size = new Size(779, 499);
            ((System.ComponentModel.ISupportInitialize)dgvAgendaGeneral).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaAgendaGeneral;
        private DataGridView dgvAgendaGeneral;
        private Label lblRecordCitasPorConfirmar;
        private Label lblRecordCitasSinAsistir;
        private Label label1;
    }
}
