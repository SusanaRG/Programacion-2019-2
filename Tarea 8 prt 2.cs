using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_8_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int  dado1 = 0, total = 0, contador = 0, vidas = 3;
            string arrojar = "s";

            while(arrojar == "s" && vidas > 0)
            {
                Console.WriteLine("\n ¿Arrojar dados ? (s/n): ");
                arrojar = Console.ReadLine();
                if (arrojar != "s") break;
                dado1 = aleatorio.Next(1, 7);
                Console.Write("\n Dado = " + dado1);

                total += dado1;
                Console.Write("\n Total = " + total);

                Console.Write("\n vidas =" + vidas);

                if (arrojar == "s")
                {
                    contador += 1;
                    if (contador % 2 == 0 && vidas > 0) vidas -= 1;
                }

                if (vidas == 0)
                {
                    Console.WriteLine("No tienes más vidas, has perdido");
                    break;
                }

                if (arrojar == "s" && contador % 3 == 0)
                    {
                    int dado2 = aleatorio.Next(1, 7);
                    Console.Write("\n Dado2 = " + dado2);
                    total += dado2;
                    Console.Write("\n Total = " + total);
                    Console.Write("\n vidas =" + vidas);
                    
                    if (dado1 == dado2) vidas += 1;
                    }
                

                if (vidas > 3) vidas = 3;


            }
            Console.WriteLine("Gracias por jugar");
            Console.WriteLine("Su total fue de " + total + "puntos");
            Console.WriteLine("vidas" + vidas);
        }
    }
}
