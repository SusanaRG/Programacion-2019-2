using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            string[] nombres = { "S", "L", "M", "K", "M" };
            int[] Total = { 1, 2, 1, 5, 4 };
            int C, i = 0, Q = 0;
            string B;

            while (Q < Total.Length)
            {
                Q++;
                for (i = 0; i < nombres.Length - 1; i++)
                {
                    if (Total[i] < Total[i + 1])
                    {
                        C = Total[i];
                        Total[i] = Total[i + 1];
                        Total[i + 1] = C;

                        B = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = B;
                    }
                }
            }
                for (i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine(nombres[i]+ ": " + Total[i]);
                }
            
        }
    }
}
