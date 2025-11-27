using ECOBIN.Servicios;
using System;
using System.Windows.Forms;
using ECOBIN.Modelos;

namespace ECOBIN.Ventanas_Adicionales
{
    public partial class MenuOpciones : Form
    {
        private Usuario usuarioActual;

        public MenuOpciones(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void MenuOpciones_Load(object sender, EventArgs e)
        {
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
        }

        // ================================================
        //  REGISTRO DE MATERIALES (Restringido para Admin)
        // ================================================
        private void registroDeMaterialesAReciclarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioActual.Rol != null &&
                usuarioActual.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "El administrador no puede registrar materiales.\n" +
                    "Este usuario está destinado únicamente a pruebas y supervisión.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // No abre nada
            }

            this.Hide();
            new Registro(usuarioActual).Show();
        }

        // =================================================
        //  CONSULTA DE PUNTOS (Restringido para Admin)
        // =================================================
        private void consultaTusPuntosEcoBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioActual.Rol != null &&
                usuarioActual.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "El administrador no tiene historial de puntos.\n" +
                    "Este usuario está destinado únicamente a pruebas y supervisión.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // No abre la consulta
            }

            this.Hide();
            new ConsultaPuntos(usuarioActual).Show();
        }

        // =================================================
        //  RANKING (Sí permitido para admin como “visor”)
        // =================================================
        private void rankingGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RankingGen(usuarioActual).Show();
        }

        // =================================================
        //  SALIR
        // =================================================
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
