namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class EditarMedicoForm
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            chkActivo = new CheckBox();
            lblError = new Label();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtEspecialidad = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            lblEspecialidad = new Label();
            label4 = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            ep = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(147, 507);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 31);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(248, 507);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 31);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(95, 417);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 27;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(41, 462);
            lblError.Name = "lblError";
            lblError.Size = new Size(16, 15);
            lblError.TabIndex = 26;
            lblError.Text = "...";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(36, 173);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(295, 23);
            txtApellidos.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(39, 309);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(297, 23);
            txtTelefono.TabIndex = 24;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(41, 375);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(295, 23);
            txtCorreo.TabIndex = 23;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(39, 246);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(297, 23);
            txtEspecialidad.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 23);
            txtNombre.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(36, 291);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 20;
            label6.Text = "* Telefono:";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecialidad.Location = new Point(33, 228);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(87, 15);
            lblEspecialidad.TabIndex = 19;
            lblEspecialidad.Text = "* Especialidad: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(41, 354);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 18;
            label4.Text = "* Correo:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellidos.Location = new Point(33, 155);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(71, 15);
            lblApellidos.TabIndex = 17;
            lblApellidos.Text = "* Apellidos: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(36, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 15);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "* Nombre";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(157, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(93, 17);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Editar Medico";
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(45, 417);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 30;
            label1.Text = "Estado:";
            // 
            // EditarMedicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 583);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActivo);
            Controls.Add(lblError);
            Controls.Add(txtApellidos);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(lblEspecialidad);
            Controls.Add(label4);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "EditarMedicoForm";
            Text = "EditarMedicoForm";
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private CheckBox chkActivo;
        private Label lblError;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtEspecialidad;
        private TextBox txtNombre;
        private Label label6;
        private Label lblEspecialidad;
        private Label label4;
        private Label lblApellidos;
        private Label lblNombre;
        private Label lblTitulo;
        private ErrorProvider ep;
        private Label label1;
    }
}