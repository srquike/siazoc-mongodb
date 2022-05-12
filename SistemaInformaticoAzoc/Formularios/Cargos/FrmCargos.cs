using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SistemaInformaticoAzoc.Formularios.Cargos
{
    public partial class FrmCargos : Form
    {
        private readonly CargoService _cargoServices;

        public FrmCargos()
        {
            InitializeComponent();

            _cargoServices = new CargoService();
        }

        private void LlenarDataGridViewCargos(ref DataGridView gridView, List<Cargo> cargos)
        {
            if (cargos.Count > 0 && cargos != null)
            {
                gridView.Rows.Clear();

                foreach (var cargo in cargos)
                {
                    var cantidadEmpleados = 0;

                    if (cargo.Empleados.Count > 0 && cargo.Empleados != null)
                    {
                        cantidadEmpleados = cargo.Empleados.Count;
                    }

                    gridView.Rows.Add(false, cargo.CargoId, cargo.Nombre, cargo.Descripcion, cantidadEmpleados);
                }

                gridView.ClearSelection();
            }
        }

        private async void BtnNuevoCargo_Click(object sender, EventArgs e)
        {
            var frmCrearCargo = new FrmCrearCargo();

            if (frmCrearCargo.ShowDialog() == DialogResult.OK)
            {
                LlenarDataGridViewCargos(ref DgvCargos, await _cargoServices.GetAllAsync());
            }
        }

        private async void FrmCargos_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewCargos(ref DgvCargos, await _cargoServices.GetAllAsync());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;

            if (gridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var cargoId = gridView.Rows[e.RowIndex].Cells["ColCargoId"].Value.ToString();
                var cargoNombre = gridView.Rows[e.RowIndex].Cells["ColNombre"].Value.ToString();

                if (!string.IsNullOrEmpty(cargoId))
                {
                    if (e.ColumnIndex == 5)
                    {
                        var frmDetallesCargo = new FrmDetallesCargo(cargoId);
                        frmDetallesCargo.ShowDialog();
                    }
                    else if (e.ColumnIndex == 6)
                    {
                        var frmEditarCargo = new FrmEditarCargo(cargoId);

                        if (frmEditarCargo.ShowDialog() == DialogResult.OK)
                        {
                            LlenarDataGridViewCargos(ref DgvCargos, await _cargoServices.GetAllAsync());
                        }
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        if (MessageBox.Show($"Esta seguro de querer eliminar el cargo [{cargoNombre.ToUpper()}]?", "Eliminar cargo: Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                await _cargoServices.DeleteAsync(cargoId);
                                LlenarDataGridViewCargos(ref DgvCargos, await _cargoServices.GetAllAsync());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ocurrio un error al intentar eliminar el cargo [{cargoNombre.ToUpper()}]. {ex.Message}", "Eliminar cargo: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}