using SistemaDeCitasMordagiss.Controllers;
using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCitasMordagiss.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show(
                    "Por favor ingresa usuario y contraseña.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            UsuarioSistema user = AuthController.Authenticate(nombreUsuario, contrasena);
            if (user == null)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos, o cuenta inactiva.",
                    "Error de autenticación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Form dashboard;
            switch (user.Rol)
            {
                case "Administrador":
                    dashboard = new DashboardAdminForm(user);
                    break;
                case "Secretaria":
                    dashboard = new DashboardSecretariaForm(user);
                    break;
                case "ProfesionalMedico":
                    dashboard = new DashboardMedicoForm(user);
                    break;
                default:
                    MessageBox.Show(
                        "Rol de usuario no reconocido.",
                        "Error de rol",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
            }

            this.Hide();
            dashboard.FormClosed += (s, args) => this.Show();
            dashboard.Show();
        
        }
    }
}
