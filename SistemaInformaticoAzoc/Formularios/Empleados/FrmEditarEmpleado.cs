using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Empleados
{
    public partial class FrmEditarEmpleado : Form
    {
        private readonly EmpleadoService _empleadoServices;
        private readonly CargoService _cargoService;
        private readonly string _empleadoId;

        public FrmEditarEmpleado(string empleadoId)
        {
            InitializeComponent();

            _empleadoServices = new EmpleadoService();
            _cargoService = new CargoService();
            _empleadoId = empleadoId;
        }

        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            LlenarControles();
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

        private async void LlenarControles()
        {
            var empleado = await _empleadoServices.GetByIdAsync(_empleadoId);

            if (empleado != null)
            {
                LlenarComboBoxCargos(ref CmbCargos, await _cargoService.GetAllAsync());

                if (empleado.Cargo != null)
                {
                    CmbCargos.SelectedValue = empleado.Cargo.CargoId;
                }
                else
                {
                    CmbCargos.SelectedIndex = 0;
                }

                TxtNombre.Text = empleado.Nombre;
                TxtCodigo.Text = empleado.Codigo;
                DtpFechaNacimiento.Value = empleado.FechaNacimiento;
                TxtDireccion.Text = empleado.Direccion;
                TxtNumeroDui.Text = empleado.Dui;
                TxtNumeroTelefono.Text = empleado.Telefono;
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = new Empleado
                {
                    EmpleadoId = _empleadoId,
                    Codigo = TxtCodigo.Text,
                    Direccion = TxtDireccion.Text,
                    Dui = TxtNumeroDui.Text,
                    FechaNacimiento = DtpFechaNacimiento.Value.ToLocalTime(),
                    Nombre = TxtNombre.Text,
                    Telefono = TxtNumeroTelefono.Text,
                    CargoId = CmbCargos.SelectedValue.ToString()
                };

                await _empleadoServices.UpdateAsync(empleado);

                ;

                DialogResult = MessageBox.Show($"El perfil del empleado [{empleado.Nombre.ToUpper()}]. Fue modificado con exito.", "Editar empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar modificar al empleado. {ex.Message}", "Editar empleado: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}