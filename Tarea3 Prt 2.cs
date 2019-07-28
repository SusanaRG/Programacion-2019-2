using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datos 
            Console.WriteLine("Ingrese su salario mensual: ");
            double s = double.Parse(Console.ReadLine());

            //calculos 
            double smmlv = 828.116;

            if (s < (2 * smmlv))
            {
                Console.WriteLine("Tiene acceso a la Tarifa A y debe pagar un monto de 3.200");
            } 
            else if ((2 * smmlv) < s && s < (5 * smmlv))
            {
                Console.WriteLine("Tiene acceso a la Tarifa B y debe pagar un monto de 12.700");
            }
            else
            {
                Console.WriteLine("Tiene acceso a la Tarifa C y debe pagar un monto de 33.700");
            }


        }
    }
}
