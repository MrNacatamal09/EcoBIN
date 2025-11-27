using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOBIN.Modelos
{
    public class Usuario
    {
        public string CIF { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int Puntos { get; set; } = 0;
        public string Rol { get; set; } = "Usuario";
    }
}
