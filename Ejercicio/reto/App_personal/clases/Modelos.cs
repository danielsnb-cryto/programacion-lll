using System;

namespace App_personal.clases
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int StockInicial { get; set; }
    }

    public class Movimiento
    {
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}