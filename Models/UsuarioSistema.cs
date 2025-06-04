using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    public class UsuarioSistema
    {
        public int IdUsuarioSistema { get; set; }
        public string? NombreCompleto { get; set; }
        public string? NombreUsuario { get; set; }

        public string? Contrasena { get; set; }

        public string? Rol {get; set; }

        public string? Activo { get; set; }
    }
}
