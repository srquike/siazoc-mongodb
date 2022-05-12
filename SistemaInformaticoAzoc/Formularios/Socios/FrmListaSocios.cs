using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Socios
{
    public partial class FrmListaSocios : Form
    {
        private readonly SocioService _socioServices;

        public FrmListaSocios()
        {
            InitializeComponent();

            _socioServices = new SocioService();
        }

        private async void FrmListaSocios_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewSocios(ref DgvSocios, await _socioServices.GetAllAsync());
        }

        private void LlenarDataGridViewSocios(ref DataGridView dataGrid, List<Socio> socios)
        {
            dataGrid.Rows.Clear();

            if (socios.Count > 0 && socios != null)
            {    
                foreach (var socio in socios)
                {
                    dataGrid.Rows.Add(false, socio.SocioId, socio.Nombre, socio.Codigo, socio.Dui, socio.Telefono, socio.FechaNacimiento);
                }

                dataGrid.ClearSelection();
            }
        }

        private async void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmNuevoSocio = new FrmCrearSocio();

            if (frmNuevoSocio.ShowDialog() == DialogResult.OK)
            {
                LlenarDataGridViewSocios(ref DgvSocios, await _socioServices.GetAllAsync());
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var socioId = dataGrid.Rows[e.RowIndex].Cells["ColSocioId"].Value.ToString();
                var socioNombre = dataGrid.Rows[e.RowIndex].Cells["ColNombre"].Value.ToString();

                if (!string.IsNullOrEmpty(socioId))
                {
                    if (e.ColumnIndex == 7)
                    {
                        var frmDetallesSocio = new FrmDetallesSocio(socioId);
                        frmDetallesSocio.Show();
                    }
                    else if (e.ColumnIndex == 8)
                    {
                        var frmEditarSocio = new FrmEditarSocio(socioId);

                        if (frmEditarSocio.ShowDialog() == DialogResult.OK)
                        {
                            LlenarDataGridViewSocios(ref DgvSocios, await _socioServices.GetAllAsync());
                        }
                    }
                    else if (e.ColumnIndex == 9)
                    {
                        if (MessageBox.Show($"Esta seguro de querer eliminar al socio [{socioNombre.ToUpper()}]?", "Eliminar socio: Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                await _socioServices.DeleteAsync(socioId);
                                LlenarDataGridViewSocios(ref DgvSocios, await _socioServices.GetAllAsync());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ocurrio un error al intentar eliminar al socio [{socioNombre.ToUpper()}]. {ex.Message}", "Eliminar socio: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}