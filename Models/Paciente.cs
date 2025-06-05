using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Genero { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string NumeroIdentidad { get; set; } = null!;

        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; } = "";
        public string CorreoElectronico { get; set; } = "";
    }
}
