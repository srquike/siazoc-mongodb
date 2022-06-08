using SistemaInformaticoAzoc.Formularios;
using SistemaInformaticoAzoc.Formularios.Sistema;
using System;
using System.Windows.Forms;

namespace SistemaInformaticoAzoc
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var frmInicioSesion = new FrmInicioSesion();
            var frmPrincipal = new FrmPrincipal(frmInicioSesion.usuario);

            if (frmInicioSesion.ShowDialog() == DialogResult.OK)
            {
                Application.Run(frmPrincipal);

                if (frmPrincipal.DialogResult == DialogResult.Retry)
                {
                    Application.Restart();
                }
            }           
        }
    }
}