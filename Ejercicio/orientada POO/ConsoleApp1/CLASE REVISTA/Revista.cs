using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using System;

namespace BibliotecaDigital.Modelos
{
    public class Revista : MaterialBiblioteca, IPrestable
    {
        public int NumeroEdicion { get; set; }
        public string Periodicidad { get; set; }

        public Revista(int id, string titulo, string autor, int año,
                       TipoCategoria categoria, int edicion, string periodicidad)
            : base(id, titulo, autor, año, categoria)
        {
            NumeroEdicion = edicion;
            Periodicidad = periodicidad;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine("Préstamo de REVISTA registrado.");
            Console.WriteLine($"Fecha devolución: {CalcularFechaDevolucion()}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 500;
        }
    }
}