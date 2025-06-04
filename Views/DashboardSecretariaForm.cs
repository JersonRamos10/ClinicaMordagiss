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
    public partial class DashboardSecretariaForm : Form
    {
        private readonly UsuarioSistema _usuario;

        public DashboardSecretariaForm(UsuarioSistema usuario)
        {
            InitializeComponent();

            _usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            lblBienvenida.Text = $"Bienvenido/a, {_usuario.NombreCompleto}";
            lblRol.Text = $"Rol: {_usuario.Rol}";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void DashboardSecretariaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
