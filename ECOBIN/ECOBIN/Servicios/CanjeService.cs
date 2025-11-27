using System;
using System.Collections.Generic;
using System.IO;
using ECOBIN.Modelos;

namespace ECOBIN.Servicios
{
    public static class CanjeService
    {
        private static string carpetaDatos =
            @"C:\Users\HP\OneDrive\Documents\II SEMESTRE\PROGRAMACION ESTRUCTURADA\ECOBIN\ECOBIN\ECOBIN\Archivos";

        private static string archivoCanjes = Path.Combine(carpetaDatos, "canjes.csv");

        static CanjeService()
        {
            if (!Directory.Exists(carpetaDatos))
                Directory.CreateDirectory(carpetaDatos);

            if (!File.Exists(archivoCanjes))
                File.Create(archivoCanjes).Close();
        }

        public static void GuardarCanje(CanjeBeneficio canje)
        {
            string linea = string.Join(";",
                canje.CifUsuario,
                canje.Fecha.ToString("yyyy-MM-dd HH:mm:ss"),
                canje.Beneficio,
                canje.PuntosUsados
            );

            File.AppendAllLines(archivoCanjes, new[] { linea });
        }

        public static List<CanjeBeneficio> CargarCanjesPorUsuario(string cif)
        {
            var lista = new List<CanjeBeneficio>();

            if (!File.Exists(archivoCanjes))
                return lista;

            var lineas = File.ReadAllLines(archivoCanjes);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split(';');
                if (partes.Length < 4) continue;

                if (!partes[0].Equals(cif, StringComparison.OrdinalIgnoreCase))
                    continue;

                lista.Add(new CanjeBeneficio
                {
                    CifUsuario = partes[0],
                    Fecha = DateTime.Parse(partes[1]),
                    Beneficio = partes[2],
                    PuntosUsados = int.Parse(partes[3])
                });
            }

            return lista;
        }
    }
}
