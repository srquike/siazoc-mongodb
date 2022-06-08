using System;
using System.Windows.Forms;
using SistemaInformaticoAzoc.Servicios;
using SistemaInformaticoAzoc.Modelos;
using System.Collections.Generic;

namespace SistemaInformaticoAzoc.Formularios
{
    public partial class FrmCrearUsuario : Form
    {
        private readonly UsuarioService _usuarioServices;
        private readonly EmpleadoService _empleadoServices;

        public FrmCrearUsuario()
        {
            InitializeComponent();

            _usuarioServices = new UsuarioService();
            _empleadoServices = new EmpleadoService();
        }

        private void LlenarComboBoxEmpleados(ref ComboBox comboBox, List<Empleado> empleados)
        {
            if (empleados != null)
            {
                if (empleados.Count > 0)
                {
                    empleados.Insert(0, new Empleado { EmpleadoId = "", Nombre = "-- Seleccionar -- " });
                    comboBox.DataSource = empleados;
                    comboBox.ValueMember = "EmpleadoId";
                    comboBox.DisplayMember = "Nombre";
                }
            }
        }

        private async void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            LlenarComboBoxEmpleados(ref CmbEmpleados, await _empleadoServices.GetAllAsync());
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario
                {
                    Nombre = TxtNombre.Text,
                    Clave = TxtClave.Text,
                    EsActivado = ChkActivarUsuario.Checked,
                    EsAdministrador = ChkAdministrador.Checked,
                    EmpleadoId = CmbEmpleados.SelectedValue.ToString()
                };

                await _usuarioServices.CreateAsync(usuario);

                MessageBox.Show($"El perfil del usuario [{usuario.Nombre.ToUpper()}]. Fue creado con exito.", "Crear usuario: Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al intentar crear al usuario. {ex.Message}", "Crear usuario: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkVerClaves_CheckedChanged(object sender, EventArgs e)
        {
            TxtClave.UseSystemPasswordChar = !ChkVerClaves.Checked;
            TxtRepetirClave.UseSystemPasswordChar = !ChkVerClaves.Checked;
        }
    }
}