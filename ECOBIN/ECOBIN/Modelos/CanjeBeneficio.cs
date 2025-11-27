using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOBIN.Modelos
{
    public class CanjeBeneficio
    {
        public string CifUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Beneficio { get; set; }
        public int PuntosUsados { get; set; }
    }
}
