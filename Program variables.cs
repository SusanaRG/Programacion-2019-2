using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class EjemploIF2
    {
        static void Main()
        {
            // Variables
            Console.WriteLine("ingrese el coeficiente A: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el coeficiente B: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el coeficiente C: ");
            double C = double.Parse(Console.ReadLine());

            // Operaciones


            double disc = Math.Pow(B, 2) - 4 * A * C;


            // Condicionales.

            if (disc == 0)
            {
                double X1 = (-B ) / 2 * A;
                Console.WriteLine(X1);
                Console.WriteLine("Solo existe un posible resultado y es único");

            } else if (disc > 0)
            {
                double X1 = (-B - Math.Sqrt(disc)) / 2 * A;
                double X2 = (-B + Math.Sqrt(disc)) / 2 * A;
                Console.WriteLine(X1);
                Console.WriteLine(X2);
                Console.WriteLine("Existen dos posibles soluciones");
            }
            else {
                Console.WriteLine("Esa wea no da un número real");
}        

        }
    }
}
