namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class EditarPacienteForm
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelarPaciente = new Button();
            btnGuardarPaciente = new Button();
            txtCorreoElectronico = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNumeroIdentidad = new TextBox();
            cmbGenero = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            label1 = new Label();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            epPacientes = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epPacientes).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 228);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 35;
            label8.Text = "Genero: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 171);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 34;
            label7.Text = "Fecha de Nacimiento: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 498);
            label6.Name = "label6";
            label6.Size = new Size(169, 15);
            label6.TabIndex = 33;
            label6.Text = "Correo Electronico (Opcional)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 427);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 32;
            label5.Text = "Dirección: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 290);
            label4.Name = "label4";
            label4.Size = new Size(212, 15);
            label4.TabIndex = 31;
            label4.Text = "Número de Identidad (DUI) (Opcional):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 359);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 30;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 103);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 29;
            label2.Text = "Apellidos: ";
            // 
            // btnCancelarPaciente
            // 
            btnCancelarPaciente.FlatStyle = FlatStyle.Flat;
            btnCancelarPaciente.Location = new Point(206, 585);
            btnCancelarPaciente.Name = "btnCancelarPaciente";
            btnCancelarPaciente.Size = new Size(90, 32);
            btnCancelarPaciente.TabIndex = 28;
            btnCancelarPaciente.Text = "Cancelar";
            btnCancelarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.BackColor = SystemColors.HotTrack;
            btnGuardarPaciente.FlatStyle = FlatStyle.Flat;
            btnGuardarPaciente.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarPaciente.Location = new Point(326, 585);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(116, 32);
            btnGuardarPaciente.TabIndex = 27;
            btnGuardarPaciente.Text = "Guardar Paciente";
            btnGuardarPaciente.UseVisualStyleBackColor = false;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(21, 516);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(361, 23);
            txtCorreoElectronico.TabIndex = 26;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 445);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(360, 23);
            txtDireccion.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(25, 377);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(360, 23);
            txtTelefono.TabIndex = 24;
            // 
            // txtNumeroIdentidad
            // 
            txtNumeroIdentidad.Location = new Point(26, 311);
            txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            txtNumeroIdentidad.Size = new Size(356, 23);
            txtNumeroIdentidad.TabIndex = 23;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(28, 247);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(268, 23);
            cmbGenero.TabIndex = 22;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(29, 190);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(267, 23);
            dtpFechaNacimiento.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombres: ";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(25, 123);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(357, 23);
            txtApellidos.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(360, 23);
            txtNombre.TabIndex = 18;
            // 
            // epPacientes
            // 
            epPacientes.ContainerControl = this;
            // 
            // EditarPacienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(468, 645);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelarPaciente);
            Controls.Add(btnGuardarPaciente);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNumeroIdentidad);
            Controls.Add(cmbGenero);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label1);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Name = "EditarPacienteForm";
            Text = "EditarPacienteForm";
            ((System.ComponentModel.ISupportInitialize)epPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelarPaciente;
        private Button btnGuardarPaciente;
        private TextBox txtCorreoElectronico;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNumeroIdentidad;
        private ComboBox cmbGenero;
        private DateTimePicker dtpFechaNacimiento;
        private Label label1;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private ErrorProvider epPacientes;
    }
}