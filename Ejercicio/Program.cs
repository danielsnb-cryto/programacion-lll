using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio.EjercicioBasicos;


namespace Ejercicio.EjercicioBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("====== MENÚ DE EJERCICIOS ======");
                Console.WriteLine("1. Calculadora de Propina (Clase)");
                Console.WriteLine("2. Calculadora de Propina (Interactiva)");
                Console.WriteLine("3. Control de Aforo Discoteca");
                Console.WriteLine("4. Generador de Correos Corporativos");
                Console.WriteLine("5. Simulador de Semáforo Inteligente");
                Console.WriteLine("6. Salir");
                Console.WriteLine("================================");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("=== EJERCICIO 1 ===");

                        Console.Write("Ingrese total de la cuenta: ");
                        double total = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese porcentaje de propina: ");
                        int porcentaje = Convert.ToInt32(Console.ReadLine());

                        CalculadoraPropina calc = new CalculadoraPropina(total, porcentaje);
                        calc.CalcularYMostrar();
                        break;

                    case 2:
                        Console.WriteLine("=== EJERCICIO 2 ===");
                        ejercicio_2.ejecutar();
                        break;

                    case 3:
                        Console.WriteLine("=== EJERCICIO 3 ===");
                        ejercicio_3.ejercutar();
                        break;

                    case 4:
                        Console.WriteLine("=== EJERCICIO 4 ===");
                        ejercicio_4.ejercutar();
                        break;

                    case 5:
                        Console.WriteLine("=== EJERCICIO 5 ===");
                        ejercicio_5.ejecutar();
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 6);
        }
    }
}
