using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.Models;
using SistemaDeCitasMordagiss.DataAccess;

namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class EditarUsuarioForm : Form
    {
        private readonly UsuarioRepo _repo = new();
        private UsuarioSistema? _usuarioOriginal;          
        private readonly Color _colorNormal;

        public EditarUsuarioForm()
        {
            InitializeComponent();

            _colorNormal = lblError.ForeColor;

        //valores del combobox
            cmbRol.Items.AddRange(
                new[] { "Administrador", "Secretaria", "ProfesionalMedico" });
            cmbRol.SelectedIndex = 0;

            btnGuardar.Click += GuardarCambios;
            btnCancelar.Click += (s, e) => Close();
        }

       
        public EditarUsuarioForm(UsuarioSistema usuarioAEditar) : this()
        {
            _usuarioOriginal = usuarioAEditar;

            // cargar datos en controles
            txtNombre.Text = usuarioAEditar.NombreCompleto;
            txtUsuario.Text = usuarioAEditar.NombreUsuario;
            cmbRol.SelectedItem = usuarioAEditar.Rol;
            chkActivo.Checked = usuarioAEditar.Activo.Equals("Si",
                                           StringComparison.OrdinalIgnoreCase);


            //logica de una nueva contraseña
            chkCambiarClave.CheckedChanged += (s, e) =>
            {
                txtClaveNueva.Enabled = chkCambiarClave.Checked;
                if (!chkCambiarClave.Checked)
                {
                    txtClaveNueva.Text = string.Empty;
                    ep.SetError(txtClaveNueva, "");
                }
            };
        }

       
        private void GuardarCambios(object? sender, EventArgs e)
        {
            if (_usuarioOriginal == null)   
            {
                MessageBox.Show("No se cargó el usuario a editar.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            ep.Clear();
            lblError.Text = string.Empty;
            lblError.ForeColor = _colorNormal;

            bool formularioValido = true;

            // Validaciones basicas sobre el contido de los text box
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                ep.SetError(txtUsuario, "Obligatorio");
                formularioValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ep.SetError(txtNombre, "Obligatorio");
                formularioValido = false;
            }
            if (!formularioValido)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Completa los campos marcados.";
                return;
            }

            // Comprobar duplicado si cambio el nombre de usuario
            string nuevoUsuario = txtUsuario.Text.Trim();
            bool nombreCambio = !nuevoUsuario.Equals(_usuarioOriginal.NombreUsuario,
                                   StringComparison.OrdinalIgnoreCase);

            if (nombreCambio)
            {
                bool nombreDuplicado = _repo.TraerTodos()
                    .Any(u => u.NombreUsuario.Equals(
                              nuevoUsuario, StringComparison.OrdinalIgnoreCase));

                if (nombreDuplicado)
                {
                    MessageBox.Show("Ese nombre de usuario ya existe.",
                                    "Duplicado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }

            bool cambiarClave = chkCambiarClave.Checked;

            if (cambiarClave)
            {
                if (string.IsNullOrWhiteSpace(txtClaveNueva.Text))
                {
                    ep.SetError(txtClaveNueva, "Ingrese la nueva contraseña");
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "La nueva contraseña es obligatoria.";
                    return;
                }
            }

            var usuarioActualizado = new UsuarioSistema
            {
                IdUsuarioSistema = _usuarioOriginal.IdUsuarioSistema,
                NombreCompleto = txtNombre.Text.Trim(),
                NombreUsuario = nuevoUsuario,
                Rol = cmbRol.Text,
                Activo = chkActivo.Checked ? "Si" : "No",

                Contrasena = cambiarClave
             ? txtClaveNueva.Text
             : _usuarioOriginal.Contrasena,
            };

            _repo.Actualizar(usuarioActualizado);

            MessageBox.Show("Cambios guardados.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Close();
        }
    }
}
