using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECOBIN.Ventanas_Adicionales;
using ECOBIN.Modelos;
using ECOBIN.Servicios;

namespace ECOBIN.Ventanas_Adicionales
{
    public partial class ConsultaPuntos : Form
    {
        private Usuario _usuarioActual; // Aquí guardo al usuario que está usando EcoBIN en este momento
        public ConsultaPuntos(Usuario usuario) // Constructor: recibe el usuario que viene desde el login / menú
        {
            InitializeComponent(); // Inicializa todos los controles que diseñé en el formulario
            _usuarioActual = usuario; // Guardo el usuario recibido para usarlo en toda la ventana
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void ConsultaPuntos_Load(object sender, EventArgs e)
        {
            ConfigurarGrids();
            CargarDatos();
        }
        private void ConfigurarGrids()
        {
            // === Grid IZQUIERDO: Reciclaje ===
            dataGridViewReciclaje.Columns.Clear();
            dataGridViewReciclaje.AutoGenerateColumns = false;
            dataGridViewReciclaje.ReadOnly = true;
            dataGridViewReciclaje.AllowUserToAddRows = false;

            dataGridViewReciclaje.Columns.Add("Fecha", "Fecha y Hora");
            dataGridViewReciclaje.Columns.Add("Material", "Tipo de Material");
            dataGridViewReciclaje.Columns.Add("Cantidad", "Cantidad (lb)");
            dataGridViewReciclaje.Columns.Add("Puntos", "Puntos Obtenidos");

            // === Grid DERECHO: Movimientos generales ===
            dataGridViewMovimientos.Columns.Clear();
            dataGridViewMovimientos.AutoGenerateColumns = false;
            dataGridViewMovimientos.ReadOnly = true;
            dataGridViewMovimientos.AllowUserToAddRows = false;

            dataGridViewMovimientos.Columns.Add("Fecha", "Fecha y Hora");
            dataGridViewMovimientos.Columns.Add("Operacion", "Operación");
            dataGridViewMovimientos.Columns.Add("Detalle", "Detalles");
            dataGridViewMovimientos.Columns.Add("Puntos", "Puntos (+/-)");
        }


        //   CARGAR DATOS:
        // Carga puntos globales, registros de reciclaje y movimientos del usuario

        private void CargarDatos()
        {
            // Refrescar usuario desde archivo
            var usuarioRefrescado = UsuarioService.BuscarPorCif(_usuarioActual.CIF);
            if (usuarioRefrescado != null)
                _usuarioActual = usuarioRefrescado;

            // Mostrar puntos globales
            labelPuntos.Text = _usuarioActual.Puntos.ToString();

            // === GRID IZQUIERDO: reciclaje ===
            dataGridViewReciclaje.Rows.Clear();
            var registros = RegistroService.CargarRegistrosPorUsuario(_usuarioActual.CIF);

            foreach (var r in registros)
            {
                dataGridViewReciclaje.Rows.Add(
                    r.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    r.Material,
                    r.PesoLb,
                    r.PuntosObtenidos
                );
            }

            // === GRID DERECHO: movimientos ===
            dataGridViewMovimientos.Rows.Clear();

            // Reciclajes (puntos +)
            foreach (var r in registros)
            {
                dataGridViewMovimientos.Rows.Add(
                    r.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    "Reciclaje",
                    $"{r.Material} ({r.PesoLb} lb)",
                    "+" + r.PuntosObtenidos
                );
            }

            // Canjes (puntos -)
            var canjes = CanjeService.CargarCanjesPorUsuario(_usuarioActual.CIF);

            foreach (var c in canjes)
            {
                dataGridViewMovimientos.Rows.Add(
                    c.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    "Canje",
                    c.Beneficio,
                    "-" + c.PuntosUsados
                );
            }
        }

        // Extrae el número de puntos desde el texto del beneficio (ej: "(1000 pts)")
        private int ObtenerPuntosDesdeTexto(string texto)
        {
            // Buscar el "("
            int inicio = texto.IndexOf('(');

            // Buscar la palabra "pts"
            int fin = texto.IndexOf("pts", StringComparison.OrdinalIgnoreCase);

            // Si no existen, regresar 0
            if (inicio == -1 || fin == -1)
                return 0;

            // Extraer lo que está dentro del paréntesis
            // Ej: "(1000 pts)" → "1000 "
            string dentro = texto.Substring(inicio + 1, fin - inicio - 1);

            // Quitar todo excepto dígitos
            string soloNumero = new string(dentro.Where(char.IsDigit).ToArray());

            // Convertir a entero
            return int.TryParse(soloNumero, out int puntos) ? puntos : 0;
        }

        // Abre el formulario de Registro de Material
        private void registroDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registro(_usuarioActual).Show();
        }

        // Abre el formulario del Ranking General
        private void rankingGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RankingGen(_usuarioActual).Show();
        }

        // Regresa al login
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Botón de canjear beneficios
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBeneficios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un beneficio para canjear.",
                    "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string beneficioTexto = comboBeneficios.SelectedItem.ToString();
            int puntosNecesarios = ObtenerPuntosDesdeTexto(beneficioTexto);

            // Actualizar usuario
            var usuarioRefrescado = UsuarioService.BuscarPorCif(_usuarioActual.CIF);
            if (usuarioRefrescado != null)
                _usuarioActual = usuarioRefrescado;

            if (_usuarioActual.Puntos < puntosNecesarios)
            {
                MessageBox.Show("No tienes puntos suficientes.",
                    "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            var confirmar = MessageBox.Show(
                $"¿Deseas canjear {puntosNecesarios} puntos por:\n{beneficioTexto}?",
                "Confirmar canje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            // Restar puntos
            UsuarioService.SumarPuntos(_usuarioActual.CIF, -puntosNecesarios);

            // Guardar el canje
            var canje = new CanjeBeneficio
            {
                CifUsuario = _usuarioActual.CIF,
                Fecha = DateTime.Now,
                Beneficio = beneficioTexto,
                PuntosUsados = puntosNecesarios
            };

            CanjeService.GuardarCanje(canje);

            MessageBox.Show("Canje realizado correctamente.",
                "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar todo
            CargarDatos();
        }

    }
}
