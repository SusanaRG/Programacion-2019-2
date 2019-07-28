using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datos
            Console.WriteLine("Ingrese su salario mensual: ");
            double s = double.Parse(Console.ReadLine());

            //operaciones
            double smmlv = 828.116;

            if (s < (2 * smmlv))
            {
                Console.WriteLine("Usdted tiene acceso a la Tarifa A");
            }
            else if ((2 * smmlv) < s && s < (4 * smmlv))
            {
                Console.WriteLine("Usdte tiene acceso a la Tarifa B");
            } 
            else
            {
                Console.WriteLine("Usdted tiene acceso a la Tarifa c");
            }
        }
    }
}
