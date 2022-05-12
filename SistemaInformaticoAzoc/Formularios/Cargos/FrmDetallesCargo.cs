using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;

namespace SistemaInformaticoAzoc.Formularios.Cargos
{
    public partial class FrmDetallesCargo : Form
    {
        private readonly CargoService _cargosServices;
        private readonly string _cargoId;

        public FrmDetallesCargo(string cargoId)
        {
            InitializeComponent();

            _cargosServices = new CargoService();
            _cargoId = cargoId;
        }

        private void FrmDetallesCargo_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }

        private void LlenarDataGridViewEmpleados(ref DataGridView dataGrid, ICollection<Empleado> empleados)
        {
            if (empleados.Count > 0 && empleados != null)
            {
                dataGrid.Rows.Clear();

                var contador = 0;

                foreach (var empleado in empleados)
                {
                    dataGrid.Rows.Add(++contador, empleado.Nombre);
                }

                dataGrid.ClearSelection();
            }
        }

        private async void LlenarControles()
        {
            var cargo = await _cargosServices.GetByIdAsync(_cargoId);

            if (cargo != null)
            {
                TxtNombre.Text = cargo.Nombre;
                TxtDescripcion.Text = cargo.Descripcion;

                LlenarDataGridViewEmpleados(ref DgvEmpleados, cargo.Empleados);
            }
        }
    }
}
