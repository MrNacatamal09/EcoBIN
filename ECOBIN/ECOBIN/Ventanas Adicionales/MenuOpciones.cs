using ECOBIN.Servicios;
using System;
using System.Windows.Forms;
using ECOBIN.Modelos;
using Microsoft.VisualBasic;

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
            toolStrip2.Visible = EsAdmin();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
        }

        
        //  REGISTRO DE MATERIALES (Restringido para Admin)
        
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


        //  CONSULTA DE PUNTOS (Restringido para Admin)
        
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

        //  RANKING (Sí permitido para admin como “visor”)
        
        private void rankingGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RankingGen(usuarioActual).Show();
        }

        


       
        //  SALIR
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void actualizarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EsAdmin())
            {
                MessageBox.Show(
                    "Solo el administrador puede actualizar usuarios.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string cif = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el CIF del usuario a actualizar:",
                "Actualizar usuario", "").Trim();

            if (string.IsNullOrWhiteSpace(cif)) return;

            var usuario = UsuarioService.BuscarPorCif(cif);

            if (usuario == null)
            {
                MessageBox.Show("No se encontró un usuario con ese CIF.",
                    "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el nuevo nombre:",
                "Actualizar usuario", usuario.Nombre).Trim();

            string nuevaPass = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la nueva contraseña:",
                "Actualizar usuario", usuario.Password).Trim();

            bool actualizado = UsuarioService.ActualizarUsuario(
                cif, nuevoNombre, nuevaPass);

            if (actualizado)
                MessageBox.Show("Usuario actualizado correctamente.",
                    "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cif = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el CIF del usuario que desea eliminar:",
                "Eliminar usuario", "").Trim();

            if (string.IsNullOrWhiteSpace(cif)) return;

            var usuario = UsuarioService.BuscarPorCif(cif);

            if (usuario == null)
            {
                MessageBox.Show("No se encontró un usuario con ese CIF.",
                    "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (usuario.Rol == "Admin")
            {
                MessageBox.Show(
                    "No puedes eliminar al Administrador.",
                    "EcoBIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirmar = MessageBox.Show(
                $"¿Seguro que deseas eliminar a: {usuario.Nombre} (CIF {usuario.CIF})?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes) return;

            bool eliminado = UsuarioService.EliminarUsuarioPorCif(cif);

            if (eliminado)
                MessageBox.Show("Usuario eliminado correctamente.",
                    "EcoBIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool EsAdmin()
        {
            return usuarioActual.Rol != null &&
                   usuarioActual.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EsAdmin())
            {
                MessageBox.Show(
                    "Solo el administrador puede acceder al módulo de reportes.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            this.Hide();
            new Reportes(usuarioActual).Show();
        }
    }
}
