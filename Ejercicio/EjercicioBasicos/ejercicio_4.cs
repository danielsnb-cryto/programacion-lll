using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.EjercicioBasicos
{
    public class ejercicio_4
    {
        public static void ejercutar()
        {
     
            Console.WriteLine("--- Generador de Correos Corporativos ---");

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor, ingresa tu apellido: ");
            string apellido = Console.ReadLine();

            string nombreLimpio = nombre.Trim().ToLower();
            string apellidoLimpio = apellido.Trim().ToLower();

            string correoElectronico = $"{nombreLimpio}.{apellidoLimpio}@empresa.com";
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("¡Correo generado con éxito!");
            Console.WriteLine($"Su dirección es: {correoElectronico}");
            Console.WriteLine("-----------------------------------------");
        }
    }
}

