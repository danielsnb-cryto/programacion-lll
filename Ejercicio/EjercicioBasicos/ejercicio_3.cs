using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso_1.repaso
{
    public class ejercicio_3
    {
        public static void ejercutar()
        {
            const int AFORO_MAXIMO = 50;
            int personasActuales = 0;

            Console.WriteLine("--- Control de Aforo: Discoteca ---");
            Console.WriteLine($"Capacidad máxima: {AFORO_MAXIMO} personas");
            Console.WriteLine("-----------------------------------");

            Console.Write("¿Cuántas personas desean ingresar?: ");
            int personasNuevas = Convert.ToInt32(Console.ReadLine());

            int totalProyectado = personasActuales + personasNuevas;

            if (totalProyectado <= AFORO_MAXIMO)
            {

                Console.WriteLine("\n¡Bienvenidos! Pueden ingresar. Disfruten la noche. ");
            }
            else
            {
                int personasQueDebenSalir = totalProyectado - AFORO_MAXIMO;

                Console.WriteLine("\nLo sentimos, el aforo está completo.");
                Console.WriteLine($"Para que este grupo pueda entrar, deben salir primero {personasQueDebenSalir} personas.");
                Console.WriteLine("Por favor, esperen en la fila.")
                   }
        }
    }
}

