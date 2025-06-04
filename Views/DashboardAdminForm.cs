using SistemaDeCitasMordagiss.Controllers;
using SistemaDeCitasMordagiss.Models;
using SistemaDeCitasMordagiss.Views.Admin;
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
    public partial class DashboardAdminForm : Form
    {
        private readonly UsuarioSistema _usuarioActual;
        private readonly UcUsuarios _ucUsuarios = new();
        private readonly UcMedicos _ucMedicos = new();
        private readonly UcServicios _ucServicios = new();
        private readonly UcReportes _ucReportes = new();



        public DashboardAdminForm(UsuarioSistema usuario)
        {
            InitializeComponent();

            //se guardan los datos del usuario y se muestran

            _usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            lblBienvenida.Text = $"Bienvenido/a, {_usuarioActual.NombreCompleto}";
            lblRol.Text = $"Rol: {_usuarioActual.Rol}";

            _ucUsuarios.Dock =
            _ucMedicos.Dock =
            _ucServicios.Dock =
            _ucReportes.Dock = DockStyle.Fill;

            pnlContenido.Controls.AddRange(
            new Control[] { _ucUsuarios, _ucMedicos, _ucServicios, _ucReportes });

            lkUsuarios.LinkClicked += (s, e) => Mostrar(_ucUsuarios);
            lkMedicos.LinkClicked += (s, e) => Mostrar(_ucMedicos);
            lkServicios.LinkClicked += (s, e) => Mostrar(_ucServicios);
            lkReportes.LinkClicked += (s, e) => Mostrar(_ucReportes);

            Mostrar(_ucUsuarios);
        }

        private void Mostrar(UserControl cual)
        {
            foreach (Control c in pnlContenido.Controls) c.Visible = false;
            cual.Visible = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
