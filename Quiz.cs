using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //datos
            Console.WriteLine("Ingrese su salario mensual: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("¿su contrato es dependiente (1) o independiente (2)?: ");
            int cont = int.Parse(Console.ReadLine());                                                                                                       // error, no se puede dejar en blanco, si no, si funciona :D
            Console.WriteLine("si su contrato es independiente (2) ingrese un numero del 1 al 5 equivalente a la clase de riesgo, de lo contrario deja el espacio en blanco: ");
            int riesgo = int.Parse(Console.ReadLine());
            int MIN = 828116;
            double bc = s * 0.4;
            //calculos 
            if (bc < MIN) { bc = MIN;
            if (cont == 1)
                {
                    double pension = bc * 0.04;
                    double eps = bc * 0.04;
                    double deduccionA = (pension + eps) * 12;
                    double salariof = ((s * 12) - deduccionA) + s;
                    Console.WriteLine("Su salario anual con deducciones y bonificación: " + salariof);
                }
                else
                {
                    int arl = riesgo;
                    double pension = bc * 0.16;
                    double eps = bc * 0.125;

                    if (arl == 1)
                    {
                        double deduccionA = (pension + eps + (bc * 0.00522) * 12);
                        double salariof = ((s * 12) - deduccionA);
                        Console.WriteLine("su salario anual con deducciones es: " + salariof);
                    }
                    else if (arl == 2)
                    {
                        double deduccionA = (pension + eps + (bc * 0.01044) * 12);
                        double salariof = ((s * 12) - deduccionA);
                        Console.WriteLine("su salario anual con deducciones es: " + salariof);
                    }
                    else if (arl == 3)
                    {
                        double deduccionA = (pension + eps + (bc * 0.02436) * 12);
                        double salariof = ((s * 12) - deduccionA);
                        Console.WriteLine("su salario anual con deducciones es: " + salariof);
                    }
                    else if (arl == 4)
                    {
                        double deduccionA = (pension + eps + (bc * 0.0435) * 12);
                        double salariof = ((s * 12) - deduccionA);
                        Console.WriteLine("su salario anual con deducciones es: " + salariof);
                    }
                    else
                    {
                        double deduccionA = (pension + eps + (bc * 0.0696) * 12);
                        double salariof = ((s * 12) - deduccionA);
                        Console.WriteLine("su salario anual con deducciones es: " + salariof);
                    }

                } 

            } else
                if (cont == 1)
            {
                double pension = bc * 0.04;
                double eps = bc * 0.04;
                double deduccionA = (pension + eps) * 12;
                double salariof = ((s * 12) - deduccionA) + s;
                Console.WriteLine("Su salario anual con deducciones y bonificación: " + salariof);
            }
            else
            {
                int arl = riesgo;
                double pension = bc * 0.16;
                double eps = bc * 0.125;

                if (arl == 1)
                {
                    double deduccionA = (pension + eps + (bc * 0.00522) * 12);
                    double salariof = ((s * 12) - deduccionA);
                    Console.WriteLine("su salario anual con deducciones es: " + salariof);
                }
                else if (arl == 2)
                {
                    double deduccionA = (pension + eps + (bc * 0.01044) * 12);
                    double salariof = ((s * 12) - deduccionA);
                    Console.WriteLine("su salario anual con deducciones es: " + salariof);
                }
                else if (arl == 3)
                {
                    double deduccionA = (pension + eps + (bc * 0.02436) * 12);
                    double salariof = ((s * 12) - deduccionA);
                    Console.WriteLine("su salario anual con deducciones es: " + salariof);
                }
                else if (arl == 4)
                {
                    double deduccionA = (pension + eps + (bc * 0.0435) * 12);
                    double salariof = ((s * 12) - deduccionA);
                    Console.WriteLine("su salario anual con deducciones es: " + salariof);
                }
                else
                {
                    double deduccionA = (pension + eps + (bc * 0.0696) * 12);
                    double salariof = ((s * 12) - deduccionA);
                    Console.WriteLine("su salario anual con deducciones es: " + salariof);
                }

            }
        }
    }
}
