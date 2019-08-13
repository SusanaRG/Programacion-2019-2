using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, contador = 0, contador3 = 0;
            double contador2 = 0;
            string arrojar = "s";

            dado1 = aleatorio.Next(1, 7);
            dado2 = aleatorio.Next(1, 7);
            Console.Write("Dado 1: " + dado1);
            Console.Write("Dado 2: " + dado2);
            total = dado1 + dado2;
            Console.Write("total: " + total);
        

            while (arrojar == "s" && total < 100)
            {

                Console.WriteLine(" ¿arrojar dados? (s/n)");
                arrojar = Console.ReadLine();
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                if (dado1 == dado2) contador += 1;
                if (dado1 != dado2 && contador > 0) contador -= 1;
                if (contador == 3)
                {
                    Console.WriteLine("has ganado");
                    break;
                }


                if (arrojar == "s")
                {
                    Console.Write("Dado 1: " + dado1);
                    Console.Write("Dado 2: " + dado2);
                    total += dado1 + dado2;
                    Console.Write("total: " + total);
              
                }
                if (dado1 + dado2 > 6) contador2 += 1;
                if (arrojar == "s") contador3 += 1;
                if (dado1 == 1 && dado2 == 1)
                {
                    Console.Write("El juego ha terminado, has perdido.");
                    total = 0;
                    break;

                }


            } Console.WriteLine("su total de puntos es: " + total);
            if (total >= 100) Console.WriteLine("Felicidades, ha ganado. Su total de puntos es: " + total);
            double prob = (contador2 / contador3) * 100;
            Console.WriteLine("porcentaje de tiros > a 6 es: " + prob);

        }
    }
}
