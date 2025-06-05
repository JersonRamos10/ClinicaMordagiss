namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class EditarUsuarioForm
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            chkActivo = new CheckBox();
            label5 = new Label();
            cmbRol = new ComboBox();
            label4 = new Label();
            txtClaveNueva = new TextBox();
            txtUsuario = new TextBox();
            txtNombre = new TextBox();
            lblUsuario = new Label();
            lblNombre = new Label();
            ep = new ErrorProvider(components);
            lblError = new Label();
            chkCambiarClave = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(252, 469);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 33);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(162, 469);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 33);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(140, 373);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(59, 19);
            chkActivo.TabIndex = 21;
            chkActivo.Text = "Activa";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(15, 374);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 20;
            label5.Text = "Estado de la cuenta";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(123, 323);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(145, 23);
            cmbRol.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 325);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 18;
            label4.Text = "Rol de Usuario: ";
            // 
            // txtClaveNueva
            // 
            txtClaveNueva.Location = new Point(16, 253);
            txtClaveNueva.Name = "txtClaveNueva";
            txtClaveNueva.Size = new Size(289, 23);
            txtClaveNueva.TabIndex = 17;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(16, 163);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(289, 23);
            txtUsuario.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(16, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 23);
            txtNombre.TabIndex = 15;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(16, 131);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(106, 15);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "* Nombre Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(16, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(116, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre Completo: ";
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(16, 414);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 24;
            // 
            // chkCambiarClave
            // 
            chkCambiarClave.AutoSize = true;
            chkCambiarClave.Location = new Point(16, 282);
            chkCambiarClave.Name = "chkCambiarClave";
            chkCambiarClave.Size = new Size(134, 19);
            chkCambiarClave.TabIndex = 25;
            chkCambiarClave.Text = "Cambiar Contraseña";
            chkCambiarClave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 216);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 26;
            label1.Text = "Nueva Contraeña: ";
            // 
            // EditarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 525);
            Controls.Add(label1);
            Controls.Add(chkCambiarClave);
            Controls.Add(lblError);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(chkActivo);
            Controls.Add(label5);
            Controls.Add(cmbRol);
            Controls.Add(label4);
            Controls.Add(txtClaveNueva);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombre);
            Name = "EditarUsuarioForm";
            Text = "EditarUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private CheckBox chkActivo;
        private Label label5;
        private ComboBox cmbRol;
        private Label label4;
        private TextBox txtClaveNueva;
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private Label lblUsuario;
        private Label lblNombre;
        private ErrorProvider ep;
        private Label lblError;
        private Label label1;
        private CheckBox chkCambiarClave;
    }
}