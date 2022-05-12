using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Cargos
{
    public partial class FrmCrearCargo : Form
    {
        private readonly CargoService _cargoServices;

        public FrmCrearCargo()
        {
            InitializeComponent();

            _cargoServices = new CargoService();
        }

        private async void BtnCrearCargo_Click(object sender, EventArgs e)
        {
            try
            {
                var cargo = new Cargo
                {
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text
                };

                await _cargoServices.CreateAsync(cargo);
                
                DialogResult = MessageBox.Show($"El perfil del cargo [{cargo.Nombre.ToUpper()}]. Fue creado con exito.", "Crear nuevo cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar crear el cargo. {ex.Message}", "Crear nuevo cargo: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}