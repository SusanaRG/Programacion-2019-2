using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_parte_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datos
            Console.WriteLine("Ingrese valor del ángulo c: ");
            double cgrados = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor del cateto z: ");
            double z = double.Parse(Console.ReadLine());

            //Calculos
            double c = cgrados * (Math.PI / 180.0);
            double a = (90 - cgrados);
            double y = z / (Math.Asin(c));
            double t = (Math.Sqrt((z * z) + (y * y)));

            //salida 
            Console.WriteLine("La hipotenusa es:" + t);
            Console.WriteLine("El cateto y es:" + y);
            Console.WriteLine("El ángulo a es:" + a);
        }
    }
}
