using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso_1.repaso
{
    public class ejercicio_1
    {
        public static void ejecutar()
        {
            int lv;
            string name;
            bool premium;

            Console.WriteLine("Ingrese su nombre:");
            name = Console.ReadLine();

            Console.WriteLine("Ingrese su nivel:");
            lv = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese si es premium (si/no):");
            string respuesta = Console.ReadLine().ToLower();
            premium = (respuesta == "si");

            Console.WriteLine($"Nombre: {name}, Nivel: {lv}, Premium: {(premium ? "Es Premium" : "No es Premium")}");
        }
    }
}   