using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datos
            Console.WriteLine("Ingrese el valor del ángulo d: ");
            double dgrad = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del ángulo b: ");
            double bgrad = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cateto y: ");
            double y = double.Parse(Console.ReadLine());

            //Calculos
            double e = (180 - dgrad - bgrad);
            double cgrad = (180 - e);
            double agrad = (180 - 90 - cgrad);
            double c = cgrad * (Math.PI / 180.0);
            double a = agrad * (Math.PI / 180.0);
            double z = ((y * Math.Sin(c)) / (Math.Sin(a)));

            //Salida
            Console.WriteLine("El valor del cateto z es: " + z);

        }
    }
}
