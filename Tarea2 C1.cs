using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datos
            Console.WriteLine("Ingrese el valor del angulo b: ");
            double bgrad = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cateto z: ");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cateto y: ");
            double y = double.Parse(Console.ReadLine());

            //Calculos 
            double t = (Math.Sqrt (y * y + z * z));
            double b = bgrad * (Math.PI / 180.0);
            double r = (Math.Asin(z / t));
            double rgrad = r * (180.0 / Math.PI);
            double e = (180 - rgrad);
            double cgrad = (180 - bgrad - e);
            double c = cgrad * (Math.PI / 180.0);
            double x = ((t * Math.Sin(b)) / Math.Sin(c));

            //Salida
            Console.WriteLine("El valor del cateto x es: " + x);
        }
    }
}
