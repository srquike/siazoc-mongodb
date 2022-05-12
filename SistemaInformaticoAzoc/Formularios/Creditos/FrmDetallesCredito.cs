using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Creditos
{
    public partial class FrmDetallesCredito : Form
    {
        private readonly CreditoService _creditoServices;
        private readonly string _creditoId;

        public FrmDetallesCredito(string creditoId)
        {
            InitializeComponent();

            _creditoServices = new CreditoService();
            _creditoId = creditoId;
        }

        private void FrmDetallesCredito_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }

        private async void LlenarControles()
        {
            var credito = await _creditoServices.GetByIdAsync(_creditoId);

            if (credito != null)
            {
                var deducciones = ObtenerDeducciones(credito.Deducciones);

                TxtCodigo.Text = credito.Codigo;
                TxtPlazo.Text = $"{credito.Plazo} mes(es)";
                TxtInteres.Text = $"{credito.TasaInteres} %";
                ChkAprobar.Checked = credito.EsAprobado;
                ChkCancelado.Checked = credito.EsCancelado;
                TxtMonto.Text = string.Format("{0:C2}", credito.Monto);
                TxtFechaInicio.Text = credito.FechaInicio.Value.ToShortDateString();
                TxtFechaCreacion.Text = credito.FechaCreacion.Value.ToShortDateString();
                TxtLiquidoRecibir.Text = string.Format("{0:C2}", credito.Monto - deducciones);
                TxtDeudaAdquirida.Text = string.Format("{0:C2}", credito.Monto);
                TxtDeudaTotal.Text = string.Format("{0:C2}", credito.Monto);
                TxtTotalDeducciones.Text = string.Format("{0:C2}", deducciones);

                if (credito.Socio != null)
                {
                    TxtSocio.Text = credito.Socio.Nombre;
                }

                ObtenerCuota(credito.Plazo, credito.Monto, credito.TasaInteres);
                LlenarDataGridViewCuotas(ref DgvCuotas, credito.Cuotas);
            }
        }

        private void ObtenerCuota(decimal plazo, decimal monto, decimal interes)
        {
            var capital = monto / plazo;
            var interesCuota = monto * (interes / 100);
            var montoCuota = capital + interesCuota;


            TxtMontoCuota.Text = string.Format("{0:C2}", montoCuota);
            TxtCapitalCuota.Text = string.Format("{0:C2}", capital);
            TxtInteresCuota.Text = string.Format("{0:C2}", interes);
        }

        private void LlenarDataGridViewCuotas(ref DataGridView dataGrid, ICollection<Cuota> cuotas)
        {
            dataGrid.Rows.Clear();

            if (cuotas.Count > 0 && cuotas != null)
            {
                var contador = 0;
                var pagadas = 0;

                foreach (var cuota in cuotas)
                {
                    dataGrid.Rows.Add(++contador, string.Format("{0:C2}", cuota.Monto), cuota.FechaVencimiento.Value.ToShortDateString(), cuota.EsPagada, cuota.FechaPago);

                    if (cuota.EsPagada)
                    {
                        pagadas++;
                    }
                }

                TxtCantidadCuotas.Text = cuotas.Count.ToString();
                TxtCuotasCanceladas.Text = pagadas.ToString();
                TxtCuotasPendientes.Text = (cuotas.Count - pagadas).ToString();

                dataGrid.ClearSelection();
            }
        }

        private decimal ObtenerDeducciones(ICollection<Deduccion> deducciones)
        {
            decimal total = 0;

            if (deducciones.Count > 0 && deducciones != null)
            {
                foreach (var control in GbxDeducciones.Controls)
                {
                    if (control is TextBox txt)
                    {
                        foreach (var deduccion in deducciones)
                        {
                            if (txt.Tag.ToString().Equals(deduccion.Nombre))
                            {
                                txt.Text = string.Format("{0:C2}", deduccion.Monto);
                                total += deduccion.Monto;
                            }
                        }
                    }
                }
            }

            return total;
        }
    }
}