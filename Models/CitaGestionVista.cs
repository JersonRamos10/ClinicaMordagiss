using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    public class CitaGestionVista
    {
        public int IdCita { get; set; }
        public string FechaCita { get; set; } = "";     
        public string HoraInicio { get; set; } = "";   
        public string HoraFin { get; set; } = "";    
        public string NombrePaciente { get; set; } = "";
        public string NombreProfesional { get; set; } = "";
        public string NombreServicio { get; set; } = "";
        public string EstadoCita { get; set; } = "";
        public int IdPaciente { get; set; }
        public int IdProfesionalMedico { get; set; }
        public int IdServicio { get; set; }

        
        public CitaGestionVista() { }
    }
}
