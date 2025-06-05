using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdServicio { get; set; }
        public int IdProfesionalMedico { get; set; }
        public string FechaCita { get; set; } = null!; // formato "yyyy-MM-dd"
        public string HoraInicio { get; set; } = null!; // formato "HH:mm"

        public string HoraFin { get; set; }
        public string EstadoCita { get; set; } = null!; // e.g. "Programada", "Confirmada"
        public int? IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistroCita { get; set; }
    }
}
