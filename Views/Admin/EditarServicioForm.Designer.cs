namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class EditarServicioForm
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
            lblError = new Label();
            numDuracion = new NumericUpDown();
            txtDescripcion = new TextBox();
            txtNombreServicio = new TextBox();
            btnGuardarServicio = new Button();
            btnCancelarServicio = new Button();
            numCosto = new NumericUpDown();
            chkActivo = new CheckBox();
            lblDuracion = new Label();
            lblDescripcion = new Label();
            lblCosto = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            epServicio = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epServicio).BeginInit();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(54, 402);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 25;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(49, 359);
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(120, 23);
            numDuracion.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(50, 188);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(195, 23);
            txtDescripcion.TabIndex = 23;
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(54, 132);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(195, 23);
            txtNombreServicio.TabIndex = 22;
            // 
            // btnGuardarServicio
            // 
            btnGuardarServicio.Location = new Point(274, 525);
            btnGuardarServicio.Name = "btnGuardarServicio";
            btnGuardarServicio.Size = new Size(75, 23);
            btnGuardarServicio.TabIndex = 21;
            btnGuardarServicio.Text = "Guardar";
            btnGuardarServicio.UseVisualStyleBackColor = true;
            // 
            // btnCancelarServicio
            // 
            btnCancelarServicio.Location = new Point(163, 523);
            btnCancelarServicio.Name = "btnCancelarServicio";
            btnCancelarServicio.Size = new Size(75, 23);
            btnCancelarServicio.TabIndex = 20;
            btnCancelarServicio.Text = "Cancelar";
            btnCancelarServicio.UseVisualStyleBackColor = true;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(50, 259);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(120, 23);
            numCosto.TabIndex = 19;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(82, 458);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 18;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(49, 316);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(93, 15);
            lblDuracion.TabIndex = 17;
            lblDuracion.Text = "Duracion (min): \r\n";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(49, 170);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(49, 226);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(63, 15);
            lblCosto.TabIndex = 15;
            lblCosto.Text = "* Costo($):";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 113);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 15);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "* Nombre de servicio:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(49, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "label1";
            // 
            // epServicio
            // 
            epServicio.ContainerControl = this;
            // 
            // EditarServicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 597);
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
            Name = "EditarServicioForm";
            Text = "EditarServicioFomr";
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)epServicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblError;
        private NumericUpDown numDuracion;
        private TextBox txtDescripcion;
        private TextBox txtNombreServicio;
        private Button btnGuardarServicio;
        private Button btnCancelarServicio;
        private NumericUpDown numCosto;
        private CheckBox chkActivo;
        private Label lblDuracion;
        private Label lblDescripcion;
        private Label lblCosto;
        private Label lblNombre;
        private Label lblTitulo;
        private ErrorProvider epServicio;
    }
}