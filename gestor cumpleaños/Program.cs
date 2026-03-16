using System;
using System.IO;

class Program
{
    static void Main()
    {
        string archivo = "cumpleaños.txt";

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Ingrese el nombre del amigo {i}:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/yyyy):");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Amigo amigo = new Amigo(nombre, fecha);

            int dias = amigo.CalcularDiasParaCumple();

            Console.WriteLine($"A {amigo.Nombre} le faltan {dias} días para su cumpleaños.");

            string linea = $"{amigo.Nombre} - {amigo.FechaNacimiento:dd/MM/yyyy}";

            File.AppendAllText(archivo, linea + Environment.NewLine);
        }

        Console.WriteLine("Datos guardados en cumpleaños.txt");
    }
}