using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;
using System;

namespace ConcesionarioVehiculos.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(int id, string marca, string modelo, int año, decimal precioBase,
                    TipoCombustible combustible, EstadoVehiculo estado,
                    int puertas, bool aire)
            : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            NumeroPuertas = puertas;
            TieneAireAcondicionado = aire;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (TieneAireAcondicionado ? 2000 : 0);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.05m;
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("=== FACTURA AUTO ===");
            MostrarEspecificaciones();
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine($"Comisión vendedor: {CalcularComisionVendedor()}");
        }
    }
}za