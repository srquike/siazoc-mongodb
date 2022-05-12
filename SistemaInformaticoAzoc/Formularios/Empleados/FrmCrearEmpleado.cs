using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Empleados
{
    public partial class FrmCrearEmpleado : Form
    {
        private readonly EmpleadoService _empleadoServices;
        private readonly CargoService _cargoServices;

        public FrmCrearEmpleado()
        {
            InitializeComponent();

            _empleadoServices = new EmpleadoService();
            _cargoServices = new CargoService();
        }

        private void LlenarComboBoxCargos(ref ComboBox comboBox, List<Cargo> cargos)
        {
            if (cargos != null && cargos.Count > 0)
            {
                cargos.Insert(0, new Cargo { CargoId = "", Nombre = "-- Seleccionar --" });
                comboBox.DataSource = cargos;
                comboBox.ValueMember = "CargoId";
                comboBox.DisplayMember = "Nombre";
            }
        }

        private async void FrmCrearEmpleado_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCargos(ref CmbCargos, await _cargoServices.GetAllAsync());
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = new Empleado
                {
                    Codigo = TxtCodigo.Text,
                    Direccion = TxtDireccion.Text,
                    Dui = TxtNumeroDui.Text,
                    FechaNacimiento = DtpFechaNacimiento.Value.ToLocalTime(),
                    Nombre = TxtNombre.Text,
                    Telefono = TxtNumeroTelefono.Text,
                    CargoId = CmbCargos.SelectedValue.ToString()
                };

                await _empleadoServices.CreateAsync(empleado);                

                DialogResult = MessageBox.Show($"El perfil del empleado [{empleado.Nombre.ToUpper()}]. Fue creado con exito.", "Crear nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar crear al empleado. {ex.Message}", "Crear nuevo empleado: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}