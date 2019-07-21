using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos
            Console.WriteLine("Ingrese valor de t: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor de a: ");
            double agrados = double.Parse(Console.ReadLine());

            //Calculos
            double a = agrados * (Math.PI / 180.0);
            double c = (90 - agrados);
            double z = t * (Math.Acos(a));
            double y = (Math.Sqrt((t * t) - (z * z)));
           
            //salida 
            Console.WriteLine("El cateto z es:" + z);
            Console.WriteLine("El cateto y es:" + y);
            Console.WriteLine("El ángulo c es:" + c);
        }
    }
}
