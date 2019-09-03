using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            string Frase = "La araña se mueve en la tela de araña";
            Frase = Frase.ToUpper();
            string Busqueda = "araña".ToUpper();

            for (int u = 0; u < Frase.Length; u++)
            {
                for (int e = 0; e < Busqueda.Length; e++)
                {
                    string comparacion = "".ToUpper();
                    comparacion += Frase[e + u];
                    if (comparacion == Busqueda)
                    {
                        Console.Write("palabra encontrada en: " + e);
                    }


                }
            }
            
        }
    }
}
