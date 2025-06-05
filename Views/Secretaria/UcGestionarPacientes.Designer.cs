namespace SistemaDeCitasMordagiss.Views.Secretaria
{
    partial class UcGestionarPacientes
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
            dgvPacientes = new DataGridView();
            btnNuevoPaciente = new Button();
            txtBuscarPaciente = new TextBox();
            btnBuscarPaciente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = SystemColors.ControlLightLight;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(279, 166);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(505, 265);
            dgvPacientes.TabIndex = 0;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.BackColor = SystemColors.InactiveCaption;
            btnNuevoPaciente.FlatStyle = FlatStyle.Flat;
            btnNuevoPaciente.Location = new Point(657, 102);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(103, 28);
            btnNuevoPaciente.TabIndex = 1;
            btnNuevoPaciente.Text = "Nuevo Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new Point(279, 102);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(239, 23);
            txtBuscarPaciente.TabIndex = 2;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Location = new Point(524, 102);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(93, 25);
            btnBuscarPaciente.TabIndex = 3;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // UcGestionarPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnBuscarPaciente);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(dgvPacientes);
            Name = "UcGestionarPacientes";
            Size = new Size(797, 477);
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacientes;
        private Button btnNuevoPaciente;
        private TextBox txtBuscarPaciente;
        private Button btnBuscarPaciente;
    }
}
