using SistemaDeCitasMordagiss.Controllers;
using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using SistemaDeCitasMordagiss.Views.Admin;
using System;
using System.Windows.Forms;

namespace SistemaDeCitasMordagiss.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnIniciarSesion.Click += btnIniciarSesion_Click;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Leer y normalizar inputs
            string nombreUsuario = txtNombreUsuario.Text.Trim().ToLower();
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

            try
            {
                // Autenticar con AuthController (usa UsuarioRepo internamente)
                UsuarioSistema? user = AuthController.Authenticate(nombreUsuario, contrasena);
                if (user == null)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Error de autenticación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // esta condicion es para Validar si la cuenta esta activa
                if (user.Activo.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "La cuenta está inactiva. Consulta con el administrador.",
                        "Cuenta inactiva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Abrir el form correspondiente según el rol
                switch (user.Rol)
                {
                    case "Administrador":
                        this.Hide();
                        new DashboardAdminForm(user).Show();
                        break;

                    case "Secretaria":
                        this.Hide();
                        new DashboardSecretariaForm(user).Show();
                        break;

                    case "ProfesionalMedico":

                        
                        var medicoRepo = new MedicoRepo();
                        ProfesionalMedico? profesional =
                            medicoRepo.TraerPorUsuario(user.NombreUsuario);

                        if (profesional == null)
                        {
                            MessageBox.Show(
                                "No se encontró ficha médica para este usuario.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }

                        this.Hide();
                        new DashboardMedicoForm(profesional, user.Rol).Show();
                        break;

                    default:
                        MessageBox.Show(
                            "Rol de usuario no reconocido.",
                            "Error de rol",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al intentar iniciar sesión:\n{ex.Message}",
                    "Error inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
