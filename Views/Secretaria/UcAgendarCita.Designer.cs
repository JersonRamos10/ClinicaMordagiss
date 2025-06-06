namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class UcAgendarCita
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblBuscarPaciente = new Label();
            txtFiltroPacientes = new TextBox();
            btnBuscarPaciente = new Button();
            dgvPacientes = new DataGridView();
            lblPacienteSeleccionado = new Label();
            btnAbrirAgendarForm = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // lblBuscarPaciente
            // 
            lblBuscarPaciente.AutoSize = true;
            lblBuscarPaciente.Location = new Point(303, 102);
            lblBuscarPaciente.Name = "lblBuscarPaciente";
            lblBuscarPaciente.Size = new Size(277, 30);
            lblBuscarPaciente.TabIndex = 0;
            lblBuscarPaciente.Text = "Buscar Paciente (Nombre, Apellido, Identidad (DUI)\r\n\r\n";
            // 
            // txtFiltroPacientes
            // 
            txtFiltroPacientes.Location = new Point(303, 135);
            txtFiltroPacientes.Name = "txtFiltroPacientes";
            txtFiltroPacientes.Size = new Size(220, 23);
            txtFiltroPacientes.TabIndex = 1;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Location = new Point(529, 135);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(75, 23);
            btnBuscarPaciente.TabIndex = 2;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = SystemColors.ControlLightLight;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(303, 194);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.Size = new Size(432, 200);
            dgvPacientes.TabIndex = 3;
            // 
            // lblPacienteSeleccionado
            // 
            lblPacienteSeleccionado.AutoSize = true;
            lblPacienteSeleccionado.BackColor = SystemColors.Control;
            lblPacienteSeleccionado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPacienteSeleccionado.ForeColor = Color.DodgerBlue;
            lblPacienteSeleccionado.Location = new Point(303, 419);
            lblPacienteSeleccionado.Name = "lblPacienteSeleccionado";
            lblPacienteSeleccionado.Size = new Size(271, 17);
            lblPacienteSeleccionado.TabIndex = 4;
            lblPacienteSeleccionado.Text = "Paciente seleccionado: [NombreCompleto]";
            // 
            // btnAbrirAgendarForm
            // 
            btnAbrirAgendarForm.BackColor = SystemColors.MenuHighlight;
            btnAbrirAgendarForm.Cursor = Cursors.Hand;
            btnAbrirAgendarForm.Enabled = false;
            btnAbrirAgendarForm.FlatStyle = FlatStyle.Flat;
            btnAbrirAgendarForm.ForeColor = SystemColors.ButtonHighlight;
            btnAbrirAgendarForm.Location = new Point(652, 461);
            btnAbrirAgendarForm.Name = "btnAbrirAgendarForm";
            btnAbrirAgendarForm.Size = new Size(101, 29);
            btnAbrirAgendarForm.TabIndex = 5;
            btnAbrirAgendarForm.Text = "Agendar Cita";
            btnAbrirAgendarForm.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 172);
            label3.Name = "label3";
            label3.Size = new Size(209, 17);
            label3.TabIndex = 12;
            label3.Text = "Seleccionar una Fila de la Tabla :";
            // 
            // UcAgendarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label3);
            Controls.Add(btnAbrirAgendarForm);
            Controls.Add(lblPacienteSeleccionado);
            Controls.Add(dgvPacientes);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(txtFiltroPacientes);
            Controls.Add(lblBuscarPaciente);
            Name = "UcAgendarCita";
            Size = new Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscarPaciente;
        private TextBox txtFiltroPacientes;
        private Button btnBuscarPaciente;
        private DataGridView dgvPacientes;
        private Label lblPacienteSeleccionado;
        private Button btnAbrirAgendarForm;
        private Label label3;
    }
}
