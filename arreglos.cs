using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            int[] coordsX = { 0, 2, 3, 7 };
            int[] coordsY = {0, 1, 5, 6};

            double m1, m2, m3;
            m1 = (coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]);
            m2 = (coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]);
            m3 = (coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]);

            double b1, b2, b3;
            b1 = coordsY[1] + m1 * coordsX[1];
            b2 = coordsY[1] + m2 * coordsX[1];
            b3 = coordsY[2] + m3 * coordsX[2];

            double d1, d2, d3, Dmayor = 0;
            d1 = Math.Sqrt(Math.Pow((coordsX[1] - coordsX[0]), 2)) + (Math.Pow((coordsY[1] - coordsY[0]), 2));
            d2 = Math.Sqrt(Math.Pow((coordsX[2] - coordsX[1]), 2)) + (Math.Pow((coordsY[2] - coordsY[1]), 2));
            d3 = Math.Sqrt(Math.Pow((coordsX[3] - coordsX[2]), 2)) + (Math.Pow((coordsY[3] - coordsY[2]), 2));



            if (m1 != m2 && m2 != m3) Console.WriteLine("Las coordenadas no pertenecen a la misma recta");
            else if (b1 != b2 && b2 != b3) Console.WriteLine("Las coordenadas no pertenecen a la misma recta");
            else Console.WriteLine("Las coordenadas pertenecen a la misma recta");

            if (d1 > Dmayor && d2 < d1 && d3 < d1) Dmayor = d1;
            else if (d2 > Dmayor && d1 < d2 && d3 < d2) Dmayor = d2;
            else
            {
                Dmayor = d3;
            }
            Console.WriteLine("\n la mayor distancia es: " + Dmayor);









        }
    }
}
