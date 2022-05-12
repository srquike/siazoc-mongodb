using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Empleados
{
    public partial class FrmEmpleados : Form
    {
        private readonly EmpleadoService _empleadoServices;

        public FrmEmpleados()
        {
            InitializeComponent();

            _empleadoServices = new EmpleadoService();
        }

        private async void BtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            var frmCrearEmpleado = new FrmCrearEmpleado();

            if (frmCrearEmpleado.ShowDialog() == DialogResult.OK)
            {
                LlenarDataGridViewEmpleados(ref DgvEmpleados, await _empleadoServices.GetAllAsync());
            }
        }

        private void LlenarDataGridViewEmpleados(ref DataGridView gridView, List<Empleado> empleados)
        {
            if (empleados.Count > 0 && empleados != null)
            {
                gridView.Rows.Clear();

                foreach (var empleado in empleados)
                {

                    var cargoNombre = string.Empty;

                    if (empleado.Cargo != null)
                    {
                        cargoNombre = empleado.Cargo.Nombre;
                    }

                    gridView.Rows.Add(false, empleado.EmpleadoId, empleado.Nombre, empleado.Codigo, empleado.Dui, empleado.Telefono, cargoNombre);
                }

                gridView.ClearSelection();
            }
        }

        private async void FrmEmpleados_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewEmpleados(ref DgvEmpleados, await _empleadoServices.GetAllAsync());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;

            if (gridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var empleadoId = gridView.Rows[e.RowIndex].Cells["ColEmpleadoId"].Value.ToString();
                var empleadoNombre = gridView.Rows[e.RowIndex].Cells["ColNombre"].Value.ToString();

                if (!string.IsNullOrEmpty(empleadoId))
                {
                    if (e.ColumnIndex == 7)
                    {
                        var frmDetallesEmpleado = new FrmDetallesEmpleado(empleadoId);
                        frmDetallesEmpleado.ShowDialog();
                    }
                    else if (e.ColumnIndex == 8)
                    {
                        var frmEditarEmpleado = new FrmEditarEmpleado(empleadoId);

                        if (frmEditarEmpleado.ShowDialog() == DialogResult.OK)
                        {
                            LlenarDataGridViewEmpleados(ref DgvEmpleados, await _empleadoServices.GetAllAsync());
                        }
                    }
                    else if (e.ColumnIndex == 9)
                    {
                        if (MessageBox.Show($"Esta seguro de querer eliminar al empleado [{empleadoNombre.ToUpper()}]?", "Eliminar empleado: Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                await _empleadoServices.DeleteAsync(empleadoId);
                                LlenarDataGridViewEmpleados(ref DgvEmpleados, await _empleadoServices.GetAllAsync());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ocurrio un error al intentar eliminar al empleado [{empleadoNombre.ToUpper()}]. {ex.Message}", "Eliminar empleado: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}