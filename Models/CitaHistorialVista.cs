using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
   public class CitaHistorialVista
    {
        public string FechaCita { get; set; } = "";
        public string HoraInicio { get; set; } = "";
        public string NombreProfesional { get; set; } = "";
        public string NombreServicio { get; set; } = "";
        public string EstadoCita { get; set; } = "";
    }
}
