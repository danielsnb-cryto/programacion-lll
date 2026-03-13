using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso_1.repaso
{

    internal class ejercicio_2
    {
        public static void ejecutar()
        {
            Console.WriteLine("GRACIAS POR VISITAR EL RESTAURANTE SCH");

            Console.Write("Ingrese el total de la cuenta: ");
            string entradaCuenta = Console.ReadLine();
            double totalCuenta = Convert.ToDouble(entradaCuenta);

            Console.WriteLine("¿Desea dejar propina? (SI o NO)");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "SI")
            {
                Console.Write("¿Cuanto porcentaje? (10, 15 o 20): ");
                double porcentaje = Convert.ToDouble(Console.ReadLine());

                double propina = (totalCuenta * porcentaje) / 100;
                double totalFinal = totalCuenta + propina;

                Console.WriteLine("Propina: " + propina);
                if (totalFinal > 100000)
                {
                    Console.WriteLine("\n¡Muchas gracias por su generosidad! Su aporte marca la diferencia.");
                }
                Console.WriteLine("Total a pagar: " + totalFinal);
            }
            else
            {
                Console.WriteLine("Gracias por visitarnos. Total a pagar: " + totalCuenta);
            }
        }
    }
}



