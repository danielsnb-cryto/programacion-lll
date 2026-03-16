using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using System;

namespace BibliotecaDigital.Modelos
{
    public class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public string ISBN { get; set; }

        public Libro(int id, string titulo, string autor, int año, TipoCategoria categoria,
                     int paginas, string isbn)
            : base(id, titulo, autor, año, categoria)
        {
            NumeroPaginas = paginas;
            ISBN = isbn;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(15);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("Préstamo de LIBRO registrado.");
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 1000;
        }
    }
}
