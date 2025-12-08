using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ECOBIN.Servicios
{
    public static class MaterialesService
    {
        // Usa la misma carpeta de siempre
        private static string carpetaDatos =
            @"C:\Users\HP\OneDrive\Documents\II SEMESTRE\PROGRAMACION ESTRUCTURADA\ECOBIN\ECOBIN\ECOBIN\Archivos";

        private static string archivoRegistrosCsv = Path.Combine(carpetaDatos, "registros.csv");
        private static string archivoMaterialesTxt = Path.Combine(carpetaDatos, "materiales_totales.txt");

        static MaterialesService()
        {
            if (!Directory.Exists(carpetaDatos))
                Directory.CreateDirectory(carpetaDatos);

            // El txt se generará igual cada vez, pero si no existe lo creo vacío
            if (!File.Exists(archivoMaterialesTxt))
                File.Create(archivoMaterialesTxt).Close();
        }

        // Genera o regenera el archivo materiales_totales.txt
        public static void ActualizarResumenMateriales()
        {
            // Si aún no hay registros, dejo el archivo solo con encabezado o vacío
            if (!File.Exists(archivoRegistrosCsv))
            {
                File.WriteAllText(archivoMaterialesTxt, "Material;PesoTotalLb");
                return;
            }

            var lineas = File.ReadAllLines(archivoRegistrosCsv);

            // Lista temporal con (material, peso)
            var registros = new List<(string Material, double PesoLb)>();

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                // Ajusta el separador si tu CSV usa coma en vez de punto y coma
                var partes = linea.Split(';');
                // Esperado: CIF;Material;PesoLb;Puntos;Fecha
                if (partes.Length < 3)
                    continue;

                string material = partes[1].Trim();

                if (!double.TryParse(partes[2], out double peso))
                    peso = 0;

                registros.Add((material, peso));
            }

            // Agrupar por material y sumar peso
            var resumen = registros
                .GroupBy(r => r.Material)
                .Select(g => new
                {
                    Material = g.Key,
                    PesoTotal = g.Sum(x => x.PesoLb)
                })
                .OrderBy(r => r.Material)
                .ToList();

            var salida = new List<string>();

            // Encabezado (si no lo quieres, borra esta línea)
            salida.Add("Material;PesoTotalLb");

            foreach (var item in resumen)
            {
                salida.Add($"{item.Material};{item.PesoTotal}");
            }

            // Muy importante: siempre se sobrescribe, no se van acumulando
            File.WriteAllLines(archivoMaterialesTxt, salida);
        }
    }
}
