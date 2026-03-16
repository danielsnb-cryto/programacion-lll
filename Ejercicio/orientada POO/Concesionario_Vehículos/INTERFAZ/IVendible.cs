namespace ConcesionarioVehiculos.Interfaces
{
    public interface IVendible
    {
        decimal CalcularPrecioFinal();
        void GenerarFacturaVenta();
        decimal CalcularComisionVendedor();
    }
}