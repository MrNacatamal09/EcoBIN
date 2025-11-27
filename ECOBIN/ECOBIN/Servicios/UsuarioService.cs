using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ECOBIN.Modelos;

namespace ECOBIN.Servicios
{
    public static class UsuarioService
    {
        // Ruta fija que tú usas
        private static string carpetaDatos =
            @"C:\Users\HP\OneDrive\Documents\II SEMESTRE\PROGRAMACION ESTRUCTURADA\ECOBIN\ECOBIN\ECOBIN\Archivos";

        private static string archivoUsuarios = Path.Combine(carpetaDatos, "usuarios.txt");

        // Credenciales del admin por defecto
        private const string CIF_ADMIN = "24010000";          // 8 dígitos para que pase tu validación
        private const string PASS_ADMIN = "admin123";
        private const string NOMBRE_ADMIN = "EcoBIN";

        static UsuarioService()
        {
            // Crea la carpeta si no existe
            if (!Directory.Exists(carpetaDatos))
                Directory.CreateDirectory(carpetaDatos);

            // Crea el archivo si no existe
            if (!File.Exists(archivoUsuarios))
                File.Create(archivoUsuarios).Close();

            // Asegurar que exista un usuario administrador
            AsegurarAdminPorDefecto();
        }

        // Cargar todos los usuarios del TXT
        public static List<Usuario> CargarUsuarios()
        {
            var lista = new List<Usuario>();

            var lineas = File.ReadAllLines(archivoUsuarios);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split(';');
                if (partes.Length < 4) continue; // mínimo CIF;Nombre;Password;Puntos

                var u = new Usuario
                {
                    CIF = partes[0],
                    Nombre = partes[1],
                    Password = partes[2],
                    Puntos = int.Parse(partes[3]),
                    // Si el archivo tiene la 5ª columna, la usamos como Rol; si no, asumimos "Usuario"
                    Rol = (partes.Length >= 5) ? partes[4] : "Usuario"
                };

                lista.Add(u);
            }

            return lista;
        }

        // Guardar la lista completa en el TXT (ahora incluye el Rol)
        public static void GuardarUsuarios(List<Usuario> usuarios)
        {
            var lineas = usuarios.Select(u =>
                $"{u.CIF};{u.Nombre};{u.Password};{u.Puntos};{u.Rol}");

            File.WriteAllLines(archivoUsuarios, lineas);
        }

        // Buscar usuario por CIF
        public static Usuario BuscarPorCif(string cif)
        {
            return CargarUsuarios()
                .FirstOrDefault(u => u.CIF.Equals(cif, StringComparison.OrdinalIgnoreCase));
        }

        // Registrar nuevo usuario si no existe antes (siempre Rol = "Usuario")
        public static Usuario RegistrarNuevo(string cif, string nombre, string password)
        {
            var usuarios = CargarUsuarios();

            if (usuarios.Any(u => u.CIF.Equals(cif, StringComparison.OrdinalIgnoreCase)))
            {
                return null; // Ya existe
            }

            var nuevo = new Usuario
            {
                CIF = cif,
                Nombre = nombre,
                Password = password,
                Puntos = 0,
                Rol = "Usuario"
            };

            usuarios.Add(nuevo);
            GuardarUsuarios(usuarios);

            return nuevo;
        }

        public static void SumarPuntos(string cif, int puntos)
        {
            var usuarios = CargarUsuarios();
            var u = usuarios.FirstOrDefault(x =>
                x.CIF.Equals(cif, StringComparison.OrdinalIgnoreCase));

            if (u == null) return;

            // Si es admin, no modificamos sus puntos
            if (u.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                return;

            u.Puntos += puntos;
            GuardarUsuarios(usuarios);
        }

        // Crear admin si aún no existe ninguno
        private static void AsegurarAdminPorDefecto()
        {
            var usuarios = CargarUsuarios();

            bool existeAdmin = usuarios.Any(u =>
                u.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase));

            if (!existeAdmin)
            {
                var admin = new Usuario
                {
                    CIF = CIF_ADMIN,
                    Nombre = NOMBRE_ADMIN,
                    Password = PASS_ADMIN,
                    Puntos = 0,
                    Rol = "Admin"
                };
                usuarios.Add(admin);
                GuardarUsuarios(usuarios);
            }
        }
    }
}