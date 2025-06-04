using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCitasMordagiss.Views.Admin
{
   
    public partial class AgregarNuevoUsuarioForm : Form
    {
        private readonly UsuarioRepo _repo = new();   // acceso BD

        private readonly Color _colorNormal;
        public AgregarNuevoUsuarioForm()
        {
            InitializeComponent();

            // llenar combo de roles
            cmbRol.Items.AddRange(new[] { "Administrador", "Secretaria", "ProfesionalMedico" });
       
            cmbRol.SelectedIndex = 0;

            // eventos
            btnGuardar.Click += Guardar;
            btnCancelar.Click += (s, e) => Close();

            _colorNormal = lblUsuario.ForeColor;


        }
        private void Guardar(object? sender, EventArgs e)
        {
            ep.Clear();
            lblError.Text = "";
            lblUsuario.ForeColor = _colorNormal;
            lblClave.ForeColor = _colorNormal;

            bool ok = true;
            // validaciones simples de entrada de datos de los text box
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                lblUsuario.ForeColor = Color.Red;
                ep.SetError(txtUsuario, "Obligatorio");
                ok = false;
            }
            else
            {
                var color = lblUsuario.ForeColor;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                lblClave.ForeColor = Color.Red;
                ep.SetError(txtClave, "Obligatorio");
                ok = false;
            }
            else
            {
                var color = lblClave.ForeColor;
            }

            if (!ok)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Completa los campos marcados con *";
                return;
            }


            // validar que el nombre de usuario no exista
            bool existe = _repo.TraerTodos()
                               .Exists(u => u.NombreUsuario.Equals(txtUsuario.Text.Trim(),
                                        StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                MessageBox.Show($"El usuario “{txtUsuario.Text.Trim()}” ya existe.",
                        "Usuario duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            // crear objeto y grabar
            var nuevo = new UsuarioSistema
            {
                NombreCompleto = txtNombre.Text.Trim(),
                NombreUsuario = txtUsuario.Text.Trim(),
                Contrasena = txtClave.Text,
                Rol = cmbRol.Text,
                Activo = chkActivo.Checked ? "si" : "no"
            };

           
            _repo.Crear(nuevo); // actualizar la tabla (grilla)
            Close();   
        }


    }
}
