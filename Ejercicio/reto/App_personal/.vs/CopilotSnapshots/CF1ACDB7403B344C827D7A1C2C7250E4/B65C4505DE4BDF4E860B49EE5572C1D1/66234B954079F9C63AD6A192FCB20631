using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace App_personal.clases
{
    internal class Datos
    {
        // 1. Inicialización del sistema (Llamar desde Program.cs)
        public static void InicializarSistema()
        {
            string carpetaPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".csv");
            if (!Directory.Exists(carpetaPath)) Directory.CreateDirectory(carpetaPath);

            VerificarYCrear("productos.csv", "Codigo;Nombre;Categoria;Precio;StockIni");
            VerificarYCrear("entradas.csv", "Fecha;Codigo;Cantidad;Observacion");
            VerificarYCrear("salidas.csv", "Fecha;Codigo;Cantidad;Observacion");
        }

        private static void VerificarYCrear(string archivo, string cabecera)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".csv", archivo);
            if (!File.Exists(ruta)) File.WriteAllText(ruta, cabecera + Environment.NewLine);
        }

        // 2. Lógica para PRODUCTOS
        public static void GuardarProducto(Producto p)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".csv", "productos.csv");
            string linea = $"{p.Codigo};{p.Nombre};{p.Categoria};{p.Precio};{p.StockInicial}";
            File.AppendAllText(ruta, linea + Environment.NewLine);
        }

        // 3. Lógica para MOVIMIENTOS (Entradas y Salidas)
        public static void RegistrarMovimiento(string archivo, Movimiento m)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".csv", archivo);
            string linea = $"{m.Fecha:dd/MM/yyyy};{m.Codigo};{m.Cantidad};{m.Observacion}";
            File.AppendAllText(ruta, linea + Environment.NewLine);
        }

        // 4. Lógica de Cálculo de Stock (La que pides en tu imagen de Salidas)
        public static int ObtenerStockActual(string codigoBuscado)
        {
            int inicial = 0;
            int entradas = 0;
            int salidas = 0;

            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".csv");

            // Leer Stock Inicial de productos.csv
            var productos = File.ReadAllLines(Path.Combine(carpeta, "productos.csv")).Skip(1);
            foreach (var line in productos)
            {
                var d = line.Split(';');
                if (d[0] == codigoBuscado) inicial = int.Parse(d[4]);
            }

            // Sumar Entradas
            var listaEntradas = File.ReadAllLines(Path.Combine(carpeta, "entradas.csv")).Skip(1);
            foreach (var line in listaEntradas)
            {
                var d = line.Split(';');
                if (d[1] == codigoBuscado) entradas += int.Parse(d[2]);
            }

            // Sumar Salidas
            var listaSalidas = File.ReadAllLines(Path.Combine(carpeta, "salidas.csv")).Skip(1);
            foreach (var line in listaSalidas)
            {
                var d = line.Split(';');
                if (d[1] == codigoBuscado) salidas += int.Parse(d[2]);
            }

            return inicial + entradas - salidas;
        }
    }
}