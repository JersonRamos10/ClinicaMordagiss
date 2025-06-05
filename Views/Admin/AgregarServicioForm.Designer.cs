namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class AgregarServicioForm
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
            lblCosto = new Label();
            lblDescripcion = new Label();
            lblDuracion = new Label();
            epServicio = new ErrorProvider(components);
            chkActivo = new CheckBox();
            numCosto = new NumericUpDown();
            btnCancelarServicio = new Button();
            btnGuardarServicio = new Button();
            txtNombreServicio = new TextBox();
            txtDescripcion = new TextBox();
            numDuracion = new NumericUpDown();
            lblError = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)epServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(97, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(110, 17);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Servicio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(12, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(127, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "* Nombre de servicio:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCosto.Location = new Point(9, 195);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(64, 15);
            lblCosto.TabIndex = 2;
            lblCosto.Text = "* Costo($):";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(13, 131);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(78, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.Location = new Point(12, 263);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(95, 15);
            lblDuracion.TabIndex = 4;
            lblDuracion.Text = "Duracion (min): \r\n";
            lblDuracion.Click += lblDuracion_Click;
            // 
            // epServicio
            // 
            epServicio.ContainerControl = this;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(67, 323);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 5;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(14, 213);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(169, 23);
            numCosto.TabIndex = 6;
            // 
            // btnCancelarServicio
            // 
            btnCancelarServicio.FlatStyle = FlatStyle.Flat;
            btnCancelarServicio.Location = new Point(103, 397);
            btnCancelarServicio.Name = "btnCancelarServicio";
            btnCancelarServicio.Size = new Size(80, 29);
            btnCancelarServicio.TabIndex = 7;
            btnCancelarServicio.Text = "Cancelar";
            btnCancelarServicio.UseVisualStyleBackColor = true;
            // 
            // btnGuardarServicio
            // 
            btnGuardarServicio.BackColor = SystemColors.HotTrack;
            btnGuardarServicio.FlatStyle = FlatStyle.Flat;
            btnGuardarServicio.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarServicio.Location = new Point(199, 397);
            btnGuardarServicio.Name = "btnGuardarServicio";
            btnGuardarServicio.Size = new Size(74, 29);
            btnGuardarServicio.TabIndex = 8;
            btnGuardarServicio.Text = "Guardar";
            btnGuardarServicio.UseVisualStyleBackColor = false;
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(12, 87);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(237, 23);
            txtNombreServicio.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 151);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(237, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(13, 281);
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(170, 23);
            numDuracion.TabIndex = 11;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(16, 352);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 324);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 13;
            label1.Text = "Estado:";
            // 
            // AgregarServicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(300, 445);
            Controls.Add(label1);
            Controls.Add(lblError);
            Controls.Add(numDuracion);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreServicio);
            Controls.Add(btnGuardarServicio);
            Controls.Add(btnCancelarServicio);
            Controls.Add(numCosto);
            Controls.Add(chkActivo);
            Controls.Add(lblDuracion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCosto);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "AgregarServicioForm";
            Text = "AgregarServicioForm";
            ((System.ComponentModel.ISupportInitialize)epServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblCosto;
        private Label lblDescripcion;
        private Label lblDuracion;
        private ErrorProvider epServicio;
        private Label lblError;
        private NumericUpDown numDuracion;
        private TextBox txtDescripcion;
        private TextBox txtNombreServicio;
        private Button btnGuardarServicio;
        private Button btnCancelarServicio;
        private NumericUpDown numCosto;
        private CheckBox chkActivo;
        private Label label1;
    }
}