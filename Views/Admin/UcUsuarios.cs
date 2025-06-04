using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;

namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class UcUsuarios: UserControl
    {
        private readonly UsuarioRepo _repo = new(); 
        public UcUsuarios()
        {
            InitializeComponent();

            btnBuscar.Click += (s, e) => Cargar(txtBuscar.Text);
            btnAgregar.Click += (s, e) => { new AgregarNuevoUsuarioForm().ShowDialog(); Cargar(); };
            btnEditar.Click += (s, e) => Editar();
            btnEliminar.Click += (s, e) => Eliminar();

            this.Dock = DockStyle.Fill;

            Cargar();
        }
        private void Cargar(string filtro = "")
        {
            var lista = _repo.TraerTodos();
            if (!string.IsNullOrWhiteSpace(filtro))
                lista = lista.Where(u =>
                          u.NombreCompleto.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                          u.NombreUsuario.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                        .ToList();

            dgvUsuarios.DataSource = lista;

            //para no mostrar la contraseña solo los datos necesarios a conocer
            dgvUsuarios.Columns["Contrasena"].Visible= false;

            //los encabezados de la dataGrid
            dgvUsuarios.Columns["IdUsuarioSistema"].HeaderText = "ID";
            dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre";
            dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";
            dgvUsuarios.Columns["Rol"].HeaderText = "Rol";
            dgvUsuarios.Columns["Activo"].HeaderText = "Estado";

            
            // Muestra “Activo / Inactivo” en vez de “Si / No”
            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
            {
                string? valorEstado = fila.Cells["Activo"].Value?.ToString()?.ToLower();
                fila.Cells["Activo"].Value = valorEstado == "si" ? "Activo" : "Inactivo";
            }



        }

        private UsuarioSistema? Seleccionado()
            => dgvUsuarios.CurrentRow?.DataBoundItem as UsuarioSistema;

        private void Editar()
        {
            UsuarioSistema? usuarioSeleccionado =
        dgvUsuarios.CurrentRow?.DataBoundItem as UsuarioSistema;

            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario para editar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var formularioEdicion = new EditarUsuarioForm(usuarioSeleccionado);
            formularioEdicion.ShowDialog();

            Cargar();   // refresca la grilla con los cambios
        }

        private void Eliminar()
        {
            UsuarioSistema? usuarioSeleccionado =
                dgvUsuarios.CurrentRow?.DataBoundItem as UsuarioSistema;

            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario antes de eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Esta seguro de que desea eliminar al usuario {usuarioSeleccionado.NombreCompleto}?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            bool eliminadoCorrectamente =
                _repo.Borrar(usuarioSeleccionado.IdUsuarioSistema);

            MessageBox.Show(
                eliminadoCorrectamente
                    ? "Usuario eliminado satisfactoriamente."
                    : "No se pudo eliminar el usuario.",
                eliminadoCorrectamente ? "Exito" : "Error",
                MessageBoxButtons.OK,
                eliminadoCorrectamente
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Error);

            Cargar();   //refresca la tabla (grilla)
        }

    }
}
