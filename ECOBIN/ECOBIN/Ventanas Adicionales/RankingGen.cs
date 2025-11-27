using ECOBIN.Modelos;
using ECOBIN.Servicios;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ECOBIN.Ventanas_Adicionales
{
    public partial class RankingGen : Form
    {
        private readonly Usuario _usuarioActual;

        public RankingGen(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void RankingGen_Load(object sender, EventArgs e)
        {
            ConfigurarGridRanking();
            CargarRanking();
        }

        //  CONFIGURAR GRID
        private void ConfigurarGridRanking()
        {
            dataGridViewRanking.Columns.Clear();
            dataGridViewRanking.AutoGenerateColumns = false;
            dataGridViewRanking.ReadOnly = true;
            dataGridViewRanking.AllowUserToAddRows = false;
            dataGridViewRanking.RowHeadersVisible = false;
            dataGridViewRanking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewRanking.Columns.Add("Posicion", "#");
            dataGridViewRanking.Columns.Add("Nombre", "Usuario");
            dataGridViewRanking.Columns.Add("MejorMaterial", "Mejor material reciclado");
            dataGridViewRanking.Columns.Add("PuntosMaterial", "Puntos por ese material"); 
            dataGridViewRanking.Columns.Add("PuntosTotales", "Puntos totales");

            dataGridViewRanking.Columns["Posicion"].Width = 60;
            dataGridViewRanking.Columns["Nombre"].Width = 180;
            dataGridViewRanking.Columns["MejorMaterial"].Width = 230;
            dataGridViewRanking.Columns["PuntosMaterial"].Width = 140;
            dataGridViewRanking.Columns["PuntosTotales"].Width = 120;

            dataGridViewRanking.EnableHeadersVisualStyles = false;
            dataGridViewRanking.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dataGridViewRanking.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewRanking.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridViewRanking.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
        }

        //  CARGAR RANKING

        private void CargarRanking()
        {
            dataGridViewRanking.Rows.Clear();

            // 1. Usuarios normales, ordenados por puntos (top 10)
            var usuarios = UsuarioService.CargarUsuarios()
                .Where(u => u.Rol.Equals("Usuario", StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(u => u.Puntos)
                .Take(10)
                .ToList();
            
            int posicion = 1;

            foreach (var u in usuarios)
            {
                // 2. Registros del usuario para hallar su "mejor material"
                var registros = RegistroService.CargarRegistrosPorUsuario(u.CIF);

                string mejorMaterialTexto = "Sin registros";
                int puntosMejorMaterial = 0;

                if (registros.Any())
                {
                    var mejorGrupo = registros
                        .GroupBy(r => r.Material)
                        .Select(g => new
                        {
                            Material = g.Key,
                            Puntos = g.Sum(x => x.PuntosObtenidos)
                        })
                        .OrderByDescending(x => x.Puntos)
                        .First();

                    mejorMaterialTexto = $"{mejorGrupo.Material}";
                    puntosMejorMaterial = mejorGrupo.Puntos;
                }

                // 3. Medallas top 3
                string posTexto = posicion.ToString();
                if (posicion == 1) posTexto = "🥇 1";
                else if (posicion == 2) posTexto = "🥈 2";
                else if (posicion == 3) posTexto = "🥉 3";

                int rowIndex = dataGridViewRanking.Rows.Add(
                    posTexto,
                    u.Nombre,
                    mejorMaterialTexto,
                    puntosMejorMaterial,
                    u.Puntos
                );

                var fila = dataGridViewRanking.Rows[rowIndex];
                if (posicion == 1)
                    fila.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                else if (posicion == 2)
                    fila.DefaultCellStyle.BackColor = Color.LightGray;
                else if (posicion == 3)
                    fila.DefaultCellStyle.BackColor = Color.BurlyWood;

                posicion++;
            }
        }

        //  MENÚ: REGISTRO
        private void registroDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si es admin → NO puede registrar materiales
            if (_usuarioActual.Rol != null &&
                _usuarioActual.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "El administrador no puede registrar materiales.\n" +
                    "Este usuario está destinado únicamente a pruebas y supervisión.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // se queda en RankingGen
            }

            this.Hide();
            new Registro(_usuarioActual).Show();
        }

        //  MENÚ: CONSULTA PUNTOS
        private void consultaTusPuntosEcoBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si es admin → NO tiene historial de puntos
            if (_usuarioActual.Rol != null &&
                _usuarioActual.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "El administrador no tiene historial de puntos.\n" +
                    "Este usuario está destinado únicamente a pruebas y supervisión.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // se queda en RankingGen
            }

            this.Hide();
            new ConsultaPuntos(_usuarioActual).Show();
        }

        //  MENÚ: SALIR
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void RankingGen_Load_1(object sender, EventArgs e)
        {
            ConfigurarGridRanking();
            CargarRanking();
        }
    }
}
