using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_parte_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datos 
            Console.WriteLine("Ingrese el valor de la hipotenusa w: ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la hipotenusa t: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del angulo c: ");
            double c = double.Parse(Console.ReadLine());

            // Calculos 
            double egrad = (180 - c);
            double e = egrad * (Math.PI / 180.0);
            double d = Math.Asin((t * Math.Sin(e)) / w);
            double dgrad = d * (180.0 / Math.PI);
            double bgrad = (180 - egrad - dgrad);
            double b = bgrad * (Math.PI / 180.0);
            double x = ((w * Math.Sin(b)) / Math.Sin(e));

            //Salida
            Console.WriteLine("El valor del cateto x es: " + x);


        }
    }
}
