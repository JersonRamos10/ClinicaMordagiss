namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class AgendarNuevaCitaForm
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
            btnAgendarCita = new Button();
            btnCancelarCita = new Button();
            label5 = new Label();
            cmbMedico = new ComboBox();
            lblMensajeExito = new Label();
            txtPacienteSeleccionado = new TextBox();
            txtBuscarPaciente = new TextBox();
            lblUsuario = new Label();
            lblClave = new Label();
            lblNombre = new Label();
            lblResultadoBusqueda = new Label();
            lklRegistrarNuevoPaciente = new LinkLabel();
            cmbServicio = new ComboBox();
            label2 = new Label();
            dtpFechaCita = new DateTimePicker();
            label3 = new Label();
            cmbHoraDisponible = new ComboBox();
            panelBoleta = new Panel();
            btnImprimirBoleta = new Button();
            btnDescargarBoleta = new Button();
            lblBoletaTitulo = new Label();
            btnBuscarPaciente = new Button();
            lblSinDisponibilidad = new Label();
            panelBoleta.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Location = new Point(294, 524);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(96, 33);
            btnAgendarCita.TabIndex = 23;
            btnAgendarCita.Text = "Agendar Cita";
            btnAgendarCita.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.Location = new Point(189, 524);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(84, 33);
            btnCancelarCita.TabIndex = 22;
            btnCancelarCita.Text = "Cancelar";
            btnCancelarCita.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 440);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 20;
            label5.Text = "Hora Disponible: \r\n";
            // 
            // cmbMedico
            // 
            cmbMedico.Enabled = false;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(21, 307);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(229, 23);
            cmbMedico.TabIndex = 19;
            // 
            // lblMensajeExito
            // 
            lblMensajeExito.AutoSize = true;
            lblMensajeExito.Location = new Point(3, 38);
            lblMensajeExito.Name = "lblMensajeExito";
            lblMensajeExito.Size = new Size(158, 15);
            lblMensajeExito.TabIndex = 18;
            lblMensajeExito.Text = "Cita Agendada Exitosamente";
            // 
            // txtPacienteSeleccionado
            // 
            txtPacienteSeleccionado.Location = new Point(22, 190);
            txtPacienteSeleccionado.Name = "txtPacienteSeleccionado";
            txtPacienteSeleccionado.ReadOnly = true;
            txtPacienteSeleccionado.Size = new Size(289, 23);
            txtPacienteSeleccionado.TabIndex = 16;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new Point(19, 50);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(266, 23);
            txtBuscarPaciente.TabIndex = 15;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(21, 172);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(131, 15);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Paciente Seleccionado: ";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(21, 226);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(62, 15);
            lblClave.TabIndex = 13;
            lblClave.Text = "* Servicio: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(283, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Buscar Paciente (Nombre, Apellido, Identidad (DUI): \r\n";
            // 
            // lblResultadoBusqueda
            // 
            lblResultadoBusqueda.AutoSize = true;
            lblResultadoBusqueda.Location = new Point(21, 87);
            lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            lblResultadoBusqueda.Size = new Size(125, 15);
            lblResultadoBusqueda.TabIndex = 24;
            lblResultadoBusqueda.Text = "ResultadoDeBusqueda";
            // 
            // lklRegistrarNuevoPaciente
            // 
            lklRegistrarNuevoPaciente.AutoSize = true;
            lklRegistrarNuevoPaciente.Location = new Point(22, 122);
            lklRegistrarNuevoPaciente.Name = "lklRegistrarNuevoPaciente";
            lklRegistrarNuevoPaciente.Size = new Size(281, 15);
            lklRegistrarNuevoPaciente.TabIndex = 25;
            lklRegistrarNuevoPaciente.TabStop = true;
            lklRegistrarNuevoPaciente.Text = "¿Paciente no encontrado ? Registrar Nuevo Paciente\r\n";
            lklRegistrarNuevoPaciente.Visible = false;
            // 
            // cmbServicio
            // 
            cmbServicio.Enabled = false;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(21, 255);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(229, 23);
            cmbServicio.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 289);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 27;
            label2.Text = "Medico: ";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Enabled = false;
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.Location = new Point(19, 379);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(231, 23);
            dtpFechaCita.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 361);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 29;
            label3.Text = "Fecha de la Cita: ";
            // 
            // cmbHoraDisponible
            // 
            cmbHoraDisponible.Enabled = false;
            cmbHoraDisponible.FormattingEnabled = true;
            cmbHoraDisponible.Location = new Point(22, 458);
            cmbHoraDisponible.Name = "cmbHoraDisponible";
            cmbHoraDisponible.Size = new Size(228, 23);
            cmbHoraDisponible.TabIndex = 30;
            // 
            // panelBoleta
            // 
            panelBoleta.Controls.Add(btnImprimirBoleta);
            panelBoleta.Controls.Add(btnDescargarBoleta);
            panelBoleta.Controls.Add(lblBoletaTitulo);
            panelBoleta.Controls.Add(lblMensajeExito);
            panelBoleta.Dock = DockStyle.Bottom;
            panelBoleta.Location = new Point(0, 586);
            panelBoleta.Name = "panelBoleta";
            panelBoleta.Size = new Size(410, 206);
            panelBoleta.TabIndex = 31;
            // 
            // btnImprimirBoleta
            // 
            btnImprimirBoleta.Location = new Point(191, 142);
            btnImprimirBoleta.Name = "btnImprimirBoleta";
            btnImprimirBoleta.Size = new Size(82, 33);
            btnImprimirBoleta.TabIndex = 32;
            btnImprimirBoleta.Text = "Imprimir";
            btnImprimirBoleta.UseVisualStyleBackColor = true;
            // 
            // btnDescargarBoleta
            // 
            btnDescargarBoleta.Location = new Point(294, 142);
            btnDescargarBoleta.Name = "btnDescargarBoleta";
            btnDescargarBoleta.Size = new Size(96, 33);
            btnDescargarBoleta.TabIndex = 32;
            btnDescargarBoleta.Text = "Descargar PDF";
            btnDescargarBoleta.UseVisualStyleBackColor = true;
            // 
            // lblBoletaTitulo
            // 
            lblBoletaTitulo.AutoSize = true;
            lblBoletaTitulo.Location = new Point(3, 77);
            lblBoletaTitulo.Name = "lblBoletaTitulo";
            lblBoletaTitulo.Size = new Size(213, 15);
            lblBoletaTitulo.TabIndex = 19;
            lblBoletaTitulo.Text = "Boleta de cita para [Nombre Paciente]: \r\n";
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Location = new Point(292, 50);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(75, 23);
            btnBuscarPaciente.TabIndex = 32;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // lblSinDisponibilidad
            // 
            lblSinDisponibilidad.AutoSize = true;
            lblSinDisponibilidad.Location = new Point(25, 482);
            lblSinDisponibilidad.Name = "lblSinDisponibilidad";
            lblSinDisponibilidad.Size = new Size(0, 15);
            lblSinDisponibilidad.TabIndex = 33;
            // 
            // AgendarNuevaCitaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 792);
            Controls.Add(lblSinDisponibilidad);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(panelBoleta);
            Controls.Add(cmbHoraDisponible);
            Controls.Add(label3);
            Controls.Add(dtpFechaCita);
            Controls.Add(label2);
            Controls.Add(cmbServicio);
            Controls.Add(lklRegistrarNuevoPaciente);
            Controls.Add(lblResultadoBusqueda);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnCancelarCita);
            Controls.Add(label5);
            Controls.Add(cmbMedico);
            Controls.Add(txtPacienteSeleccionado);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(lblUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblNombre);
            Name = "AgendarNuevaCitaForm";
            Text = "AgendarNuevaCitaForm";
            panelBoleta.ResumeLayout(false);
            panelBoleta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgendarCita;
        private Button btnCancelarCita;
        private Label label5;
        private ComboBox cmbMedico;
        private Label lblMensajeExito;
        private TextBox txtPacienteSeleccionado;
        private TextBox txtBuscarPaciente;
        private Label lblUsuario;
        private Label lblClave;
        private Label lblNombre;
        private Label lblResultadoBusqueda;
        private LinkLabel lklRegistrarNuevoPaciente;
        private ComboBox cmbServicio;
        private Label label2;
        private DateTimePicker dtpFechaCita;
        private Label label3;
        private ComboBox cmbHoraDisponible;
        private Panel panelBoleta;
        private Button btnImprimirBoleta;
        private Button btnDescargarBoleta;
        private Label lblBoletaTitulo;
        private Button btnBuscarPaciente;
        private Label lblSinDisponibilidad;
    }
}