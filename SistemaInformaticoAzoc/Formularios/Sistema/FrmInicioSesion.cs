using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Sistema
{
    public partial class FrmInicioSesion : Form
    {
        private readonly UsuarioService _usuarioService;

        public Usuario usuarioLogeado;

        public FrmInicioSesion()
        {
            InitializeComponent();

            _usuarioService = new UsuarioService();
        }

        private async void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            var nombre = TxtNombre.Text;
            var clave = TxtClave.Text.Trim();
            var usuario = await _usuarioService.GetByNameAsync(nombre);

            if (usuario != null)
            {
                if (clave.Equals(usuario.Clave))
                {
                    usuarioLogeado = usuario;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show($"La contraseña para el usuario [{usuario.Nombre.ToUpper()}] no es correcta.", "Iniciar sesión: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"El nombre de usuario [{nombre.ToUpper()}] no existe.", "Iniciar sesión: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkVerClave_CheckedChanged(object sender, EventArgs e)
        {
            TxtClave.UseSystemPasswordChar = !ChkVerClave.Checked;
        }
    }
}