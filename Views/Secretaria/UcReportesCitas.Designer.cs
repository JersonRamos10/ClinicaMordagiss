namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class UcReportesCitas
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
            dtpFechaFinReporte = new DateTimePicker();
            dtpFechaInicioReporte = new DateTimePicker();
            cmbServicioReporte = new ComboBox();
            cmbMedicoReporte = new ComboBox();
            btnGenerarReporteCitas = new Button();
            dgvReporteCitasSecretaria = new DataGridView();
            lblTituloResultadoReporte = new Label();
            grpFiltrosReporte = new GroupBox();
            lblErrorFiltros = new Label();
            lblServicioFiltroReporte = new Label();
            lblMedicoFiltroReporte = new Label();
            lblFechaFinReporte = new Label();
            lblFechaInicioReporte = new Label();
            lblPeriodoReporte = new Label();
            lblProfesionalSeleccionadoReporte = new Label();
            pnlResultadosReporte = new Panel();
            btnDescargarPdfReporte = new Button();
            btnImprimirReporte = new Button();
            lblServicioSeleccionadoReporte = new Label();
            epReporteSecretaria = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvReporteCitasSecretaria).BeginInit();
            grpFiltrosReporte.SuspendLayout();
            pnlResultadosReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epReporteSecretaria).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaFinReporte
            // 
            dtpFechaFinReporte.Format = DateTimePickerFormat.Short;
            dtpFechaFinReporte.Location = new Point(310, 59);
            dtpFechaFinReporte.Name = "dtpFechaFinReporte";
            dtpFechaFinReporte.Size = new Size(200, 23);
            dtpFechaFinReporte.TabIndex = 0;
            // 
            // dtpFechaInicioReporte
            // 
            dtpFechaInicioReporte.Format = DateTimePickerFormat.Short;
            dtpFechaInicioReporte.Location = new Point(68, 59);
            dtpFechaInicioReporte.Name = "dtpFechaInicioReporte";
            dtpFechaInicioReporte.Size = new Size(200, 23);
            dtpFechaInicioReporte.TabIndex = 1;
            // 
            // cmbServicioReporte
            // 
            cmbServicioReporte.FormattingEnabled = true;
            cmbServicioReporte.Location = new Point(315, 121);
            cmbServicioReporte.Name = "cmbServicioReporte";
            cmbServicioReporte.Size = new Size(121, 23);
            cmbServicioReporte.TabIndex = 2;
            // 
            // cmbMedicoReporte
            // 
            cmbMedicoReporte.FormattingEnabled = true;
            cmbMedicoReporte.Location = new Point(68, 121);
            cmbMedicoReporte.Name = "cmbMedicoReporte";
            cmbMedicoReporte.Size = new Size(121, 23);
            cmbMedicoReporte.TabIndex = 3;
            // 
            // btnGenerarReporteCitas
            // 
            btnGenerarReporteCitas.BackColor = SystemColors.HotTrack;
            btnGenerarReporteCitas.FlatStyle = FlatStyle.Flat;
            btnGenerarReporteCitas.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarReporteCitas.Location = new Point(68, 179);
            btnGenerarReporteCitas.Name = "btnGenerarReporteCitas";
            btnGenerarReporteCitas.Size = new Size(80, 28);
            btnGenerarReporteCitas.TabIndex = 4;
            btnGenerarReporteCitas.Text = "Generar Reporte";
            btnGenerarReporteCitas.UseVisualStyleBackColor = false;
            // 
            // dgvReporteCitasSecretaria
            // 
            dgvReporteCitasSecretaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteCitasSecretaria.Location = new Point(8, 114);
            dgvReporteCitasSecretaria.Name = "dgvReporteCitasSecretaria";
            dgvReporteCitasSecretaria.Size = new Size(547, 150);
            dgvReporteCitasSecretaria.TabIndex = 5;
            // 
            // lblTituloResultadoReporte
            // 
            lblTituloResultadoReporte.AutoSize = true;
            lblTituloResultadoReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloResultadoReporte.Location = new Point(3, 5);
            lblTituloResultadoReporte.Name = "lblTituloResultadoReporte";
            lblTituloResultadoReporte.Size = new Size(160, 15);
            lblTituloResultadoReporte.TabIndex = 6;
            lblTituloResultadoReporte.Text = "RESULTADO DE BUSQUEDA";
            // 
            // grpFiltrosReporte
            // 
            grpFiltrosReporte.Controls.Add(lblErrorFiltros);
            grpFiltrosReporte.Controls.Add(lblServicioFiltroReporte);
            grpFiltrosReporte.Controls.Add(lblMedicoFiltroReporte);
            grpFiltrosReporte.Controls.Add(lblFechaFinReporte);
            grpFiltrosReporte.Controls.Add(lblFechaInicioReporte);
            grpFiltrosReporte.Controls.Add(dtpFechaInicioReporte);
            grpFiltrosReporte.Controls.Add(dtpFechaFinReporte);
            grpFiltrosReporte.Controls.Add(cmbServicioReporte);
            grpFiltrosReporte.Controls.Add(btnGenerarReporteCitas);
            grpFiltrosReporte.Controls.Add(cmbMedicoReporte);
            grpFiltrosReporte.Location = new Point(287, 96);
            grpFiltrosReporte.Name = "grpFiltrosReporte";
            grpFiltrosReporte.Size = new Size(561, 218);
            grpFiltrosReporte.TabIndex = 7;
            grpFiltrosReporte.TabStop = false;
            grpFiltrosReporte.Text = "Filtros del Reporte de Citas";
            // 
            // lblErrorFiltros
            // 
            lblErrorFiltros.AutoSize = true;
            lblErrorFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblErrorFiltros.Location = new Point(166, 188);
            lblErrorFiltros.Name = "lblErrorFiltros";
            lblErrorFiltros.Size = new Size(16, 15);
            lblErrorFiltros.TabIndex = 13;
            lblErrorFiltros.Text = "...";
            // 
            // lblServicioFiltroReporte
            // 
            lblServicioFiltroReporte.AutoSize = true;
            lblServicioFiltroReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblServicioFiltroReporte.Location = new Point(310, 103);
            lblServicioFiltroReporte.Name = "lblServicioFiltroReporte";
            lblServicioFiltroReporte.Size = new Size(55, 15);
            lblServicioFiltroReporte.TabIndex = 8;
            lblServicioFiltroReporte.Text = "Servicio:";
            // 
            // lblMedicoFiltroReporte
            // 
            lblMedicoFiltroReporte.AutoSize = true;
            lblMedicoFiltroReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedicoFiltroReporte.Location = new Point(68, 103);
            lblMedicoFiltroReporte.Name = "lblMedicoFiltroReporte";
            lblMedicoFiltroReporte.Size = new Size(116, 15);
            lblMedicoFiltroReporte.TabIndex = 8;
            lblMedicoFiltroReporte.Text = "Profesional Medico:";
            // 
            // lblFechaFinReporte
            // 
            lblFechaFinReporte.AutoSize = true;
            lblFechaFinReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaFinReporte.Location = new Point(310, 41);
            lblFechaFinReporte.Name = "lblFechaFinReporte";
            lblFechaFinReporte.Size = new Size(76, 15);
            lblFechaFinReporte.TabIndex = 9;
            lblFechaFinReporte.Text = "Fecha Hasta:";
            // 
            // lblFechaInicioReporte
            // 
            lblFechaInicioReporte.AutoSize = true;
            lblFechaInicioReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaInicioReporte.Location = new Point(68, 41);
            lblFechaInicioReporte.Name = "lblFechaInicioReporte";
            lblFechaInicioReporte.Size = new Size(80, 15);
            lblFechaInicioReporte.TabIndex = 10;
            lblFechaInicioReporte.Text = "Fecha Desde:";
            // 
            // lblPeriodoReporte
            // 
            lblPeriodoReporte.AutoSize = true;
            lblPeriodoReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPeriodoReporte.Location = new Point(289, 360);
            lblPeriodoReporte.Name = "lblPeriodoReporte";
            lblPeriodoReporte.Size = new Size(232, 15);
            lblPeriodoReporte.TabIndex = 11;
            lblPeriodoReporte.Text = "PERIODO: [dd/MM/yyyy] - [dd/MM/yyyy]";
            // 
            // lblProfesionalSeleccionadoReporte
            // 
            lblProfesionalSeleccionadoReporte.AutoSize = true;
            lblProfesionalSeleccionadoReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProfesionalSeleccionadoReporte.Location = new Point(3, 62);
            lblProfesionalSeleccionadoReporte.Name = "lblProfesionalSeleccionadoReporte";
            lblProfesionalSeleccionadoReporte.Size = new Size(304, 15);
            lblProfesionalSeleccionadoReporte.TabIndex = 12;
            lblProfesionalSeleccionadoReporte.Text = "PROFESIONAL MEDICO: [Nombre del Medico o Todos]";
            // 
            // pnlResultadosReporte
            // 
            pnlResultadosReporte.Controls.Add(btnDescargarPdfReporte);
            pnlResultadosReporte.Controls.Add(btnImprimirReporte);
            pnlResultadosReporte.Controls.Add(lblServicioSeleccionadoReporte);
            pnlResultadosReporte.Controls.Add(lblProfesionalSeleccionadoReporte);
            pnlResultadosReporte.Controls.Add(dgvReporteCitasSecretaria);
            pnlResultadosReporte.Controls.Add(lblTituloResultadoReporte);
            pnlResultadosReporte.Location = new Point(287, 325);
            pnlResultadosReporte.Name = "pnlResultadosReporte";
            pnlResultadosReporte.Size = new Size(561, 302);
            pnlResultadosReporte.TabIndex = 13;
            pnlResultadosReporte.Visible = false;
            // 
            // btnDescargarPdfReporte
            // 
            btnDescargarPdfReporte.BackColor = SystemColors.HotTrack;
            btnDescargarPdfReporte.FlatStyle = FlatStyle.Flat;
            btnDescargarPdfReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDescargarPdfReporte.ForeColor = SystemColors.ButtonHighlight;
            btnDescargarPdfReporte.Location = new Point(430, 270);
            btnDescargarPdfReporte.Name = "btnDescargarPdfReporte";
            btnDescargarPdfReporte.Size = new Size(125, 29);
            btnDescargarPdfReporte.TabIndex = 15;
            btnDescargarPdfReporte.Text = "Generar Reporte";
            btnDescargarPdfReporte.UseVisualStyleBackColor = false;
            // 
            // btnImprimirReporte
            // 
            btnImprimirReporte.FlatStyle = FlatStyle.Flat;
            btnImprimirReporte.Location = new Point(344, 270);
            btnImprimirReporte.Name = "btnImprimirReporte";
            btnImprimirReporte.Size = new Size(80, 29);
            btnImprimirReporte.TabIndex = 14;
            btnImprimirReporte.Text = "Imprimir";
            btnImprimirReporte.UseVisualStyleBackColor = true;
            // 
            // lblServicioSeleccionadoReporte
            // 
            lblServicioSeleccionadoReporte.AutoSize = true;
            lblServicioSeleccionadoReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblServicioSeleccionadoReporte.Location = new Point(8, 90);
            lblServicioSeleccionadoReporte.Name = "lblServicioSeleccionadoReporte";
            lblServicioSeleccionadoReporte.Size = new Size(233, 15);
            lblServicioSeleccionadoReporte.TabIndex = 13;
            lblServicioSeleccionadoReporte.Text = "SERVICIO: [Nombre del Servicio o Todos]";
            // 
            // epReporteSecretaria
            // 
            epReporteSecretaria.ContainerControl = this;
            // 
            // UcReportesCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPeriodoReporte);
            Controls.Add(grpFiltrosReporte);
            Controls.Add(pnlResultadosReporte);
            Name = "UcReportesCitas";
            Size = new Size(906, 635);
            ((System.ComponentModel.ISupportInitialize)dgvReporteCitasSecretaria).EndInit();
            grpFiltrosReporte.ResumeLayout(false);
            grpFiltrosReporte.PerformLayout();
            pnlResultadosReporte.ResumeLayout(false);
            pnlResultadosReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epReporteSecretaria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaFinReporte;
        private DateTimePicker dtpFechaInicioReporte;
        private ComboBox cmbServicioReporte;
        private ComboBox cmbMedicoReporte;
        private Button btnGenerarReporteCitas;
        private DataGridView dgvReporteCitasSecretaria;
        private Label lblTituloResultadoReporte;
        private GroupBox grpFiltrosReporte;
        private Label lblServicioFiltroReporte;
        private Label lblMedicoFiltroReporte;
        private Label lblFechaFinReporte;
        private Label lblFechaInicioReporte;
        private Label lblPeriodoReporte;
        private Label lblProfesionalSeleccionadoReporte;
        private Label lblErrorFiltros;
        private Panel pnlResultadosReporte;
        private Label lblServicioSeleccionadoReporte;
        private Button btnDescargarPdfReporte;
        private Button btnImprimirReporte;
        private ErrorProvider epReporteSecretaria;
    }
}
