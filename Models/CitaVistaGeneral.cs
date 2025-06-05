using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    public class CitaVistaGeneral
    {
        public string HoraInicio { get; set; } = null!;
        public string NombrePaciente { get; set; } = null!;
        public string NombreProfesional { get; set; } = null!;
        public string NombreServicio { get; set; } = null!;
        public string EstadoCita { get; set; } = null!;
    }
}
