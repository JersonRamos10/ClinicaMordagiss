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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epServicio).BeginInit();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(17, 403);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 25;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(12, 331);
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(120, 23);
            numDuracion.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(13, 190);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(195, 23);
            txtDescripcion.TabIndex = 23;
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(17, 121);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(195, 23);
            txtNombreServicio.TabIndex = 22;
            // 
            // btnGuardarServicio
            // 
            btnGuardarServicio.BackColor = SystemColors.HotTrack;
            btnGuardarServicio.FlatStyle = FlatStyle.Flat;
            btnGuardarServicio.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarServicio.Location = new Point(176, 434);
            btnGuardarServicio.Name = "btnGuardarServicio";
            btnGuardarServicio.Size = new Size(84, 32);
            btnGuardarServicio.TabIndex = 21;
            btnGuardarServicio.Text = "Guardar";
            btnGuardarServicio.UseVisualStyleBackColor = false;
            // 
            // btnCancelarServicio
            // 
            btnCancelarServicio.FlatStyle = FlatStyle.Flat;
            btnCancelarServicio.Location = new Point(89, 434);
            btnCancelarServicio.Name = "btnCancelarServicio";
            btnCancelarServicio.Size = new Size(81, 32);
            btnCancelarServicio.TabIndex = 20;
            btnCancelarServicio.Text = "Cancelar";
            btnCancelarServicio.UseVisualStyleBackColor = true;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(13, 261);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(120, 23);
            numCosto.TabIndex = 19;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(66, 372);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 18;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuracion.Location = new Point(11, 313);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(95, 15);
            lblDuracion.TabIndex = 17;
            lblDuracion.Text = "Duracion (min): \r\n";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(12, 172);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(78, 15);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCosto.Location = new Point(11, 243);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(64, 15);
            lblCosto.TabIndex = 15;
            lblCosto.Text = "* Costo($):";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(12, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(127, 15);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "* Nombre de servicio:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(89, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(97, 17);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Editar Servicio";
            // 
            // epServicio
            // 
            epServicio.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 373);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 26;
            label1.Text = "Estado: ";
            // 
            // EditarServicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 494);
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
        private Label label1;
    }
}