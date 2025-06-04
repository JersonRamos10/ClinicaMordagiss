using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    public class AgendaCita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdServicio { get; set; }

        public string? NombrePaciente { get; set; }
        public int IdProfesionalMedico { get; set; }
        public DateTime FechaCita { get; set; }
        public string HoraInicio { get; set; } = null!;
        public string HoraFin { get; set; } = null!;
        public string EstadoCita { get; set; } = null!;
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistroCita { get; set; }
    }
}
