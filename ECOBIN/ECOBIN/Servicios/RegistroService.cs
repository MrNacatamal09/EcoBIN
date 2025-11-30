using ECOBIN.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ECOBIN.Servicios
{
    public static class RegistroService
    {

        // ruta del archivo de datos
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

        // Constructor estático para asegurar que la carpeta y el archivo existan
        static RegistroService()
        {
            if (!Directory.Exists(carpetaDatos))
                Directory.CreateDirectory(carpetaDatos);

            if (!File.Exists(archivoRegistros))
                File.Create(archivoRegistros).Close();
        }

        // Obtiene los puntos por libra para un material dado
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

        // Carga todos los registros de un usuario específico
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

        // Elimina todos los registros asociados a un usuario específico
        public static void EliminarRegistrosPorUsuario(string cif)
        {
            if (!File.Exists(archivoRegistros))
                return;

            var lineas = File.ReadAllLines(archivoRegistros);

            // Me quedo solo con las líneas que NO pertenecen a ese CIF
            var filtradas = lineas
                .Where(l => !string.IsNullOrWhiteSpace(l) &&
                            !l.StartsWith(cif + ";", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            File.WriteAllLines(archivoRegistros, filtradas);
        }

        // Carga todos los registros
        public static List<RegistroMaterial> CargarTodosRegistros()
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

                var reg = new RegistroMaterial
                {
                    CifUsuario = partes[0],
                    Material = partes[1],
                    PesoLb = double.Parse(partes[2]),
                    PuntosObtenidos = int.Parse(partes[3]),
                    Fecha = DateTime.Parse(partes[4])
                };

                lista.Add(reg);
            }

            return lista;
        }

    }
}
