using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hola, vamos a jugar BlackJack");
            Console.Write("\n Ingrese el numero de jugadores (min 2-max 5): ");
            int i = int.Parse(Console.ReadLine());
            int j = 0, w = 0;
            int[] puntaje = new int[i];


            while (i < 2 || i > 5)
            {
                Console.Write("¡ERROR! ingrese un numero valido de jugadores (min 2-max 5)");
                i = int.Parse(Console.ReadLine());
            }
            
            for(j = 0; j < i; j++ )
            {
                Console.Write("\n Bienvenido jugador: " + (j + 1));
                Random Aleatorio = new Random();
                string Continuar = "s";
                int carta1 = 0, total = 0;


                while (total < 21 && Continuar == "s")
                {
                   
                    carta1 = Aleatorio.Next(1, 11);
                    total += carta1;
 
                    if (total > 21)
                    {
                        Console.WriteLine("\n su valor ha superado 21 puntos, queda eliminado");
                        total = 0;
                        break;
                    }
                    Console.Write(" \n Carta = " + carta1);
                    Console.Write("\n Puntos totales = " + total);
                    Console.WriteLine(" \n ¿Desea tomar otra carta? (s/n): ");
                    Continuar = Console.ReadLine();
                    puntaje[j] = total;

                }

                Console.WriteLine("\n ¡Gracias por participar! :D");

            }

            int mayor = 0;
            int jugador = 0;
            while(w < j)
            {
                if(puntaje[w] > mayor)
                {
                    mayor = puntaje[w];
                    jugador = w + 1;
                  
                }
                w++;
            }
            Console.Write("\n el jugador con el mayor puntaje es: " + jugador);

            jugador -= 1;
            puntaje[jugador] = 0;
            w = 0;
            mayor = 0;

            while (w < j)
            {
                if (puntaje[w] > mayor)
                {
                    mayor = puntaje[w];
                    jugador = w + 1;

                }
                w++;
            }
            Console.Write("\n el jugador con segundo el mayor puntaje es: " + jugador);

            Console.Read();
        }
    }
}
