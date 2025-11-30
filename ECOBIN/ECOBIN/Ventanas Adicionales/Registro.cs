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
    public partial class Registro : Form
    {

        private readonly Usuario _usuarioActual;

        private static readonly string[] FrasesInspiradoras = new[]
        {
            "Cada botella cuenta. ¡Gracias por reciclar!",
            "Tus pequeñas acciones crean grandes cambios.",
            "Hoy reciclas, mañana respiras aire más limpio.",
            "El planeta te lo agradece, ¡sigue así!",
            "Convertir basura en puntos es convertir futuro en esperanza.",
            "EcoBIN: sumando puntos, restando residuos.",
            "Lo que hoy reciclas, mañana no contamina.",
            "Tu ejemplo motiva a otros a cuidar el ambiente.",
            "Reciclar es una forma de decirle 'te quiero' a la Tierra.",
            "Un EcoPunto más, un problema menos."
        };
        private static readonly Random _rnd = new Random();
        public Registro(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            if (_usuarioActual.Rol == "Admin")
            {
                MessageBox.Show("El administrador no puede registrar reciclaje.",
                    "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close(); // o deshabilitar controles
            }
            
            MostrarFraseInspiradora();
        }

        private void MostrarFraseInspiradora()
        {
            if (FrasesInspiradoras.Length == 0) return;

            int indice = _rnd.Next(FrasesInspiradoras.Length);
            lblFrases.Text = FrasesInspiradoras[indice];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void consultaDePuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultaPuntos(_usuarioActual).Show();
        }

        private void rankingGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RankingGen(_usuarioActual).Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar material
            if (cbMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de material.", "EcoBIN",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar peso
            if (!double.TryParse(tbPeso.Text, out double peso) || peso <= 0)
            {
                MessageBox.Show("Ingrese un peso válido en libras.", "EcoBIN",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string textoCombo = cbMaterial.SelectedItem.ToString();
            string nombreMaterial = textoCombo.Split('(')[0].Trim();  

            int puntosPorLb = RegistroService.ObtenerPuntosPorLb(nombreMaterial);
            int puntosObtenidos = (int)Math.Round(peso * puntosPorLb);

            // Crear registro
            var registro = new RegistroMaterial
            {
                CifUsuario = _usuarioActual.CIF,
                Material = nombreMaterial,
                PesoLb = peso,
                PuntosObtenidos = puntosObtenidos,
                Fecha = DateTime.Now
            };

            // Guardar en registros.txt
            RegistroService.GuardarRegistro(registro);

            // Sumar puntos al usuario en usuarios.txt
            UsuarioService.SumarPuntos(_usuarioActual.CIF, puntosObtenidos);

            MessageBox.Show(
                $"Registro guardado.\nObtuviste {puntosObtenidos} puntos.",
                "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            tbPeso.Clear();
            cbMaterial.SelectedIndex = -1;
        }
    }
}
