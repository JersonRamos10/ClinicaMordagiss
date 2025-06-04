using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Controllers
{
   class AuthController
    {
        public static UsuarioSistema Authenticate(string nombreUsuario, string contrasenaPlain)
        {
            var repo = new UsuarioSistemaRepository();
            return repo.GetByNombreUsuarioAndContrasena(nombreUsuario, contrasenaPlain);
        }
    }
}
