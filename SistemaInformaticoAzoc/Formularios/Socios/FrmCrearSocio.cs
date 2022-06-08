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

namespace SistemaInformaticoAzoc.Formularios.Socios
{
    public partial class FrmCrearSocio : Form
    {
        private readonly SocioService _socioServices;

        public FrmCrearSocio()
        {
            InitializeComponent();

            _socioServices = new SocioService();
        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var socio = new Socio
                {
                    Codigo = MtbCodigo.Text,
                    Direccion = TxtDireccion.Text,
                    Dui = MtbDui.Text,
                    EsHabilitado = ChkHabilitado.Checked,
                    EsRetirado = ChkRetirado.Checked,
                    FechaIngreso = DtpFechaIngreso.Value.ToLocalTime(),
                    FechaNacimiento = DtpFechaNacimiento.Value.ToLocalTime(),
                    FechaRetiro = DtpFechaRetiro.Value.ToLocalTime(),
                    Genero = CmbGeneros.SelectedItem.ToString(),
                    Nombre = TxtNombre.Text,
                    Telefono = MtbTelefono.Text
                };

                await _socioServices.CreateAsync(socio);

                DialogResult = MessageBox.Show($"El perfil del socio [{socio.Nombre.ToUpper()}]. Fue creado con exito.", "Crear nuevo socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar crear al socio. {ex.Message}", "Crear nuevo socio: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCrearSocio_Load(object sender, EventArgs e)
        {
            CmbGeneros.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
