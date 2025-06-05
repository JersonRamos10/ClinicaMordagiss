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
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epServicios).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarServicio
            // 
            txtBuscarServicio.Location = new Point(225, 130);
            txtBuscarServicio.Name = "txtBuscarServicio";
            txtBuscarServicio.Size = new Size(298, 23);
            txtBuscarServicio.TabIndex = 1;
            // 
            // btnBuscarServicio
            // 
            btnBuscarServicio.BackColor = SystemColors.HighlightText;
            btnBuscarServicio.FlatStyle = FlatStyle.Flat;
            btnBuscarServicio.Location = new Point(528, 130);
            btnBuscarServicio.Name = "btnBuscarServicio";
            btnBuscarServicio.Size = new Size(75, 23);
            btnBuscarServicio.TabIndex = 2;
            btnBuscarServicio.Text = "Buscar";
            btnBuscarServicio.UseVisualStyleBackColor = false;
            // 
            // dgvServicios
            // 
            dgvServicios.BackgroundColor = SystemColors.ControlLightLight;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(225, 181);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(522, 219);
            dgvServicios.TabIndex = 3;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.BackColor = SystemColors.InactiveCaption;
            btnAgregarServicio.FlatStyle = FlatStyle.Flat;
            btnAgregarServicio.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarServicio.Location = new Point(629, 129);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(97, 26);
            btnAgregarServicio.TabIndex = 4;
            btnAgregarServicio.Text = "Agregar Servicio";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // btnEditarServicio
            // 
            btnEditarServicio.BackColor = SystemColors.HotTrack;
            btnEditarServicio.FlatStyle = FlatStyle.Flat;
            btnEditarServicio.ForeColor = SystemColors.ButtonHighlight;
            btnEditarServicio.Location = new Point(591, 406);
            btnEditarServicio.Name = "btnEditarServicio";
            btnEditarServicio.Size = new Size(66, 33);
            btnEditarServicio.TabIndex = 5;
            btnEditarServicio.Text = "Editar";
            btnEditarServicio.UseVisualStyleBackColor = false;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.BackColor = Color.Crimson;
            btnEliminarServicio.FlatStyle = FlatStyle.Flat;
            btnEliminarServicio.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarServicio.Location = new Point(663, 406);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(84, 33);
            btnEliminarServicio.TabIndex = 6;
            btnEliminarServicio.Text = "Eliminar";
            btnEliminarServicio.UseVisualStyleBackColor = false;
            // 
            // epServicios
            // 
            epServicios.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 106);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 7;
            label1.Text = "Buscar Servicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 157);
            label3.Name = "label3";
            label3.Size = new Size(209, 17);
            label3.TabIndex = 12;
            label3.Text = "Seleccionar una Fila de la Tabla :";
            // 
            // UcServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label3);
            Controls.Add(label1);
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
        private Label label1;
        private Label label3;
    }
}
