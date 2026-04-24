using System;
using System.IO;
using System.Windows.Forms;

namespace App_personal.clases
{
    internal static class ArchivoHelper
    {
        private static string CarpetaPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".csv");

        public static void InicializarDirectorio()
        {
            try
            {
                if (!Directory.Exists(CarpetaPath)) Directory.CreateDirectory(CarpetaPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear carpeta: " + ex.Message);
            }
        }

        public static string ObtenerRuta(string nombreArchivo)
        {
            return Path.Combine(CarpetaPath, nombreArchivo);
        }

        public static void EscribirLinea(string nombreArchivo, string contenido)
        {
            string ruta = ObtenerRuta(nombreArchivo);
            File.AppendAllText(ruta, contenido + Environment.NewLine);
        }
    }
}