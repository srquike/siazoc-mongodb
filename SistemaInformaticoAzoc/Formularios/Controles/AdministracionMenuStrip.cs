using SistemaInformaticoAzoc.Formularios.Empleados;
using SistemaInformaticoAzoc.Formularios.Cargos;
using SistemaInformaticoAzoc.Formularios.Usuarios;
using System;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Controles
{
    public partial class AdministracionMenuStrip : UserControl
    {
        private readonly FrmPrincipal _mdiParent;
        private FrmUsuarios _frmUsuarios;
        private FrmEmpleados _frmEmpleados;
        private FrmCargos _frmCargos;


        public AdministracionMenuStrip(FrmPrincipal mdiParent)
        {
            InitializeComponent();

            _mdiParent = mdiParent;
            _frmUsuarios = null;
            _frmCargos = null;
            _frmEmpleados = null;
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            if (_frmUsuarios == null)
            {
                _frmUsuarios = new FrmUsuarios();
                _frmUsuarios.MdiParent = _mdiParent;
                _frmUsuarios.FormClosed += new FormClosedEventHandler(FrmUsuarios_Closed);
                _frmUsuarios.Show();
            }
            else
            {
                _frmUsuarios.Activate();
            }

            Visible = false;
        }

        private void FrmUsuarios_Closed(object sender, EventArgs e)
        {
            _frmUsuarios = null;
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            if (_frmEmpleados == null)
            {
                _frmEmpleados = new FrmEmpleados();
                _frmEmpleados.MdiParent = _mdiParent;
                _frmEmpleados.FormClosed += new FormClosedEventHandler(FrmEmpleados_Closed);
                _frmEmpleados.Show();
            }
            else
            {
                _frmEmpleados.Activate();
            }

            Visible = false;
        }

        private void FrmEmpleados_Closed(object sender, EventArgs e)
        {
            _frmEmpleados = null;
        }

        private void BtnCargos_Click(object sender, EventArgs e)
        {
            if (_frmCargos == null)
            {
                _frmCargos = new FrmCargos();
                _frmCargos.MdiParent = _mdiParent;
                _frmCargos.FormClosed += new FormClosedEventHandler(FrmCargos_Closed);
                _frmCargos.Show();
            }
            else
            {
                _frmCargos.Activate();
            }

            Visible = false;
        }

        private void FrmCargos_Closed(object sender, EventArgs e)
        {
            _frmCargos = null;
        }
    }
}
