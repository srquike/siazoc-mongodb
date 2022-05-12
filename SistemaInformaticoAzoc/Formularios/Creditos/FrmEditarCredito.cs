using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Creditos
{
    public partial class FrmEditarCredito : Form
    {
        private readonly CreditoService _creditoServices;
        private readonly SocioService _socioServices;
        private readonly CuotaService _cuotaServices;
        private readonly DeduccionService _deduccionServices;
        private List<Cuota> _cuotas;
        private List<Deduccion> _deducciones;
        private readonly string _creditoId;

        public FrmEditarCredito(string creditoId)
        {
            InitializeComponent();

            _creditoServices = new CreditoService();
            _socioServices = new SocioService();
            _cuotaServices = new CuotaService();
            _deduccionServices = new DeduccionService();
            _cuotas = new List<Cuota>();
            _deducciones = new List<Deduccion>();
            _creditoId = creditoId;
        }

        private void FrmEditarCredito_Load(object sender, EventArgs e)
        {
            CmbTiposPlazo.SelectedIndex = 0;
            LlenarControles();
        }

        private void LlenarComboBoxSocios(ref ComboBox comboBox, List<Socio> socios)
        {
            if (socios.Count > 0 && socios != null)
            {
                socios.Insert(0, new Socio { SocioId = "", Nombre = "-- Seleccionar --" });
                comboBox.DataSource = socios;
                comboBox.DisplayMember = "Nombre";
                comboBox.ValueMember = "SocioId";
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

            CrearCuotas(plazo, montoCuota);
        }

        private void CrearCuotas(decimal plazo, decimal monto)
        {
            var fecha = DateTime.Today.ToLocalTime();

            _cuotas.Clear();

            for (int i = 0; i < plazo; i++)
            {
                var cuota = new Cuota
                {
                    CreditoId = TxtCodigo.Text,
                    EsPagada = false,
                    FechaPago = string.Empty,
                    FechaVencimiento = fecha,
                    Monto = monto
                };

                fecha = fecha.AddMonths(1);

                _cuotas.Add(cuota);
            }
        }

        private async void LlenarControles()
        {
            var credito = await _creditoServices.GetByIdAsync(_creditoId);

            if (credito != null)
            {
                var deducciones = ObtenerDeducciones(credito.Deducciones);

                TxtCodigo.Text = credito.Codigo;
                NudPlazo.Value = credito.Plazo;
                NudInteres.Value = credito.TasaInteres;
                ChkAprobar.Checked = credito.EsAprobado;
                ChkCancelar.Checked = credito.EsCancelado;
                NudMonto.Value = credito.Monto;
                DtpFechaInicio.Value = credito.FechaInicio.Value;
                TxtLiquidoRecibir.Text = string.Format("{0:C2}", credito.Monto - deducciones);
                TxtDeudaAdquirida.Text = string.Format("{0:C2}", credito.Monto);
                TxtDeudaTotal.Text = string.Format("{0:C2}", credito.Monto);
                TxtTotalDeducciones.Text = string.Format("{0:C2}", deducciones);

                LlenarComboBoxSocios(ref CmbSocios, await _socioServices.GetAllAsync());

                if (credito.Socio != null)
                {
                    CmbSocios.SelectedValue = credito.Socio.SocioId;
                }

                ObtenerCuota(credito.Plazo, credito.Monto, credito.TasaInteres);
            }
        }

        private decimal ObtenerDeducciones(ICollection<Deduccion> deducciones)
        {
            decimal total = 0;

            if (deducciones.Count > 0 && deducciones != null)
            {
                foreach (var control in GbxDeducciones.Controls)
                {
                    if (control is NumericUpDown nud)
                    {
                        foreach (var deduccion in deducciones)
                        {
                            if (nud.Tag.ToString().Equals(deduccion.Nombre))
                            {
                                nud.Value = deduccion.Monto;
                                total += deduccion.Monto;
                            }
                        }
                    }
                }
            }

            return total;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var deducciones = ObtenerDeducciones();
            TxtTotalDeducciones.Text = string.Format("{0:C2}", deducciones);
        }

        private decimal ObtenerDeducciones()
        {
            decimal deducciones = 0;

            _deducciones.Clear();

            foreach (var control in GbxDeducciones.Controls)
            {
                if (control is NumericUpDown nup)
                {
                    deducciones += nup.Value;

                    var deduccion = new Deduccion
                    {
                        CreditoId = TxtCodigo.Text,
                        Monto = nup.Value,
                        Nombre = nup.Tag.ToString()
                    };

                    _deducciones.Add(deduccion);
                }
            }

            return deducciones;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            RealizarCalculos();
        }

        private void RealizarCalculos()
        {
            var monto = NudMonto.Value;
            var plazo = NudPlazo.Value;
            var interes = NudInteres.Value;
            ObtenerCuota(plazo, monto, interes);
            var deducciones = ObtenerDeducciones();

            TxtLiquidoRecibir.Text = string.Format("{0:C2}", monto - deducciones);
            TxtDeudaAdquirida.Text = string.Format("{0:C2}", monto);
            TxtDeudaTotal.Text = string.Format("{0:C2}", monto);

        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var credito = new Credito
                {
                    CreditoId = _creditoId,
                    Codigo = TxtCodigo.Text,
                    EsAprobado = ChkAprobar.Checked,
                    EsCancelado = ChkCancelar.Checked,
                    FechaCreacion = DateTime.Today.ToLocalTime(),
                    FechaInicio = DtpFechaInicio.Value.ToLocalTime(),
                    Monto = NudMonto.Value,
                    Plazo = (int)NudPlazo.Value,
                    TasaInteres = NudInteres.Value,
                    SocioId = CmbSocios.SelectedValue.ToString()
                };

                await _cuotaServices.DeleteManyAsync(credito.Codigo);
                await _deduccionServices.DeleteManyAsync(credito.Codigo);
                await _creditoServices.UpdateAsync(credito);
                await _cuotaServices.CreateManyAsync(_cuotas);
                await _deduccionServices.CreateManyAsync(_deducciones);

                DialogResult = MessageBox.Show($"El crédito [{credito.Codigo}]. Fue modificado con exito.", "Editar crédito: Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar modificar el crédito. {ex.Message}", "Editar crédito: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}