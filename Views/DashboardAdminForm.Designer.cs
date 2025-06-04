namespace SistemaDeCitasMordagiss.Views
{
    partial class DashboardAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdminForm));
            lblBienvenida = new Label();
            lblRol = new Label();
            btnCerrarSesion = new Button();
            pnlMenu = new Panel();
            pictureBox3 = new PictureBox();
            lkServicios = new LinkLabel();
            lkReportes = new LinkLabel();
            lkMedicos = new LinkLabel();
            lkUsuarios = new LinkLabel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(230, 40);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(233, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido[Nombre completo del usuario]";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(51, 125);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(682, 35);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(89, 27);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.Controls.Add(pictureBox3);
            pnlMenu.Controls.Add(lkServicios);
            pnlMenu.Controls.Add(lkReportes);
            pnlMenu.Controls.Add(lkMedicos);
            pnlMenu.Controls.Add(lkUsuarios);
            pnlMenu.Controls.Add(lblRol);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(180, 461);
            pnlMenu.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(52, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // lkServicios
            // 
            lkServicios.AutoSize = true;
            lkServicios.Location = new Point(51, 293);
            lkServicios.Name = "lkServicios";
            lkServicios.Size = new Size(103, 15);
            lkServicios.TabIndex = 10;
            lkServicios.TabStop = true;
            lkServicios.Text = "GestionarServicios";
            // 
            // lkReportes
            // 
            lkReportes.AutoSize = true;
            lkReportes.Location = new Point(51, 359);
            lkReportes.Name = "lkReportes";
            lkReportes.Size = new Size(117, 15);
            lkReportes.TabIndex = 9;
            lkReportes.TabStop = true;
            lkReportes.Text = "Reporte de Actividad";
            // 
            // lkMedicos
            // 
            lkMedicos.AutoSize = true;
            lkMedicos.Location = new Point(20, 232);
            lkMedicos.Name = "lkMedicos";
            lkMedicos.Size = new Size(148, 15);
            lkMedicos.TabIndex = 8;
            lkMedicos.TabStop = true;
            lkMedicos.Text = "Gestionar Personal Medico";
            // 
            // lkUsuarios
            // 
            lkUsuarios.AutoSize = true;
            lkUsuarios.Cursor = Cursors.Hand;
            lkUsuarios.Location = new Point(51, 162);
            lkUsuarios.Name = "lkUsuarios";
            lkUsuarios.Size = new Size(105, 15);
            lkUsuarios.TabIndex = 8;
            lkUsuarios.TabStop = true;
            lkUsuarios.Text = "Gestionar Usuarios";
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(793, 461);
            pnlContenido.TabIndex = 10;
            // 
            // DashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 461);
            Controls.Add(pnlMenu);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblBienvenida);
            Controls.Add(pnlContenido);
            Name = "DashboardAdminForm";
            Text = "DashboardAdminForm";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblRol;
        private Button btnCerrarSesion;
        private Panel pnlMenu;
        private PictureBox pictureBox3;
        private LinkLabel lkUsuarios;
        private LinkLabel lkServicios;
        private LinkLabel lkReportes;
        private LinkLabel lkMedicos;
        private Panel pnlContenido;
    }
}