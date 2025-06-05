namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class AgregarMedicoForm
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
            lblTitulo = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            label4 = new Label();
            lblEspecialidad = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtEspecialidad = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            lblError = new Label();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ep = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(67, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 17);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro De Profesional Medico:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(15, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "* Nombre";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellidos.Location = new Point(12, 165);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(71, 15);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "* Apellidos: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(20, 364);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "* Correo:";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecialidad.Location = new Point(12, 238);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(87, 15);
            lblEspecialidad.TabIndex = 4;
            lblEspecialidad.Text = "* Especialidad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(15, 301);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "* Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(18, 256);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(297, 23);
            txtEspecialidad.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(20, 385);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(295, 23);
            txtCorreo.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(18, 319);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(297, 23);
            txtTelefono.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(15, 183);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(295, 23);
            txtApellidos.TabIndex = 10;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = SystemColors.MenuHighlight;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.Location = new Point(24, 447);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 11;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(70, 418);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(62, 19);
            chkActivo.TabIndex = 12;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(243, 499);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 31);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(152, 499);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 31);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(18, 418);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 15;
            label1.Text = "Estado: ";
            // 
            // AgregarMedicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 555);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "AgregarMedicoForm";
            Text = "AgregarMedicoForm";
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellidos;
        private Label label4;
        private Label lblEspecialidad;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEspecialidad;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private Label lblError;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider ep;
        private Label label1;
    }
}