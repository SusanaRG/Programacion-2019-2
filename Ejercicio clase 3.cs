using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //datos
            Console.WriteLine("Digite el primer valor: ");
            int b0 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo valor: ");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tercer valor: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el cuarto valor: ");
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el quinto valor: ");
            int b4 = int.Parse(Console.ReadLine());

            //calculos
            double total = ((b0 * Math.Pow(2, 4)) + (b1 * Math.Pow(2, 3)) + (b2 * Math.Pow(2, 2)) + (b3 * Math.Pow(2, 1)) + (b4 * Math.Pow(2, 0)));

            //salida 
            Console.WriteLine("El total es: " + total);

        }
    }
}
