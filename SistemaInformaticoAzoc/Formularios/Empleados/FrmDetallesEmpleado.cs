using SistemaInformaticoAzoc.Servicios;
using System;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Empleados
{
    public partial class FrmDetallesEmpleado : Form
    {
        private readonly EmpleadoService _empleadoServices;
        private readonly string _empleadoId;

        public FrmDetallesEmpleado(string empleadoId)
        {
            InitializeComponent();

            _empleadoServices = new EmpleadoService();
            _empleadoId = empleadoId;
        }

        private void FrmDetallesEmpleado_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }

        private async void LlenarControles()
        {
            var empleado = await _empleadoServices.GetByIdAsync(_empleadoId);

            if (empleado != null)
            {
                if (empleado.Cargo != null)
                {
                    TxtCargo.Text = empleado.Cargo.Nombre;
                }

                TxtNombre.Text = empleado.Nombre;
                TxtCodigo.Text = empleado.Codigo;
                TxtFechaNacimiento.Text = empleado.FechaNacimiento.ToShortDateString();
                TxtDireccion.Text = empleado.Direccion;
                TxtNumeroDui.Text = empleado.Dui;
                TxtNumeroTelefono.Text = empleado.Telefono;
            }
        }
    }
}