using SistemaInformaticoAzoc.Formularios.Creditos;
using SistemaInformaticoAzoc.Formularios.Socios;
using System;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Controles
{
    public partial class CreditosMenuStrip : UserControl
    {
        private readonly Form _mdiParent;
        private FrmCreditos _frmCreditos;
        private FrmListaSocios _frmListaSocios;

        public CreditosMenuStrip(Form mdiParent)
        {
            InitializeComponent();

            _mdiParent = mdiParent;
            _frmCreditos = null;
            _frmListaSocios = null;
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            if (_frmCreditos == null)
            {
                _frmCreditos = new FrmCreditos();
                _frmCreditos.MdiParent = _mdiParent;
                _frmCreditos.FormClosed += new FormClosedEventHandler(FrmCreditos_Closed);
                _frmCreditos.Show();
            }
            else
            {
                _frmCreditos.Activate();
            }

            Visible = false;
        }

        private void FrmCreditos_Closed(object sender, EventArgs e)
        {
            _frmCreditos = null;
        }

        private void BtnSocios_Click(object sender, EventArgs e)
        {
            if (_frmListaSocios == null)
            {
                _frmListaSocios = new FrmListaSocios();
                _frmListaSocios.MdiParent = _mdiParent;
                _frmListaSocios.FormClosed += new FormClosedEventHandler(FrmListaSocios_Closed);
                _frmListaSocios.Show();
            }
            else
            {
                _frmListaSocios.Activate();
            }

            Visible = false;
        }

        private void FrmListaSocios_Closed(object sender, EventArgs e)
        {
            _frmListaSocios = null;
        }
    }
}