using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //datos
            Console.WriteLine("Ingrese valor del cateto y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor del cateto z:");
            double z = double.Parse(Console.ReadLine());

            //calculo de valores 
            double t = (Math.Sqrt ((y * y) + (z * z)));
            double arad = (Math.Asin(y / t));
            double a = arad * (180.0 / Math.PI);
            double c = (90 - a);

            //salida
            Console.WriteLine("La hipotenusa es:" + t);
            Console.WriteLine("El ángulo a es:" + a);
            Console.WriteLine("El ángulo c es:" + c);

        }
    }
}
