using System;

namespace App_personal.clases
{
    // Representa un producto en tu inventario
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int StockInicial { get; set; }
    }

    // Representa una entrada o salida de mercancía
    public class Movimiento
    {
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}