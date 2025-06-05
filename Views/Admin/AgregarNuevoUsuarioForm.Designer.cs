namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class AgregarNuevoUsuarioForm
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
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            lblClave = new Label();
            lblUsuario = new Label();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label4 = new Label();
            cmbRol = new ComboBox();
            label5 = new Label();
            chkActivo = new CheckBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblError = new Label();
            ep = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(12, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(116, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo: ";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClave.Location = new Point(12, 203);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(83, 15);
            lblClave.TabIndex = 1;
            lblClave.Text = "* Contraseña: ";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(12, 118);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(106, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "* Nombre Usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 150);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(289, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 240);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(289, 23);
            txtClave.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 315);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 6;
            label4.Text = "Rol de Usuario: ";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(120, 313);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(145, 23);
            cmbRol.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 388);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado de la cuenta:\r\n";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(136, 387);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(59, 19);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activa";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(136, 434);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 33);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(239, 434);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 33);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Añadir";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(12, 281);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 12;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // AgregarNuevoUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 492);
            Controls.Add(lblError);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(chkActivo);
            Controls.Add(label5);
            Controls.Add(cmbRol);
            Controls.Add(label4);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(lblUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblNombre);
            Name = "AgregarNuevoUsuarioForm";
            Text = "AgregarNuevoUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblClave;
        private Label lblUsuario;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label4;
        private ComboBox cmbRol;
        private Label label5;
        private CheckBox chkActivo;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblError;
        private ErrorProvider ep;
    }
}