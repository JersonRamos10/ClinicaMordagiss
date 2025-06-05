using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    class VistaPaciente
    {
        public int IdPaciente { get; set; }
        public string NombreCompleto { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string UltimaVisita { get; set; } = "";
    }
}
