using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio.EjercicioBasicos
{
    public class ejercicio_5
    {
        public static void ejecutar()
        {
       
            Console.WriteLine("-- Simulador de Semáforo Inteligente --");

            Console.Write("\nIngrese el color actual del semáforo (Verde, Amarillo, Rojo): ");
            string entrada = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("\n-------------------------------------------");
            switch (entrada)
            {
                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sigue adelante. verde");
                    break;

                case "amarillo":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Prepárate para frenar. amarillo");
                    break;

                case "rojo":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Detente! rojo");
                    break;

                default:
                    Console.WriteLine("Color no reconocido. Por favor, intente de nuevo.");
                    break;
            }

            Console.ResetColor();
            Console.WriteLine("-------------------------------------------");
        }
    }
}
