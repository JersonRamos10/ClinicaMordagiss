namespace SistemaDeCitasMordagiss.Views
{
    partial class DashboardSecretariaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardSecretariaForm));
            lblBienvenidaSecretaria = new Label();
            lblRolSecretaria = new Label();
            panel1 = new Panel();
            lklReporteCitas = new LinkLabel();
            lklConfirmarCitas = new LinkLabel();
            lklGestionarHorarios = new LinkLabel();
            lklGestionarPacientes = new LinkLabel();
            lklConsultarAgenda = new LinkLabel();
            lklAgendarCita = new LinkLabel();
            pictureBox1 = new PictureBox();
            btnCerrarSesionSecretaria = new Button();
            lblFechaHoraSecretaria = new Label();
            panelContenedorSecretaria = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedorSecretaria.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenidaSecretaria
            // 
            lblBienvenidaSecretaria.AutoSize = true;
            lblBienvenidaSecretaria.Location = new Point(270, 31);
            lblBienvenidaSecretaria.Name = "lblBienvenidaSecretaria";
            lblBienvenidaSecretaria.Size = new Size(0, 15);
            lblBienvenidaSecretaria.TabIndex = 0;
            // 
            // lblRolSecretaria
            // 
            lblRolSecretaria.AutoSize = true;
            lblRolSecretaria.Location = new Point(58, 149);
            lblRolSecretaria.Name = "lblRolSecretaria";
            lblRolSecretaria.Size = new Size(0, 15);
            lblRolSecretaria.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(lklReporteCitas);
            panel1.Controls.Add(lklConfirmarCitas);
            panel1.Controls.Add(lklGestionarHorarios);
            panel1.Controls.Add(lklGestionarPacientes);
            panel1.Controls.Add(lklConsultarAgenda);
            panel1.Controls.Add(lklAgendarCita);
            panel1.Controls.Add(lblRolSecretaria);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 630);
            panel1.TabIndex = 2;
            // 
            // lklReporteCitas
            // 
            lklReporteCitas.AutoSize = true;
            lklReporteCitas.ForeColor = SystemColors.ActiveCaptionText;
            lklReporteCitas.LinkColor = Color.DimGray;
            lklReporteCitas.Location = new Point(46, 456);
            lklReporteCitas.Name = "lklReporteCitas";
            lklReporteCitas.Size = new Size(140, 15);
            lklReporteCitas.TabIndex = 6;
            lklReporteCitas.TabStop = true;
            lklReporteCitas.Text = " Generar Reporte de Citas";
            // 
            // lklConfirmarCitas
            // 
            lklConfirmarCitas.AutoSize = true;
            lklConfirmarCitas.ForeColor = SystemColors.ActiveCaptionText;
            lklConfirmarCitas.LinkColor = Color.DimGray;
            lklConfirmarCitas.Location = new Point(47, 406);
            lklConfirmarCitas.Name = "lklConfirmarCitas";
            lklConfirmarCitas.Size = new Size(151, 15);
            lklConfirmarCitas.TabIndex = 5;
            lklConfirmarCitas.TabStop = true;
            lklConfirmarCitas.Text = "Confirmar Citas Pendientes";
            // 
            // lklGestionarHorarios
            // 
            lklGestionarHorarios.AutoSize = true;
            lklGestionarHorarios.ForeColor = SystemColors.ActiveCaptionText;
            lklGestionarHorarios.LinkColor = Color.DimGray;
            lklGestionarHorarios.Location = new Point(48, 355);
            lklGestionarHorarios.Name = "lklGestionarHorarios";
            lklGestionarHorarios.Size = new Size(153, 15);
            lklGestionarHorarios.TabIndex = 4;
            lklGestionarHorarios.TabStop = true;
            lklGestionarHorarios.Text = "Gestionar Horarios Medicos";
            // 
            // lklGestionarPacientes
            // 
            lklGestionarPacientes.AutoSize = true;
            lklGestionarPacientes.ForeColor = SystemColors.ActiveCaptionText;
            lklGestionarPacientes.LinkColor = Color.DimGray;
            lklGestionarPacientes.Location = new Point(49, 307);
            lklGestionarPacientes.Name = "lklGestionarPacientes";
            lklGestionarPacientes.Size = new Size(110, 15);
            lklGestionarPacientes.TabIndex = 3;
            lklGestionarPacientes.TabStop = true;
            lklGestionarPacientes.Text = "Gestionar Pacientes";
            // 
            // lklConsultarAgenda
            // 
            lklConsultarAgenda.AutoSize = true;
            lklConsultarAgenda.ForeColor = SystemColors.ActiveCaptionText;
            lklConsultarAgenda.LinkColor = Color.DimGray;
            lklConsultarAgenda.Location = new Point(49, 255);
            lklConsultarAgenda.Name = "lklConsultarAgenda";
            lklConsultarAgenda.Size = new Size(145, 15);
            lklConsultarAgenda.TabIndex = 2;
            lklConsultarAgenda.TabStop = true;
            lklConsultarAgenda.Text = "Consultar Agenda General";
            // 
            // lklAgendarCita
            // 
            lklAgendarCita.AutoSize = true;
            lklAgendarCita.ForeColor = SystemColors.ActiveCaptionText;
            lklAgendarCita.LinkColor = Color.DimGray;
            lklAgendarCita.Location = new Point(49, 201);
            lklAgendarCita.Name = "lklAgendarCita";
            lklAgendarCita.Size = new Size(113, 15);
            lklAgendarCita.TabIndex = 1;
            lklAgendarCita.TabStop = true;
            lklAgendarCita.Text = "Agendar Nueva Cita";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarSesionSecretaria
            // 
            btnCerrarSesionSecretaria.BackColor = SystemColors.MenuHighlight;
            btnCerrarSesionSecretaria.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesionSecretaria.Location = new Point(744, 23);
            btnCerrarSesionSecretaria.Name = "btnCerrarSesionSecretaria";
            btnCerrarSesionSecretaria.Size = new Size(99, 31);
            btnCerrarSesionSecretaria.TabIndex = 3;
            btnCerrarSesionSecretaria.Text = "Cerrar Sesion";
            btnCerrarSesionSecretaria.UseVisualStyleBackColor = false;
            // 
            // lblFechaHoraSecretaria
            // 
            lblFechaHoraSecretaria.AutoSize = true;
            lblFechaHoraSecretaria.Location = new Point(270, 61);
            lblFechaHoraSecretaria.Name = "lblFechaHoraSecretaria";
            lblFechaHoraSecretaria.Size = new Size(0, 15);
            lblFechaHoraSecretaria.TabIndex = 4;
            // 
            // panelContenedorSecretaria
            // 
            panelContenedorSecretaria.BackColor = SystemColors.ControlLightLight;
            panelContenedorSecretaria.Controls.Add(btnCerrarSesionSecretaria);
            panelContenedorSecretaria.Dock = DockStyle.Fill;
            panelContenedorSecretaria.Location = new Point(0, 0);
            panelContenedorSecretaria.Name = "panelContenedorSecretaria";
            panelContenedorSecretaria.Size = new Size(855, 630);
            panelContenedorSecretaria.TabIndex = 8;
            panelContenedorSecretaria.Paint += panelContenedorSecretaria_Paint;
            // 
            // DashboardSecretariaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 630);
            Controls.Add(lblFechaHoraSecretaria);
            Controls.Add(panel1);
            Controls.Add(lblBienvenidaSecretaria);
            Controls.Add(panelContenedorSecretaria);
            Name = "DashboardSecretariaForm";
            Text = "DashboardSecretariaForm";
            Load += DashboardSecretariaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedorSecretaria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidaSecretaria;
        private Label lblRolSecretaria;
        private Panel panel1;
        private LinkLabel lklAgendarCita;
        private PictureBox pictureBox1;
        private Button btnCerrarSesionSecretaria;
        private Label lblFechaHoraSecretaria;
        private LinkLabel lklGestionarPacientes;
        private LinkLabel lklConsultarAgenda;
        private LinkLabel lklReporteCitas;
        private LinkLabel lklConfirmarCitas;
        private LinkLabel lklGestionarHorarios;
        private Panel panelContenedorSecretaria;
    }
}