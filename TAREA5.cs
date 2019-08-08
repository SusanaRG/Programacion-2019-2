using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class TAREA5
    {
        static void Main()
        {

            Console.WriteLine("Ingrese su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("¿su contrato es dependiente (1) o independiente (2)?: ");
            int contrato = int.Parse(Console.ReadLine());
            double MIN = 828116;
            double basecotizacion = salario * 0.4;

            if (basecotizacion < MIN) basecotizacion = MIN;

            if (contrato == 1)
            {
                double eps = 0.04 * basecotizacion;
                double pension = 0.04 * basecotizacion;               
                double Salarioreal = salario - eps - pension;
                Console.WriteLine("Su salario mensual real equivale a: " + Salarioreal);
                double Salarioanual = Salarioreal * 12 + salario;
                Console.WriteLine("Su salario real anual equivale a: " + Salarioanual);
            }
            else
            {
                double eps = 0.125 * basecotizacion;
                double pension = 0.16 * basecotizacion;
                Console.WriteLine("Ingrese un número dependiendo de su riesgo laboral (1-5): ");
                double ARL = double.Parse(Console.ReadLine()); 
                switch (ARL)
                {
                    case 1: ARL = basecotizacion * 0.00522;
                        break;
                    case 2:
                        ARL = basecotizacion * 0.01044;
                        break;
                    case 3:
                        ARL = basecotizacion * 0.02436;
                        break;
                    case 4:
                        ARL = basecotizacion * 0.0435;
                        break;
                    case 5:
                        ARL = basecotizacion * 0.0696;
                        break;
                }
                double Salarioreal = salario - eps - pension - ARL;
                Console.WriteLine("Su salario mensual real equivale a: " + Salarioreal);
                double Salarioanual = Salarioreal * 12;
                Console.WriteLine("Su salario real anual equivale a: " + Salarioanual);


            }
        }
    }
}
