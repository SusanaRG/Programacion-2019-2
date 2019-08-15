using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, dado2 = 0, contador1 = 0, total = 0, contador2 = 0, contador3 = 0;
            string arrojar = "";




            while (total < 100)
            {
                Console.WriteLine("¿Arrojar dados? (s/n)");
                arrojar = Console.ReadLine();
                if (arrojar != "s") break;
                dado = aleatorio.Next(1, 13);
                Console.Write(" dado: " + dado);
                total += dado;
                Console.Write(" total: " + total);
                if (arrojar == "s") contador1 += 1;

                Console.WriteLine("¿Arrojar dados? (s/n)");
                arrojar = Console.ReadLine();
                if (arrojar != "s") break;
                dado2 = aleatorio.Next(1, 13);
                Console.Write(" dado: " + dado2);
                total += dado2;
                Console.Write(" total: " + total);
                if (arrojar == "s") contador1 += 1;
                if (dado == 12 && dado2 == 10)
                {
                    Console.WriteLine(" Felicidades, has ganado");
                    break;
                }

                if (contador1 > 3 && dado % 2 == 1)
                {
                    Console.WriteLine("Has sido eliminado.");
                    total = 0;
                    break;
                }
                if (contador1 > 3 && dado2 % 2 == 1)
                {
                    Console.WriteLine("Has sido eliminado.");
                    total = 0;
                    break;
                }

            } Console.Write("\n total de puntos: " + total);

        }
    }
}
