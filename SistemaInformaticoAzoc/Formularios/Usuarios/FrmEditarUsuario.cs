using SistemaInformaticoAzoc.Servicios;
using SistemaInformaticoAzoc.Modelos;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaInformaticoAzoc.Formularios.Usuarios
{
    public partial class FrmEditarUsuario : Form
    {
        private readonly UsuarioService _usuarioServices;
        private readonly EmpleadoService _empleadoServices;
        private readonly string _usuarioId;

        public FrmEditarUsuario(string usuarioId)
        {
            InitializeComponent();

            _usuarioServices = new UsuarioService();
            _empleadoServices = new EmpleadoService();
            _usuarioId = usuarioId;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            LlenarControles();
        }

        private void LlenarComboBoxEmpleados(ref ComboBox comboBox, List<Empleado> empleados)
        {
            if (empleados != null)
            {
                if (empleados.Count > 0)
                {
                    empleados.Insert(0, new Empleado { EmpleadoId = "", Nombre = "-- Seleccionar --" });
                    comboBox.DataSource = empleados;
                    comboBox.ValueMember = "EmpleadoId";
                    comboBox.DisplayMember = "Nombre";
                }
            }
        }

        private async void LlenarControles()
        {
            var usuario = await _usuarioServices.GetByIdAsync(_usuarioId);

            if (usuario != null)
            {
                LlenarComboBoxEmpleados(ref CmbEmpleados, await _empleadoServices.GetAllAsync());

                if (usuario.Empleado != null)
                {
                    CmbEmpleados.SelectedValue = usuario.Empleado.EmpleadoId;
                }
                else
                {
                    CmbEmpleados.SelectedIndex = 0;
                }

                TxtNombre.Text = usuario.Nombre;
                ChkAdministrador.Checked = usuario.EsAdministrador;
                ChkActivarUsuario.Checked = usuario.EsActivado;
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
                var usuario = new Usuario
                {
                    UsuarioId = _usuarioId,
                    Nombre = TxtNombre.Text,
                    Clave = TxtClave.Text,
                    EsActivado = ChkActivarUsuario.Checked,
                    EsAdministrador = ChkAdministrador.Checked,
                    EmpleadoId = CmbEmpleados.SelectedValue.ToString()
                };

                await _usuarioServices.UpdateAsync(usuario);

                MessageBox.Show($"El perfil del usuario [{usuario.Nombre.ToUpper()}]. Fue modificado con exito.", "Editar usuario: Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar modificar al usuario. {ex.Message}", "Editar usuario: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}