namespace SistemaDeCitasMordagiss.Views
{
    partial class DashboardMedicoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMedicoForm));
            lblFechaHoraActual = new Label();
            lblBienvenidoMedico = new Label();
            btnCerrarSesionMedico = new Button();
            pictureBox3 = new PictureBox();
            lkAgenda = new LinkLabel();
            lblRol = new Label();
            panel1 = new Panel();
            dgvCitasMedico = new DataGridView();
            lblTituloAgenda = new Label();
            dtpSeleccionFechaCitas = new DateTimePicker();
            lblErrorMedico = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasMedico).BeginInit();
            SuspendLayout();
            // 
            // lblFechaHoraActual
            // 
            lblFechaHoraActual.AutoSize = true;
            lblFechaHoraActual.Location = new Point(248, 61);
            lblFechaHoraActual.Name = "lblFechaHoraActual";
            lblFechaHoraActual.Size = new Size(16, 15);
            lblFechaHoraActual.TabIndex = 0;
            lblFechaHoraActual.Text = "...";
            // 
            // lblBienvenidoMedico
            // 
            lblBienvenidoMedico.AutoSize = true;
            lblBienvenidoMedico.Location = new Point(248, 29);
            lblBienvenidoMedico.Name = "lblBienvenidoMedico";
            lblBienvenidoMedico.Size = new Size(65, 15);
            lblBienvenidoMedico.TabIndex = 1;
            lblBienvenidoMedico.Text = "Bienvenida";
            // 
            // btnCerrarSesionMedico
            // 
            btnCerrarSesionMedico.BackColor = SystemColors.InactiveCaption;
            btnCerrarSesionMedico.FlatStyle = FlatStyle.Flat;
            btnCerrarSesionMedico.Location = new Point(679, 29);
            btnCerrarSesionMedico.Name = "btnCerrarSesionMedico";
            btnCerrarSesionMedico.Size = new Size(92, 30);
            btnCerrarSesionMedico.TabIndex = 2;
            btnCerrarSesionMedico.Text = "Cerrar Sesion";
            btnCerrarSesionMedico.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(45, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // lkAgenda
            // 
            lkAgenda.AutoSize = true;
            lkAgenda.LinkColor = Color.DimGray;
            lkAgenda.Location = new Point(45, 234);
            lkAgenda.Name = "lkAgenda";
            lkAgenda.Size = new Size(116, 15);
            lkAgenda.TabIndex = 16;
            lkAgenda.TabStop = true;
            lkAgenda.Text = "Consutar Mi Agenda";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(45, 140);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 11;
            lblRol.Text = "Rol";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(lkAgenda);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblRol);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 451);
            panel1.TabIndex = 17;
            // 
            // dgvCitasMedico
            // 
            dgvCitasMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitasMedico.BackgroundColor = SystemColors.ControlLightLight;
            dgvCitasMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasMedico.Location = new Point(248, 234);
            dgvCitasMedico.Name = "dgvCitasMedico";
            dgvCitasMedico.ReadOnly = true;
            dgvCitasMedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitasMedico.Size = new Size(523, 192);
            dgvCitasMedico.TabIndex = 18;
            // 
            // lblTituloAgenda
            // 
            lblTituloAgenda.AutoSize = true;
            lblTituloAgenda.Location = new Point(248, 109);
            lblTituloAgenda.Name = "lblTituloAgenda";
            lblTituloAgenda.Size = new Size(16, 15);
            lblTituloAgenda.TabIndex = 19;
            lblTituloAgenda.Text = "...";
            // 
            // dtpSeleccionFechaCitas
            // 
            dtpSeleccionFechaCitas.Format = DateTimePickerFormat.Short;
            dtpSeleccionFechaCitas.Location = new Point(248, 153);
            dtpSeleccionFechaCitas.Name = "dtpSeleccionFechaCitas";
            dtpSeleccionFechaCitas.Size = new Size(287, 23);
            dtpSeleccionFechaCitas.TabIndex = 20;
            dtpSeleccionFechaCitas.Value = new DateTime(2025, 6, 4, 9, 55, 16, 0);
            // 
            // lblErrorMedico
            // 
            lblErrorMedico.AutoSize = true;
            lblErrorMedico.Location = new Point(248, 188);
            lblErrorMedico.Name = "lblErrorMedico";
            lblErrorMedico.Size = new Size(16, 15);
            lblErrorMedico.TabIndex = 21;
            lblErrorMedico.Text = "...";
            // 
            // DashboardMedicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrorMedico);
            Controls.Add(dtpSeleccionFechaCitas);
            Controls.Add(lblTituloAgenda);
            Controls.Add(lblBienvenidoMedico);
            Controls.Add(dgvCitasMedico);
            Controls.Add(btnCerrarSesionMedico);
            Controls.Add(lblFechaHoraActual);
            Controls.Add(panel1);
            Name = "DashboardMedicoForm";
            Text = "DashboardMedicoForm";
            Load += DashboardMedicoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasMedico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaHoraActual;
        private Label lblBienvenidoMedico;
        private Button btnCerrarSesionMedico;
        private PictureBox pictureBox3;
        private LinkLabel lkAgenda;
        private Label lblRol;
        private Panel panel1;
        private DataGridView dgvCitasMedico;
        private Label lblTituloAgenda;
        private DateTimePicker dtpSeleccionFechaCitas;
        private Label lblErrorMedico;
    }
}