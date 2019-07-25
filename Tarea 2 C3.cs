using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_parte_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datos
            Console.WriteLine("Ingrese el valor de la hipotenusa w: ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del ángulo d: ");
            double dgrad = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cateto x: ");
            double x = double.Parse(Console.ReadLine());

            //Calculos
            double d = dgrad * (Math.PI / 180.0);
            double t = Math.Sqrt((x * x) + (w * w) - (2 * x * w) * Math.Cos(d));
            double c = Math.Asin((w * Math.Sin(d)) / t);
            double cgrad = c * (180.0 / Math.PI);
            double agrad = (180 - 90 - cgrad);
            double a = agrad * (Math.PI / 180.0);
            double z = (t * Math.Sin(c));
            double y = ((z * Math.Sin(a)) / Math.Sin(c));

            //Salida
            Console.WriteLine("El valor del cateto y es: " + y);

        }
    }
}
