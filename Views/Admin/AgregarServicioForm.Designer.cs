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
            ((System.ComponentModel.ISupportInitialize)epServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(59, 63);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "* Nombre de servicio:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(59, 241);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(63, 15);
            lblCosto.TabIndex = 2;
            lblCosto.Text = "* Costo($):";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(59, 185);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(59, 331);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(93, 15);
            lblDuracion.TabIndex = 4;
            lblDuracion.Text = "Duracion (min): \r\n";
            // 
            // epServicio
            // 
            epServicio.ContainerControl = this;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(92, 473);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 5;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(60, 274);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(120, 23);
            numCosto.TabIndex = 6;
            // 
            // btnCancelarServicio
            // 
            btnCancelarServicio.Location = new Point(173, 538);
            btnCancelarServicio.Name = "btnCancelarServicio";
            btnCancelarServicio.Size = new Size(75, 23);
            btnCancelarServicio.TabIndex = 7;
            btnCancelarServicio.Text = "Cancelar";
            btnCancelarServicio.UseVisualStyleBackColor = true;
            // 
            // btnGuardarServicio
            // 
            btnGuardarServicio.Location = new Point(284, 540);
            btnGuardarServicio.Name = "btnGuardarServicio";
            btnGuardarServicio.Size = new Size(75, 23);
            btnGuardarServicio.TabIndex = 8;
            btnGuardarServicio.Text = "Guardar";
            btnGuardarServicio.UseVisualStyleBackColor = true;
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(64, 147);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(195, 23);
            txtNombreServicio.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(60, 203);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(195, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(59, 374);
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(120, 23);
            numDuracion.TabIndex = 11;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(64, 417);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 12;
            // 
            // AgregarServicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 602);
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
    }
}