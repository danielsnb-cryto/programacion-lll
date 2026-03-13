using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.EjercicioBasicos
{
    public class CalculadoraPropina
    {
        public double TotalCuenta;
        public int PorcentajePropina;

        public CalculadoraPropina(double total, int porcentaje)
        {
            TotalCuenta = total;
            PorcentajePropina = porcentaje;
        }

        public void CalcularYMostrar()
        {
            double valorPropina = TotalCuenta * (PorcentajePropina / 100.0);
            double totalFinal = TotalCuenta + valorPropina;

            Console.WriteLine("\n====== RESUMEN DE CUENTA ======");
            Console.WriteLine("Subtotal: $" + TotalCuenta);
            Console.WriteLine("Propina (" + PorcentajePropina + "%): $ " + valorPropina);
            Console.WriteLine("Total a pagar: $" + totalFinal);

            if (totalFinal > 100000)
            {
                Console.WriteLine("¡Muchas gracias por su generosidad! Su contribución es muy valiosa.");
            }
            Console.WriteLine("============================\n");
        }
    }
}
