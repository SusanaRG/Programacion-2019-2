using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea6
{
    class Tarea6
    {
        static void Main()
        {
            Console.WriteLine("Hola, vamos a jugar BlackJack");
            Random Aleatoria1 = new Random();
            Random Aleatoria2 = new Random();
            Random Aleatoria3 = new Random();
            int Carta1 = 0, Carta2 = 0, Carta3 = 0, total = 0; 
            string Continuar = "s";
            


            Carta1 = Aleatoria1.Next(1,11);
            Carta2 = Aleatoria2.Next(1, 11);
            total = Carta1 + Carta2;
            Console.Write(" Carta 1 = " + Carta1);
            Console.Write(" Carta 2 = " + Carta2);
            Console.Write(" Puntos totales = " + total);

            while (total < 21 && Continuar == "s") {
                Console.WriteLine(" ¿Desea tomar otra carta? (s/n): ");
                Continuar = Console.ReadLine();
                Carta3 = Aleatoria3.Next(1, 11);


                if (Continuar == "s")
                {                    
                    Console.WriteLine("El valor de la carta 3 es: " + Carta3);
                    total += Carta3;
                    Console.WriteLine("su total de puntos es: " + total);
                }
                
                if (total > 21) 
                {
                    Console.WriteLine("su valor ha superado 21 puntos, queda eliminado");
                }
            } 
                Console.WriteLine("¡Gracias por participar! :D");
            Console.WriteLine("Sus puntos totales fueron: " + total + "puntos");




        }
    }
}
