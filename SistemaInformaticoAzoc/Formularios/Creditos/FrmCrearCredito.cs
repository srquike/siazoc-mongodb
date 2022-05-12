using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Creditos
{
    public partial class FrmCrearCredito : Form
    {
        private readonly CreditoService _creditoServices;
        private readonly SocioService _socioServices;
        private readonly CuotaService _cuotaServices;
        private readonly DeduccionService _deduccionServices;
        private List<Cuota> _cuotas;
        private List<Deduccion> _deducciones;

        public FrmCrearCredito()
        {
            InitializeComponent();

            _creditoServices = new CreditoService();
            _socioServices = new SocioService();
            _cuotaServices = new CuotaService();
            _deduccionServices = new DeduccionService();
            _cuotas = new List<Cuota>();
            _deducciones = new List<Deduccion>();
        }

        private async void FrmCrearCredito_Load(object sender, EventArgs e)
        {
            CmbTiposPlazo.SelectedIndex = 0;
            LlenarComboBoxSocios(ref CmbSocios, await _socioServices.GetAllAsync());
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

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var credito = new Credito
                {
                    Codigo = TxtCodigo.Text,
                    EsAprobado = ChkAprobar.Checked,
                    FechaCreacion = DateTime.Today.ToLocalTime(),
                    FechaInicio = DtpFechaInicio.Value.ToLocalTime(),
                    Monto = NudMonto.Value,
                    Plazo = (int)NudPlazo.Value,
                    TasaInteres = NudInteres.Value,
                    SocioId = CmbSocios.SelectedValue.ToString()
                };

                await _creditoServices.CreateAsync(credito);
                await _cuotaServices.CreateManyAsync(_cuotas);
                await _deduccionServices.CreateManyAsync(_deducciones);

                DialogResult = MessageBox.Show($"El crédito [{credito.Codigo}]. Fue creado con exito.", "Crear nuevo crédito: Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar crear el crédito. {ex.Message}", "Crear nuevo crédito: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var deducciones = ObtenerDeducciones();
            TxtTotalDeducciones.Text = string.Format("{0:C2}", deducciones);
        }
    }
}