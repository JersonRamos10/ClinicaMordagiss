namespace SistemaDeCitasMordagiss.Views.Admin
{
    partial class UcUsuarios
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
            dgvUsuarios = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = SystemColors.ControlLightLight;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(244, 170);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(521, 192);
            dgvUsuarios.TabIndex = 11;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.HotTrack;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(537, 374);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(91, 34);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(641, 374);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.InactiveCaption;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(630, 115);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 27);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLightLight;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(511, 118);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(244, 118);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(261, 23);
            txtBuscar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 99);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 12;
            label1.Text = "Buscar Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 146);
            label3.Name = "label3";
            label3.Size = new Size(209, 17);
            label3.TabIndex = 13;
            label3.Text = "Seleccionar una Fila de la Tabla :";
            // 
            // UcUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Name = "UcUsuarios";
            Size = new Size(770, 494);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label1;
        private Label label3;
    }
}
