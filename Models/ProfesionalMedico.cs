using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
   public class ProfesionalMedico
    {
        public int IdProfesionalMedico { get; set; } 
        public string Nombre { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string Especialidad { get; set; } = "";
        public string TelefonoContacto { get; set; } = "";
        public string CorreoElectronico { get; set; } = "";
        public string Activo { get; set; } = "Si";   
        public int?  IdUsuarioSistema   { get; set; }  
    }
}

