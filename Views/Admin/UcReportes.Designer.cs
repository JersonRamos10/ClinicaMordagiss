namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class UcReportes
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
            components = new System.ComponentModel.Container();
            dtpFechaInicioCitas = new DateTimePicker();
            dtpFechaFinCitas = new DateTimePicker();
            cmbProfesionalesReporte = new ComboBox();
            btnGenerarReporte = new Button();
            dgvReporteActividades = new DataGridView();
            epReporte = new ErrorProvider(components);
            lblErrorReporte = new Label();
            label1 = new Label();
            label2 = new Label();
            lblProfesional = new Label();
            btnExportarPDFReporte = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReporteActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epReporte).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaInicioCitas
            // 
            dtpFechaInicioCitas.Format = DateTimePickerFormat.Short;
            dtpFechaInicioCitas.Location = new Point(217, 148);
            dtpFechaInicioCitas.Name = "dtpFechaInicioCitas";
            dtpFechaInicioCitas.Size = new Size(200, 23);
            dtpFechaInicioCitas.TabIndex = 0;
            // 
            // dtpFechaFinCitas
            // 
            dtpFechaFinCitas.Format = DateTimePickerFormat.Short;
            dtpFechaFinCitas.Location = new Point(448, 148);
            dtpFechaFinCitas.Name = "dtpFechaFinCitas";
            dtpFechaFinCitas.Size = new Size(200, 23);
            dtpFechaFinCitas.TabIndex = 1;
            dtpFechaFinCitas.Value = new DateTime(2025, 6, 4, 7, 38, 17, 0);
            // 
            // cmbProfesionalesReporte
            // 
            cmbProfesionalesReporte.FormattingEnabled = true;
            cmbProfesionalesReporte.Location = new Point(351, 97);
            cmbProfesionalesReporte.Name = "cmbProfesionalesReporte";
            cmbProfesionalesReporte.Size = new Size(191, 23);
            cmbProfesionalesReporte.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = SystemColors.MenuHighlight;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarReporte.Location = new Point(668, 408);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(103, 30);
            btnGenerarReporte.TabIndex = 3;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // dgvReporteActividades
            // 
            dgvReporteActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteActividades.BackgroundColor = SystemColors.ControlLightLight;
            dgvReporteActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteActividades.Location = new Point(217, 205);
            dgvReporteActividades.Name = "dgvReporteActividades";
            dgvReporteActividades.ReadOnly = true;
            dgvReporteActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteActividades.Size = new Size(566, 197);
            dgvReporteActividades.TabIndex = 4;
            // 
            // epReporte
            // 
            epReporte.ContainerControl = this;
            // 
            // lblErrorReporte
            // 
            lblErrorReporte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblErrorReporte.AutoSize = true;
            lblErrorReporte.Location = new Point(448, 187);
            lblErrorReporte.Name = "lblErrorReporte";
            lblErrorReporte.Size = new Size(0, 15);
            lblErrorReporte.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 129);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(448, 130);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Fecha Fin:";
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfesional.Location = new Point(217, 100);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(116, 15);
            lblProfesional.TabIndex = 8;
            lblProfesional.Text = "Profesional Medico:";
            // 
            // btnExportarPDFReporte
            // 
            btnExportarPDFReporte.BackColor = SystemColors.MenuHighlight;
            btnExportarPDFReporte.FlatStyle = FlatStyle.Flat;
            btnExportarPDFReporte.ForeColor = SystemColors.ButtonHighlight;
            btnExportarPDFReporte.Location = new Point(545, 408);
            btnExportarPDFReporte.Name = "btnExportarPDFReporte";
            btnExportarPDFReporte.Size = new Size(103, 30);
            btnExportarPDFReporte.TabIndex = 9;
            btnExportarPDFReporte.Text = "Exportar a PDF";
            btnExportarPDFReporte.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(217, 185);
            label3.Name = "label3";
            label3.Size = new Size(209, 17);
            label3.TabIndex = 10;
            label3.Text = "Seleccionar una Fila de la Tabla :";
            // 
            // UcReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label3);
            Controls.Add(btnExportarPDFReporte);
            Controls.Add(lblProfesional);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblErrorReporte);
            Controls.Add(dgvReporteActividades);
            Controls.Add(btnGenerarReporte);
            Controls.Add(cmbProfesionalesReporte);
            Controls.Add(dtpFechaFinCitas);
            Controls.Add(dtpFechaInicioCitas);
            Name = "UcReportes";
            Size = new Size(810, 500);
            Load += UcReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporteActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)epReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaInicioCitas;
        private DateTimePicker dtpFechaFinCitas;
        private ComboBox cmbProfesionalesReporte;
        private Button btnGenerarReporte;
        private DataGridView dgvReporteActividades;
        private ErrorProvider epReporte;
        private Label label2;
        private Label label1;
        private Label lblErrorReporte;
        private Label lblProfesional;
        private Button btnExportarPDFReporte;
        private Label label3;
    }
}
