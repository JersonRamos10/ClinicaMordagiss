namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class UcMedicos
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
            panel1 = new Panel();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvMedicos = new DataGridView();
            ep = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 445);
            panel1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(310, 82);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(271, 23);
            txtBuscar.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(681, 81);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(600, 81);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(584, 378);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(681, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvMedicos
            // 
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Location = new Point(214, 129);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.Size = new Size(560, 221);
            dgvMedicos.TabIndex = 7;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // UcMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvMedicos);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(panel1);
            Name = "UcMedicos";
            Size = new Size(784, 494);
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvMedicos;
        private ErrorProvider ep;
    }
}
