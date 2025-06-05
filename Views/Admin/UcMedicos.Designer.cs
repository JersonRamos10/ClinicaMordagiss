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
            label1 = new Label();
            label3 = new Label();
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
            txtBuscar.Location = new Point(214, 100);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(271, 23);
            txtBuscar.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.InactiveCaption;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(659, 97);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 28);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(491, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.HotTrack;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(581, 371);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 34);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(675, 371);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 34);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvMedicos
            // 
            dgvMedicos.BackgroundColor = SystemColors.ControlLightLight;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Location = new Point(214, 155);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.Size = new Size(560, 207);
            dgvMedicos.TabIndex = 7;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 80);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 8;
            label1.Text = "Buscar Profesional Medico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 128);
            label3.Name = "label3";
            label3.Size = new Size(209, 17);
            label3.TabIndex = 11;
            label3.Text = "Seleccionar una Fila de la Tabla :";
            // 
            // UcMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label3);
            Controls.Add(label1);
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
        private Label label1;
        private Label label3;
    }
}
