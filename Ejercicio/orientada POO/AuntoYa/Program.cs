using System;
using System.Runtime.Remoting;
namespace AuntoYa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el valor del vehículo: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("ingrese el interés mensual (%): ");
            double interes = double.Parse(Console.ReadLine()) / 100;

            Console.Write("ingrese el número de cuotas: ");
            int cuotas = int.Parse(Console.ReadLine());

            double cuota = valor * interes / (1 - Math.Pow(1 + interes, -cuotas));

            double saldo = valor;
            double totalintereses = 0;
            double totalpagado = 0;

            Console.WriteLine("\nmes \t fecha \t capital \t interes \t saldo");
            DateTime fecha = DateTime.Now;

            for (int i = 1; i <= cuotas; i++)
            {
                double interesmes = saldo * interes;
                double capital = cuota - interesmes;
                saldo = saldo - capital;

                DateTime fechadepago = fecha.AddMonths(i);

                totalintereses += interesmes;
                totalpagado += cuota;

                Console.WriteLine(i + "\t" +
                      fechadepago.ToString("yyyy-MM-dd") + "\t" +
                      capital.ToString("F2") + "\t\t" +
                      interesmes.ToString("F2") + "\t\t" +
                      saldo.ToString("F2"));
            }

            Console.WriteLine("\nTotal pagado: " + totalpagado.ToString("F2"));
            Console.WriteLine("Total intereses: " + totalintereses.ToString("F2"));

        }
    }

}
