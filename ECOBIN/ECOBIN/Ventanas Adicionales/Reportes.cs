using ECOBIN.Modelos;
using ECOBIN.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOBIN.Ventanas_Adicionales
{
    public partial class Reportes : Form
    {
        private readonly Usuario _usuarioActual;
        public Reportes()
        {
            InitializeComponent();
        }

        public Reportes(Usuario usuario) : this()
        {
            _usuarioActual = usuario;

            // Si no es admin, lo cerramos inmediatamente
            if (!EsAdmin())
            {
                MessageBox.Show(
                    "Solo el administrador puede acceder al módulo de reportes.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Cierro el form antes de que el usuario vea algo
                this.Load += (s, e) => this.Close();
            }
        }

        private bool EsAdmin()
        {
            return _usuarioActual != null &&
                   _usuarioActual.Rol != null &&
                   _usuarioActual.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            dtDesde.Value = DateTime.Today.AddDays(-7); // por defecto, última semana
            dtHasta.Value = DateTime.Today;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtDesde.Value.Date;
            DateTime hasta = dtHasta.Value.Date.AddDays(1).AddTicks(-1); // incluir todo el día

            GenerarReporteGeneral(desde, hasta);
        }

        private void GenerarReporteGeneral(DateTime desde, DateTime hasta)
        {
            // 1. Traer todos los registros y usuarios
            var registros = RegistroService.CargarTodosRegistros()
                .Where(r => r.Fecha >= desde && r.Fecha <= hasta)
                .ToList();

            var usuarios = UsuarioService.CargarUsuarios();

           
            //RESUMEN POR MATERIAL
            
            dataGridMateriales.Columns.Clear();
            dataGridMateriales.Rows.Clear();

            dataGridMateriales.Columns.Add("Material", "Material");
            dataGridMateriales.Columns.Add("PesoTotal", "Cantidad total (lb)");
            dataGridMateriales.Columns.Add("Registros", "N° registros");

            var resumenMaterial = registros
                .GroupBy(r => r.Material)
                .Select(g => new
                {
                    Material = g.Key,
                    PesoTotal = g.Sum(x => x.PesoLb),
                    Registros = g.Count()
                })
                .OrderByDescending(x => x.PesoTotal);

            foreach (var m in resumenMaterial)
            {
                dataGridMateriales.Rows.Add(
                    m.Material,
                    m.PesoTotal,
                    m.Registros
                );
            }

            
            //RESUMEN POR USUARIO
            dataGridUsuarios.Columns.Clear();
            dataGridUsuarios.Rows.Clear();

            dataGridUsuarios.Columns.Add("CIF", "CIF");
            dataGridUsuarios.Columns.Add("Nombre", "Nombre");
            dataGridUsuarios.Columns.Add("PesoTotal", "Peso reciclado (lb)");
            dataGridUsuarios.Columns.Add("PuntosTotales", "Puntos totales");
            dataGridUsuarios.Columns.Add("Registros", "N° registros");

            var resumenUsuario = registros
                .GroupBy(r => r.CifUsuario)
                .Select(g => new
                {
                    CIF = g.Key,
                    PesoTotal = g.Sum(x => x.PesoLb),
                    PuntosTotales = g.Sum(x => x.PuntosObtenidos),
                    Registros = g.Count()
                })
                .OrderByDescending(x => x.PuntosTotales);

            foreach (var u in resumenUsuario)
            {
                var usuario = usuarios.FirstOrDefault(x => x.CIF == u.CIF);
                string nombre = usuario != null ? usuario.Nombre : "(desconocido)";

                dataGridUsuarios.Rows.Add(
                    u.CIF,
                    nombre,
                    u.PesoTotal,
                    u.PuntosTotales,
                    u.Registros
                );
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void menuDeOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuOpciones(_usuarioActual).Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
