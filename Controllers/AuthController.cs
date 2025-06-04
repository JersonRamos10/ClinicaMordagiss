using SistemaDeCitasMordagiss.DataAccess;
using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Controllers
{
    public class AuthController
    {
        //Intenta autenticar al usuario dado (nombreUsuario + contrasenaPlain)
        public static UsuarioSistema? Authenticate(string nombreUsuario, string contrasenaPlain)
        {
            var repo = new UsuarioRepo();
            return repo.GetByNombreUsuarioAndContrasena(nombreUsuario, contrasenaPlain);
        }
    }
}

