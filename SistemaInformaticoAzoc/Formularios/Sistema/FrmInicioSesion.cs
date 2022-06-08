using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInformaticoAzoc.Servicios;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Sistema
{
    public partial class FrmInicioSesion : Form
    {
        private readonly UsuarioService usarioService;
        public FrmInicioSesion()
        {
            InitializeComponent(); 
             usarioService = new UsuarioService();

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            var nombre=TxtNombre.Text;
            var clave=TxtClave.Text;
            DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
