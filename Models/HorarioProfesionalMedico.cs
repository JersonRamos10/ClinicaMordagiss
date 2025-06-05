using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
   public class HorarioProfesionalMedico
    {
        public int IdHorario { get; set; } // coincide con IdHorario en la tabla
        public int IdProfesionalMedico { get; set; }
        public string DiaSemana { get; set; } = null!; // e.g. "Monday"
        public string HoraInicioTrabajo { get; set; } = null!; // e.g. "08:00"
        public string HoraFinTrabajo { get; set; } = null!; // e.g. "12:00"
    }

}

