using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Socios
{
    public partial class FrmDetallesSocio : Form
    {
        private readonly SocioService _socioServices;
        private readonly string _socioId;

        public FrmDetallesSocio(string socioId)
        {
            InitializeComponent();

            _socioServices = new SocioService();
            _socioId = socioId;
        }

        private async void LlenarControles()
        {
            var socio = await _socioServices.GetByIdAsync(_socioId);

            if (socio != null)
            {
                TxtNombre.Text = socio.Nombre;
                TxtDireccion.Text = socio.Direccion;
                TxtFechaNacimiento.Text = socio.FechaNacimiento.Value.ToShortDateString();
                MtbDui.Text = socio.Dui;
                TxtFechaIngreso.Text = socio.FechaIngreso.Value.ToShortDateString();
                TxtFechaRetiro.Text = socio.FechaRetiro.Value.ToShortDateString();
                TxtGenero.Text = socio.Genero;
                MtbCodigo.Text = socio.Codigo;
                MtbTelefono.Text = socio.Telefono;
                ChkHabilitado.Checked = socio.EsHabilitado;
                ChkRetirado.Checked = socio.EsRetirado;

                LlenarDataGridViewCreditos(ref DgvCreditos, socio.Creditos);
            }
        }

        private void LlenarDataGridViewCreditos(ref DataGridView dataGrid, ICollection<Credito> creditos)
        {
            if (creditos.Count > 0 && creditos != null)
            {
                int contador = 0;

                dataGrid.Rows.Clear();

                foreach (var credito in creditos)
                {
                    dataGrid.Rows.Add(++contador, credito.Codigo, credito.Monto, credito.FechaInicio.Value.ToShortDateString(), credito.Plazo, credito.TasaInteres);
                }

                dataGrid.ClearSelection();
            }
        }

        private void FrmDetallesSocio_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}