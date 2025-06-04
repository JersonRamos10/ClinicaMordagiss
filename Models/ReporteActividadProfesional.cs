using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
   public class ReporteActividadProfesional
    {
        public int IdProfesionalMedico { get; set; }
        public string NombreCompleto { get; set; } = "";
        public int TotalCitas { get; set; }
    }
}
