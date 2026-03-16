using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using BibliotecaDigital.Modelos;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IPrestable> prestamos = new List<IPrestable>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== BIBLIOTECA DIGITAL ===");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Agregar Revista");
            Console.WriteLine("3. Agregar AudioLibro");
            Console.WriteLine("4. Generar comprobantes de préstamo");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Write("ID: ");
                    int idLibro = int.Parse(Console.ReadLine());

                    Console.Write("Título: ");
                    string tituloLibro = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autorLibro = Console.ReadLine();

                    Console.Write("Año de publicación: ");
                    int añoLibro = int.Parse(Console.ReadLine());

                    Console.WriteLine("Categoría:");
                    foreach (var cat in Enum.GetValues(typeof(TipoCategoria)))
                        Console.WriteLine($"{(int)cat} - {cat}");

                    TipoCategoria categoriaLibro = (TipoCategoria)int.Parse(Console.ReadLine());

                    Console.Write("Número de páginas: ");
                    int paginas = int.Parse(Console.ReadLine());

                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine();

                    Libro libro = new Libro(idLibro, tituloLibro, autorLibro, añoLibro, categoriaLibro, paginas, isbn);
                    prestamos.Add(libro);

                    Console.WriteLine("Libro agregado correctamente.");
                    break;

                case 2:

                    Console.Write("ID: ");
                    int idRevista = int.Parse(Console.ReadLine());

                    Console.Write("Título: ");
                    string tituloRevista = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autorRevista = Console.ReadLine();

                    Console.Write("Año de publicación: ");
                    int añoRevista = int.Parse(Console.ReadLine());

                    Console.WriteLine("Categoría:");
                    foreach (var cat in Enum.GetValues(typeof(TipoCategoria)))
                        Console.WriteLine($"{(int)cat} - {cat}");

                    TipoCategoria categoriaRevista = (TipoCategoria)int.Parse(Console.ReadLine());

                    Console.Write("Número de edición: ");
                    int edicion = int.Parse(Console.ReadLine());

                    Console.Write("Periodicidad: ");
                    string periodicidad = Console.ReadLine();

                    Revista revista = new Revista(idRevista, tituloRevista, autorRevista, añoRevista, categoriaRevista, edicion, periodicidad);
                    prestamos.Add(revista);

                    Console.WriteLine("Revista agregada correctamente.");
                    break;

                case 3:

                    Console.Write("ID: ");
                    int idAudio = int.Parse(Console.ReadLine());

                    Console.Write("Título: ");
                    string tituloAudio = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autorAudio = Console.ReadLine();

                    Console.Write("Año de publicación: ");
                    int añoAudio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Categoría:");
                    foreach (var cat in Enum.GetValues(typeof(TipoCategoria)))
                        Console.WriteLine($"{(int)cat} - {cat}");

                    TipoCategoria categoriaAudio = (TipoCategoria)int.Parse(Console.ReadLine());

                    Console.Write("Duración en horas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.Write("Narrador: ");
                    string narrador = Console.ReadLine();

                    AudioLibro audio = new AudioLibro(
                        idAudio,
                        tituloAudio,
                        autorAudio,
                        añoAudio,
                        categoriaAudio,
                        TimeSpan.FromHours(horas),
                        narrador
                    );

                    prestamos.Add(audio);

                    Console.WriteLine("AudioLibro agregado correctamente.");
                    break;

                case 4:

                    Console.WriteLine("\n=== COMPROBANTES DE PRÉSTAMO ===");

                    foreach (var item in prestamos)
                    {
                        item.GenerarComprobantePrestramo();
                        Console.WriteLine("----------------------");
                    }

                    break;

                case 5:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
