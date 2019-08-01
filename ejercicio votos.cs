using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            //datos 
            Console.WriteLine("Ingrese el numero de votos por el partido 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos por el partido 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de habitantes: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la poblacion mayor de edad: ");
            int p = int.Parse(Console.ReadLine());

            //calculos
            double pmayoredad = (n * p) / 100;
            int votantes = (a + b + blancos + anulados);
            double abstencion = (pmayoredad - votantes);

            bool A = anulados < 0.3 * (a + b);
            bool B = a + b > blancos;
            bool C = abstencion < votantes;

            //salida
            Console.WriteLine("Total de votantes: " + votantes);
            Console.WriteLine("Abstención: " + abstencion);

            if (((A || B) && C) && a > b)
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                Console.WriteLine("El ganador es el partido 1");
            }
            else if (((A || B) && C) && b > a)
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                Console.WriteLine("El ganador es el partido 2");
            }
            else
            {
                Console.WriteLine("Las votaciones deben repetirse");
            }

        }
    }
}
