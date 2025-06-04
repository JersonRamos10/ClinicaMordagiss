namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class UcServicios
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
            components = new System.ComponentModel.Container();
            txtBuscarServicio = new TextBox();
            btnBuscarServicio = new Button();
            dgvServicios = new DataGridView();
            btnAgregarServicio = new Button();
            btnEditarServicio = new Button();
            btnEliminarServicio = new Button();
            epServicios = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epServicios).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarServicio
            // 
            txtBuscarServicio.Location = new Point(231, 117);
            txtBuscarServicio.Name = "txtBuscarServicio";
            txtBuscarServicio.Size = new Size(184, 23);
            txtBuscarServicio.TabIndex = 1;
            // 
            // btnBuscarServicio
            // 
            btnBuscarServicio.Location = new Point(412, 117);
            btnBuscarServicio.Name = "btnBuscarServicio";
            btnBuscarServicio.Size = new Size(75, 23);
            btnBuscarServicio.TabIndex = 2;
            btnBuscarServicio.Text = "Buscar";
            btnBuscarServicio.UseVisualStyleBackColor = true;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(231, 162);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(522, 219);
            dgvServicios.TabIndex = 3;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Location = new Point(568, 117);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(75, 23);
            btnAgregarServicio.TabIndex = 4;
            btnAgregarServicio.Text = "button2";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // btnEditarServicio
            // 
            btnEditarServicio.Location = new Point(487, 438);
            btnEditarServicio.Name = "btnEditarServicio";
            btnEditarServicio.Size = new Size(75, 23);
            btnEditarServicio.TabIndex = 5;
            btnEditarServicio.Text = "Editar";
            btnEditarServicio.UseVisualStyleBackColor = true;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.Location = new Point(568, 438);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(75, 23);
            btnEliminarServicio.TabIndex = 6;
            btnEliminarServicio.Text = "Eliminar";
            btnEliminarServicio.UseVisualStyleBackColor = true;
            // 
            // epServicios
            // 
            epServicios.ContainerControl = this;
            // 
            // UcServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEliminarServicio);
            Controls.Add(btnEditarServicio);
            Controls.Add(btnAgregarServicio);
            Controls.Add(dgvServicios);
            Controls.Add(btnBuscarServicio);
            Controls.Add(txtBuscarServicio);
            Name = "UcServicios";
            Size = new Size(770, 494);
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)epServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarServicio;
        private Button btnBuscarServicio;
        private DataGridView dgvServicios;
        private Button btnAgregarServicio;
        private Button btnEditarServicio;
        private Button btnEliminarServicio;
        private ErrorProvider epServicios;
    }
}
