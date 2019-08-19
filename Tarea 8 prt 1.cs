using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, contador = 0, contador2 = 0, vidas = 3;
            string arrojar = "s";


            while (arrojar == "s" && vidas > 0)
            {
                Console.WriteLine("Arrojar dados (s/n): ");
                arrojar = Console.ReadLine();
                dado = aleatorio.Next(1, 7);
                Console.Write("Dado = " + dado);

                total += dado;
                Console.Write("Total = " + total);

                Console.Write("vidas =" + vidas);

                if (dado == 1)
                {
                    contador += 1;
                    if (contador % 2 == 0 && vidas > 0)
                    {
                        vidas -= 1;
                        total -= 10;
                    }
                }

                if (dado == 6) contador2 += 1;
                if (dado != 6 && contador2 > 0) contador2 -= 1;
                if (contador2 == 2) vidas += 1;

                if (vidas > 3) vidas = 3;
                if (vidas == 0) Console.WriteLine("No tienes más vidas, has perdido");

                Console.WriteLine("Gracias por jugar");
                Console.WriteLine("Su total fue de " + total + "puntos");
            }
        }
    }
}
