using ECOBIN;
using ECOBIN.Servicios;
using ECOBIN.Ventanas_Adicionales;
using System;
using System.Windows.Forms;
using ECOBIN.Modelos;

namespace ECOBIN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            mtbPass.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void tbCif_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limitar a 8 dígitos exactos
            if (tbCif.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string cif = tbCif.Text.Trim();
            string nombre = tbNombre.Text.Trim();
            string password = mtbPass.Text.Trim();

            if (tbCif.Text.Length != 8)
            {
                MessageBox.Show("El CIF debe tener 8 dígitos.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cif) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Complete todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. ¿Ya existe un usuario con ese CIF?
            var usuarioExistente = UsuarioService.BuscarPorCif(cif);

            if (usuarioExistente == null)
            {
                // NO existe: lo registramos como usuario común
                var nuevo = UsuarioService.RegistrarNuevo(cif, nombre, password);

                if (nuevo == null)
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Usuario registrado correctamente. ¡Bienvenido!",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AbrirMenu(nuevo);
            }
            else
            {
                // SÍ existe: validamos contraseña
                if (usuarioExistente.Password != password)
                {
                    MessageBox.Show("Contraseña incorrecta para este CIF.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar también el nombre, excepto para el admin
                if (!usuarioExistente.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase) &&
                    !usuarioExistente.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El nombre no coincide con el usuario registrado.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AbrirMenu(usuarioExistente);
            }
        }

        private void AbrirMenu(Usuario usuario)
        {
            // Si en el futuro creas un MenuOpcionesAdmin, aquí lo cambias.
            // Por ahora ambos roles usan el mismo menú.
            if (usuario.Rol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                // Podrías mostrar un mensaje solo para saber que entró como admin
                // MessageBox.Show("Has ingresado como administrador.", "EcoBIN");
            }

            MenuOpciones menu = new MenuOpciones(usuario);
            menu.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            mtbPass.UseSystemPasswordChar = !chkMostrarPass.Checked;
        }
    }
}
