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
            lblBienvenida = new Label();
            lblRol = new Label();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(96, 128);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(38, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label1";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(70, 265);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(38, 15);
            lblRol.TabIndex = 1;
            lblRol.Text = "label1";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(161, 324);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(75, 23);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "button1";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // DashboardMedicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblRol);
            Controls.Add(lblBienvenida);
            Name = "DashboardMedicoForm";
            Text = "DashboardMedicoForm";
            Load += DashboardMedicoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblRol;
        private Button btnCerrarSesion;
    }
}