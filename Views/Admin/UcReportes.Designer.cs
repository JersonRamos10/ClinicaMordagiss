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
            ((System.ComponentModel.ISupportInitialize)dgvReporteActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epReporte).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaInicioCitas
            // 
            dtpFechaInicioCitas.Format = DateTimePickerFormat.Short;
            dtpFechaInicioCitas.Location = new Point(217, 147);
            dtpFechaInicioCitas.Name = "dtpFechaInicioCitas";
            dtpFechaInicioCitas.Size = new Size(200, 23);
            dtpFechaInicioCitas.TabIndex = 0;
            // 
            // dtpFechaFinCitas
            // 
            dtpFechaFinCitas.Format = DateTimePickerFormat.Short;
            dtpFechaFinCitas.Location = new Point(499, 147);
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
            cmbProfesionalesReporte.Size = new Size(121, 23);
            cmbProfesionalesReporte.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Location = new Point(668, 429);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(103, 30);
            btnGenerarReporte.TabIndex = 3;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // dgvReporteActividades
            // 
            dgvReporteActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteActividades.Location = new Point(217, 217);
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
            lblErrorReporte.Location = new Point(217, 188);
            lblErrorReporte.Name = "lblErrorReporte";
            lblErrorReporte.Size = new Size(0, 15);
            lblErrorReporte.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 150);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(714, 150);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Fecha Fin";
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Location = new Point(217, 97);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(109, 15);
            lblProfesional.TabIndex = 8;
            lblProfesional.Text = "Profesional Medico";
            // 
            // btnExportarPDFReporte
            // 
            btnExportarPDFReporte.Location = new Point(545, 429);
            btnExportarPDFReporte.Name = "btnExportarPDFReporte";
            btnExportarPDFReporte.Size = new Size(103, 30);
            btnExportarPDFReporte.TabIndex = 9;
            btnExportarPDFReporte.Text = "Exportar a PDF";
            btnExportarPDFReporte.UseVisualStyleBackColor = true;
            // 
            // UcReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
