using System;
using System.Windows.Forms;
// Importamos el namespace donde están tus clases de datos
using App_personal.clases;

namespace App_personal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {

                Datos.InicializarSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al iniciar la base de datos: " + ex.Message);
            }

            Application.Run(new Menu());
        }
    }
}