using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EjercicioIF
    {
        static void Main()
        {
            // Ingreso de variables
            Console.WriteLine("Ingrese su peso en KG: ");
            double P = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su altura en M: ");
            double A = double.Parse(Console.ReadLine());

            // Operaciones

            double IMC = P / (Math.Pow(A, 2));

            if (IMC < 18.5)
            {
                Console.WriteLine(IMC);
                Console.WriteLine("Puedes estar anorexico");
            }
            else if (18.5 <= IMC && IMC <= 24.99)
            {
                Console.WriteLine(IMC);
                Console.WriteLine("Hobre, ps qué te digo, tas bien");
            }
            else if (25 <= IMC && IMC <= 29.99)
            {
                Console.WriteLine(IMC);
                Console.WriteLine("Te pasaste de la raya wn");
            }
            else
            {
                Console.WriteLine(IMC);
                Console.WriteLine("Estas común, comúncachalote");
            }
        }
    }
}
