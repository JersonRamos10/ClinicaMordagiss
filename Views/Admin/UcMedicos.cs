using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.Models;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Views.Admin; 
namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class UcMedicos : UserControl
    {
  
        private readonly MedicoRepo _repo = new();

        public UcMedicos()
        {
            InitializeComponent();

          
            btnBuscar.Click += (s, e) => Cargar(txtBuscar.Text);
            btnAgregar.Click += (s, e) => AbrirFormularioAgregar();
            btnEditar.Click += (s, e) => AbrirFormularioEditar();
            btnEliminar.Click += (s, e) => EliminarMedico();

           
            dgvMedicos.ReadOnly = true;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.MultiSelect = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Cargar();    
        }


        private void Cargar(string filtro = "")
        {
            var lista = _repo.TraerTodos();

            if (!string.IsNullOrWhiteSpace(filtro))
                lista = lista.Where(m =>
                         m.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                         m.Apellidos.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                         m.Especialidad.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                       .ToList();

            dgvMedicos.DataSource = lista;

            /* Renombrar columnas si existen */
            void H(string col, string txt)
            { if (dgvMedicos.Columns.Contains(col)) dgvMedicos.Columns[col].HeaderText = txt; }

            H("IdProfesionalMedico", "ID");
            H("Nombre", "Nombre");
            H("Apellidos", "Apellidos");
            H("Especialidad", "Especialidad");
            H("TelefonoContacto", "Teléfono");
            H("CorreoElectronico", "Correo");
            H("Activo", "Estado");

            /* Traducir Estado */
            foreach (DataGridViewRow f in dgvMedicos.Rows)
            {
                string? v = f.Cells["Activo"].Value?.ToString()?.ToLower();
                f.Cells["Activo"].Value = v == "si" ? "Activo" : "Inactivo";
            }
        }

        // Devuelve el medico seleccionado o null
        private ProfesionalMedico? MedicoSeleccionado()
            => dgvMedicos.CurrentRow?.DataBoundItem as ProfesionalMedico;

        // Boton Agregar
        private void AbrirFormularioAgregar()
        {
            using var form = new AgregarMedicoForm();   // lo crearemos después
            form.ShowDialog();
            Cargar();
        }

        // Boton Editar
        private void AbrirFormularioEditar()
        {
            ProfesionalMedico? seleccionado = MedicoSeleccionado();
            if (seleccionado is null)
            {
                MessageBox.Show("Seleccione un profesional para editar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            using var form = new EditarMedicoForm(seleccionado);   // lo crearemos después
            form.ShowDialog();
            Cargar();
        }

        // Boton Eliminar
        private void EliminarMedico()
        {
            ProfesionalMedico? seleccionado = MedicoSeleccionado();
            if (seleccionado is null)
            {
                MessageBox.Show("Seleccione un profesional para eliminar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Eliminar DEFINITIVAMENTE a {seleccionado.Nombre} {seleccionado.Apellidos}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes) return;

            bool eliminado = _repo.Borrar(seleccionado.IdProfesionalMedico);

            MessageBox.Show(eliminado ? "Profesional eliminado." : "No se pudo eliminar.",
                            eliminado ? "Éxito" : "Error",
                            MessageBoxButtons.OK,
                            eliminado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            Cargar();
        }
    }
}
