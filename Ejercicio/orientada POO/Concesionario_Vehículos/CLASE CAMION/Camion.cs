using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;
using System;

namespace ConcesionarioVehiculos.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(int id, string marca, string modelo, int año, decimal precioBase,
                      TipoCombustible combustible, EstadoVehiculo estado,
                      decimal carga, int ejes)
            : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            CapacidadCarga = carga;
            NumeroEjes = ejes;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.06m;
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("=== FACTURA CAMIÓN ===");
            MostrarEspecificaciones();
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine($"Comisión vendedor: {CalcularComisionVendedor()}");
        }
    }
}