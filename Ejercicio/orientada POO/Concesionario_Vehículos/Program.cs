using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;
using ConcesionarioVehiculos.Modelos;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IVendible> ventas = new List<IVendible>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== CONCESIONARIO ===");
            Console.WriteLine("1. Agregar Auto");
            Console.WriteLine("2. Agregar Motocicleta");
            Console.WriteLine("3. Agregar Camion");
            Console.WriteLine("4. Generar Facturas");
            Console.WriteLine("5. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();

                    Console.Write("Año: ");
                    int año = int.Parse(Console.ReadLine());

                    Console.Write("Precio Base: ");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    Console.Write("Numero de puertas: ");
                    int puertas = int.Parse(Console.ReadLine());

                    Console.Write("Tiene aire acondicionado (true/false): ");
                    bool aire = bool.Parse(Console.ReadLine());

                    Auto auto = new Auto(1, marca, modelo, año, precio,
                        TipoCombustible.Gasolina, EstadoVehiculo.Nuevo,
                        puertas, aire);

                    ventas.Add(auto);

                    Console.WriteLine("Auto agregado.");
                    break;

                case 2:

                    Console.Write("Marca: ");
                    string marcaM = Console.ReadLine();

                    Console.Write("Modelo: ");
                    string modeloM = Console.ReadLine();

                    Console.Write("Año: ");
                    int añoM = int.Parse(Console.ReadLine());

                    Console.Write("Precio Base: ");
                    decimal precioM = decimal.Parse(Console.ReadLine());

                    Console.Write("Cilindraje: ");
                    int cilindraje = int.Parse(Console.ReadLine());

                    Console.Write("Es deportiva (true/false): ");
                    bool deportiva = bool.Parse(Console.ReadLine());

                    Motocicleta moto = new Motocicleta(2, marcaM, modeloM, añoM, precioM,
                        TipoCombustible.Gasolina, EstadoVehiculo.Nuevo,
                        cilindraje, deportiva);

                    ventas.Add(moto);

                    Console.WriteLine("Motocicleta agregada.");
                    break;

                case 3:

                    Console.Write("Marca: ");
                    string marcaC = Console.ReadLine();

                    Console.Write("Modelo: ");
                    string modeloC = Console.ReadLine();

                    Console.Write("Año: ");
                    int añoC = int.Parse(Console.ReadLine());

                    Console.Write("Precio Base: ");
                    decimal precioC = decimal.Parse(Console.ReadLine());

                    Console.Write("Capacidad de carga: ");
                    decimal carga = decimal.Parse(Console.ReadLine());

                    Console.Write("Numero de ejes: ");
                    int ejes = int.Parse(Console.ReadLine());

                    Camion camion = new Camion(3, marcaC, modeloC, añoC, precioC,
                        TipoCombustible.Diesel, EstadoVehiculo.Nuevo,
                        carga, ejes);

                    ventas.Add(camion);

                    Console.WriteLine("Camión agregado.");
                    break;

                case 4:

                    foreach (var v in ventas)
                    {
                        v.GenerarFacturaVenta();
                        Console.WriteLine("---------------------");
                    }

                    break;

                case 5:
                    continuar = false;
                    break;
            }
        }
    }
}SSS
