using System;

namespace ECOBIN.Modelos
{
    //Clase para representar un registro de material reciclado
    public class RegistroMaterial
    {
        public string CifUsuario { get; set; }      // quién recicló
        public string Material { get; set; }        // Plástico, Papel, etc.
        public double PesoLb { get; set; }          // peso en libras
        public int PuntosObtenidos { get; set; }    // puntos ganados
        public DateTime Fecha { get; set; }         // fecha del registro
    }
}
