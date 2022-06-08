using System;
using System.Windows.Forms;
using SistemaInformaticoAzoc.Modelos;

namespace SistemaInformaticoAzoc.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public Usuario _usuario;

        public FrmPrincipal()
        {
            administracionMenuStrip = new Controles.AdministracionMenuStrip(this);
            creditosMenuStrip = new Controles.CreditosMenuStrip(this);
            InitializeComponent();
        }

        #region Eventos del formulario principal
        private void BtnAdministrar_Click(object sender, EventArgs e)
        {
            if (_usuario.EsAdministrador)
            {
                creditosMenuStrip.Visible = false;
                administracionMenuStrip.Visible = !administracionMenuStrip.Visible;
            }
            else
            {
                MessageBox.Show($"El módulo de Administración solo esta disponible para los usuarios Administradores", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            administracionMenuStrip.Visible = false;
            creditosMenuStrip.Visible = !creditosMenuStrip.Visible;
        }
        

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro de querer cerrar la sesión?", "SIAZOC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Retry;
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (_usuario.Empleado != null)
            {
                TxtNombre.Text = _usuario.Empleado.Nombre;
            }
            else
            {
                TxtNombre.Text = _usuario.Nombre;
            }
        }
    }
}