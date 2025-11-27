using System;
using System.Collections.Generic;
using System.IO;
using ECOBIN.Modelos;

namespace ECOBIN.Servicios
{
    public static class RegistroService
    {
        
        private static string carpetaDatos =
            @"C:\Users\HP\OneDrive\Documents\II SEMESTRE\PROGRAMACION ESTRUCTURADA\ECOBIN\ECOBIN\ECOBIN\Archivos";

        private static string archivoRegistros = Path.Combine(carpetaDatos, "registros.csv");

        // puntos por libra según el material
        private static readonly Dictionary<string, int> puntosPorLb = new Dictionary<string, int>
        {
            { "Plástico", 20 },
            { "Papel", 15 },
            { "Cartón", 20 },
            { "Vidrio", 30 },
            { "Electrónicos", 50}
        };

        static RegistroService()
        {
            if (!Directory.Exists(carpetaDatos))
                Directory.CreateDirectory(carpetaDatos);

            if (!File.Exists(archivoRegistros))
                File.Create(archivoRegistros).Close();
        }

        public static int ObtenerPuntosPorLb(string material)
        {
            if (puntosPorLb.TryGetValue(material, out int valor))
                return valor;

            return 0;
        }

        // Guarda UNA línea nueva en el archivo
        public static void GuardarRegistro(RegistroMaterial registro)
        {
            string linea = string.Join(";",
                registro.CifUsuario,
                registro.Material,
                registro.PesoLb,
                registro.PuntosObtenidos,
                registro.Fecha.ToString("yyyy-MM-dd HH:mm:ss")
            );

            File.AppendAllLines(archivoRegistros, new[] { linea });
        }
        public static List<RegistroMaterial> CargarRegistrosPorUsuario(string cif)
        {
            var lista = new List<RegistroMaterial>();

            if (!File.Exists(archivoRegistros))
                return lista;

            var lineas = File.ReadAllLines(archivoRegistros);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split(';');
                if (partes.Length < 5) continue;

                // Estructura: CIF;Material;Peso;Puntos;Fecha
                if (!partes[0].Equals(cif, StringComparison.OrdinalIgnoreCase))
                    continue;

                lista.Add(new RegistroMaterial
                {
                    CifUsuario = partes[0],
                    Material = partes[1],
                    PesoLb = double.Parse(partes[2]),
                    PuntosObtenidos = int.Parse(partes[3]),
                    Fecha = DateTime.Parse(partes[4])
                });
            }

            return lista;
        }
    }
}
