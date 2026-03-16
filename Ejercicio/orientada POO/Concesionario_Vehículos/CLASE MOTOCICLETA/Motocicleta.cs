using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;
using System;

namespace ConcesionarioVehiculos.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Motocicleta(int id, string marca, string modelo, int año, decimal precioBase,
                           TipoCombustible combustible, EstadoVehiculo estado,
                           int cilindraje, bool deportiva)
            : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            Cilindraje = cilindraje;
            EsDeportiva = deportiva;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (EsDeportiva ? Cilindraje * 10 : 0);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.04m;
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("=== FACTURA MOTOCICLETA ===");
            MostrarEspecificaciones();
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine($"Comisión vendedor: {CalcularComisionVendedor()}");
        }
    }
}