using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.Models
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public decimal Costo { get; set; }
        public int DuracionEstimadaMin { get; set; }
        public string Activo { get; set; } = "Si";
    }
}
