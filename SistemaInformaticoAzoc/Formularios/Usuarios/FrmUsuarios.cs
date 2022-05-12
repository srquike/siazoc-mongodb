using SistemaInformaticoAzoc.Modelos;
using SistemaInformaticoAzoc.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc.Formularios.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioService _usuarioServices;

        public FrmUsuarios()
        {
            InitializeComponent();

            _usuarioServices = new UsuarioService();
        }

        private void LlenarDataGridViewUsuarios(ref DataGridView gridView, List<Usuario> usuarios)
        {
            if (usuarios.Count > 0 && usuarios != null)
            {
                gridView.Rows.Clear();

                foreach (var usuario in usuarios)
                {
                    var nombreEmpleado = string.Empty;

                    if (usuario.Empleado != null)
                    {
                        nombreEmpleado = usuario.Empleado.Nombre;
                    }

                    gridView.Rows.Add(false, usuario.UsuarioId, usuario.Nombre, nombreEmpleado, usuario.EsAdministrador, usuario.EsActivado);
                }

                gridView.ClearSelection();
            }
        }

        private async void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            var frmCrearUsuario = new FrmCrearUsuario();

            if (frmCrearUsuario.ShowDialog() == DialogResult.OK)
            {
                LlenarDataGridViewUsuarios(ref DgvUsuarios, await _usuarioServices.GetAllAsync());
            }
        }

        private async void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewUsuarios(ref DgvUsuarios, await _usuarioServices.GetAllAsync());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridView = (DataGridView)sender;

            if (gridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var usuarioId = gridView.Rows[e.RowIndex].Cells["ColUsuarioId"].Value.ToString();
                var usuarioNombre = gridView.Rows[e.RowIndex].Cells["ColNombre"].Value.ToString();

                if (!string.IsNullOrEmpty(usuarioId))
                {
                    if (e.ColumnIndex == 6)
                    {
                        var frmEditarUsuario = new FrmEditarUsuario(usuarioId);

                        if (frmEditarUsuario.ShowDialog() == DialogResult.OK)
                        {
                            LlenarDataGridViewUsuarios(ref DgvUsuarios, await _usuarioServices.GetAllAsync());
                        }
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        if (MessageBox.Show($"Esta seguro de querer eliminar al usuario [{usuarioNombre.ToUpper()}]?", "Eliminar usuario: Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                        {
                            try
                            {
                                await _usuarioServices.DeleteAsync(usuarioId);
                                LlenarDataGridViewUsuarios(ref DgvUsuarios, await _usuarioServices.GetAllAsync());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ocurrio un error al intentar eliminar al usuario [{usuarioNombre.ToUpper()}]. {ex.Message}", "Eliminar usuario: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}