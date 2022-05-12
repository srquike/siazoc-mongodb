using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Creditos
{
    public partial class FrmCreditos : Form
    {
        private readonly CreditoService _creditoServices;

        public FrmCreditos()
        {
            InitializeComponent();

            _creditoServices = new CreditoService();
        }

        private async void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmCrearCredito = new FrmCrearCredito();

            if (frmCrearCredito.ShowDialog() == DialogResult.OK)
            {
                LlenarDataGridViewCreditos(ref DgvCreditos, await _creditoServices.GetAllAsync());
            }
        }

        private async void FrmCreditos_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewCreditos(ref DgvCreditos, await _creditoServices.GetAllAsync());
        }

        private void LlenarDataGridViewCreditos(ref DataGridView gridView, List<Credito> creditos)
        {
            gridView.Rows.Clear();

            if (creditos.Count > 0 && creditos != null)
            {
                var socio = string.Empty;

                foreach (var credito in creditos)
                {
                    if (credito.Socio != null)
                    {
                        socio = credito.Socio.Nombre;
                    }

                    gridView.Rows.Add(false, credito.CreditoId, credito.Codigo, string.Format("{0:C2}", credito.Monto), string.Format("{0:P2}", credito.TasaInteres / 100), credito.Plazo, credito.FechaCreacion.Value.ToShortDateString(), socio);
                }

                gridView.ClearSelection();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DgvCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var creditoId = dataGrid.Rows[e.RowIndex].Cells["ColCreditoId"].Value.ToString();
                var codigo = dataGrid.Rows[e.RowIndex].Cells["ColCodigo"].Value.ToString();

                if (!string.IsNullOrEmpty(creditoId))
                {
                    if (e.ColumnIndex == 8)
                    {
                        var frmDetallesCredito = new FrmDetallesCredito(creditoId);
                        frmDetallesCredito.ShowDialog();
                    }
                    else if (e.ColumnIndex == 9)
                    {
                        var frmEditarCredito = new FrmEditarCredito(creditoId);

                        if (frmEditarCredito.ShowDialog() == DialogResult.OK)
                        {
                            LlenarDataGridViewCreditos(ref DgvCreditos, await _creditoServices.GetAllAsync());
                        }
                    }
                    else if (e.ColumnIndex == 10)
                    {
                        if (MessageBox.Show($"Esta seguro de querer eliminar el credito?", "Eliminar credito: Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                await _creditoServices.DeleteAsync(creditoId, codigo);
                                LlenarDataGridViewCreditos(ref DgvCreditos, await _creditoServices.GetAllAsync());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ocurrio un error al intentar eliminar al socio. {ex.Message}", "Eliminar credito: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}