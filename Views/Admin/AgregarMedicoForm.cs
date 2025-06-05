using SistemaDeCitasMordagiss.DataAccess;
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

namespace SistemaDeCitasMordagiss.Views.Admin
{
    public partial class AgregarMedicoForm: Form
    {
        private readonly MedicoRepo _repo = new();
        public AgregarMedicoForm()
        {
            InitializeComponent();

            chkActivo.Checked = true;
            btnGuardar.Click += Guardar;
            btnCancelar.Click += (s, e) => Close();
        }
    

     /*VALIDAR Y GUARDAR */
        private void Guardar(object? sender, EventArgs e)
        {
            ep.Clear();
            lblError.Text = string.Empty;

            bool valido = true;

            /* Validaciones basicas campos vacios o nulos*/
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { ep.SetError(txtNombre, "Obligatorio"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            { ep.SetError(txtApellidos, "Obligatorio"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtEspecialidad.Text) || txtEspecialidad.Text.Length < 3)
            { ep.SetError(txtEspecialidad, "Minimo 3 caracteres"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text) ||
               !(txtTelefono.Text.All(char.IsDigit) && txtTelefono.Text.Length == 8))
            { ep.SetError(txtTelefono, "Formato 8 digitos"); valido = false; }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                !txtCorreo.Text.Contains('@') || !txtCorreo.Text.Contains('.'))
            { ep.SetError(txtCorreo, "Correo no valido"); valido = false; }

            if (!valido)
            {
                lblError.Text = "Corregir los campos marcados como obligatorios *.";
                return;
            }

            /* Comprobar correo duplicado */
            bool correoDuplicado = _repo.TraerTodos()
                .Any(pm => pm.CorreoElectronico.Equals(
                         txtCorreo.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (correoDuplicado)
            {
                MessageBox.Show("Este correo ya esta registrado.",
                                "Duplicado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var nuevoMedico = new ProfesionalMedico
            {
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Especialidad = txtEspecialidad.Text.Trim(),
                TelefonoContacto = txtTelefono.Text.Trim(),
                CorreoElectronico = txtCorreo.Text.Trim(),
                Activo = chkActivo.Checked ? "Si" : "No",
                IdUsuarioSistema = null        
            };

            _repo.Crear(nuevoMedico);

            MessageBox.Show("Profesional Medico registrado.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Close();
        }
    }
}
