using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInformaticoAzoc.Servicios;
using SistemaInformaticoAzoc.Modelos;

namespace SistemaInformaticoAzoc.Formularios.Cargos
{
    public partial class FrmEditarCargo : Form
    {
        private readonly CargoService _cargosServices;
        private readonly string _cargoId;

        public FrmEditarCargo(string cargoId)
        {
            InitializeComponent();

            _cargosServices = new CargoService();
            _cargoId = cargoId;
        }

        private void FrmEditarCargo_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }

        private async void LlenarControles()
        {
            var cargo = await _cargosServices.GetByIdAsync(_cargoId);

            if (cargo != null)
            {
                TxtNombre.Text = cargo.Nombre;
                TxtDescripcion.Text = cargo.Descripcion;
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var cargo = new Cargo
                {
                    CargoId = _cargoId,
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text
                };

                await _cargosServices.UpdateAsync(cargo);                

                DialogResult = MessageBox.Show($"El perfil del cargo [{cargo.Nombre.ToUpper()}]. Fue modificado con exito.", "Editar cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar modificar el cargo. {ex.Message}", "Editar cargo: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
