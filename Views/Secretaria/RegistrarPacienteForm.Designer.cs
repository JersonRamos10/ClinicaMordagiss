namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class RegistrarPacienteForm
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
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            label1 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cmbGenero = new ComboBox();
            txtNumeroIdentidad = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCorreoElectronico = new TextBox();
            btnGuardarPaciente = new Button();
            btnCancelarPaciente = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            epPacientes = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epPacientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(360, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(30, 125);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(357, 23);
            txtApellidos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombres: ";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(34, 192);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(267, 23);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(33, 249);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(268, 23);
            cmbGenero.TabIndex = 4;
            // 
            // txtNumeroIdentidad
            // 
            txtNumeroIdentidad.Location = new Point(31, 313);
            txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            txtNumeroIdentidad.Size = new Size(356, 23);
            txtNumeroIdentidad.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(30, 379);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(360, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(27, 447);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(360, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(26, 518);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(361, 23);
            txtCorreoElectronico.TabIndex = 8;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.BackColor = SystemColors.HotTrack;
            btnGuardarPaciente.FlatStyle = FlatStyle.Flat;
            btnGuardarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnGuardarPaciente.Location = new Point(315, 587);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(116, 32);
            btnGuardarPaciente.TabIndex = 9;
            btnGuardarPaciente.Text = "Guardar Paciente";
            btnGuardarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPaciente
            // 
            btnCancelarPaciente.FlatStyle = FlatStyle.Flat;
            btnCancelarPaciente.Location = new Point(198, 587);
            btnCancelarPaciente.Name = "btnCancelarPaciente";
            btnCancelarPaciente.Size = new Size(90, 32);
            btnCancelarPaciente.TabIndex = 10;
            btnCancelarPaciente.Text = "Cancelar";
            btnCancelarPaciente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(29, 105);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 11;
            label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(28, 361);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(29, 292);
            label4.Name = "label4";
            label4.Size = new Size(221, 15);
            label4.TabIndex = 13;
            label4.Text = "Número de Identidad (DUI) (Opcional):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(27, 429);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 14;
            label5.Text = "Dirección: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(26, 500);
            label6.Name = "label6";
            label6.Size = new Size(172, 15);
            label6.TabIndex = 15;
            label6.Text = "Correo Electronico (Opcional):\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(34, 173);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 16;
            label7.Text = "Fecha de Nacimiento: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(31, 230);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 17;
            label8.Text = "Genero: ";
            // 
            // epPacientes
            // 
            epPacientes.ContainerControl = this;
            // 
            // RegistrarPacienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(452, 660);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "RegistrarPacienteForm";
            Text = "RegistrarPacienteForm";
            ((System.ComponentModel.ISupportInitialize)epPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellidos;
        private Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbGenero;
        private TextBox txtNumeroIdentidad;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreoElectronico;
        private Button btnGuardarPaciente;
        private Button btnCancelarPaciente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ErrorProvider epPacientes;
    }
}