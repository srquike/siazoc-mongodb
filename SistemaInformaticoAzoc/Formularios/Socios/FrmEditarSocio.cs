using SistemaInformaticoAzoc.Servicios;
using SistemaInformaticoAzoc.Modelos;
using System;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Socios
{
    public partial class FrmEditarSocio : Form
    {
        private readonly SocioService _socioServices;
        private readonly string _socioId;

        public FrmEditarSocio(string socioId)
        {
            InitializeComponent();

            _socioServices = new SocioService();
            _socioId = socioId;
        }

        private void FrmEditarSocio_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }

        private async void LlenarControles()
        {
            var socio = await _socioServices.GetByIdAsync(_socioId);

            if (socio != null)
            {
                TxtNombre.Text = socio.Nombre;
                TxtDireccion.Text = socio.Direccion;
                DtpFechaNacimiento.Value = socio.FechaNacimiento.Value;
                MtbDui.Text = socio.Dui;
                DtpFechaIngreso.Value = socio.FechaIngreso.Value;
                DtpFechaRetiro.Value = socio.FechaRetiro.Value;
                CmbGeneros.SelectedItem = socio.Genero;
                MtbCodigo.Text = socio.Codigo;
                MtbTelefono.Text = socio.Telefono;
                ChkHabilitado.Checked = socio.EsHabilitado;
                ChkRetirado.Checked = socio.EsRetirado;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
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
                    FechaIngreso = DtpFechaIngreso.Value,
                    FechaRetiro = DtpFechaRetiro.Value,
                    FechaNacimiento = DtpFechaNacimiento.Value,
                    Genero = CmbGeneros.SelectedItem.ToString(),
                    Nombre = TxtNombre.Text,
                    SocioId = _socioId,
                    Telefono = MtbTelefono.Text
                };

                await _socioServices.UpdateAsync(socio);

                DialogResult = MessageBox.Show($"El perfil del socio [{socio.Nombre.ToUpper()}]. Fue modificado con exito.", "Editar socio: Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar modificar al socio. {ex.Message}", "Editar socio: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}