using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            // punto 1
            double promedio = 3.0;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (notas[i] <= promedio)
                {
                    salida++;
                }
            }

            // punto 3
            List<string> salida = new List<string>();
            double promedio = 3.0;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (notas[i] <= promedio)
                {
                    salida.Add(nombres[i]);
                }

            }

            //punto 4 con errores
            string[] vocales = { "a", "e", "i", "o", "u" };

            List<string> n = new List<string>();
            for (int i = 0; i < vocales.Length; i++)
            {
                if (nombres[i] != vocales[i])
                {
                    n.Add(nombres[i]);
                }
            }
            for (int i = 0; i < n.Count; i++)
            {
                salida.Add(n[i]);

            }

            // punto 4 
            List<string> n = new List<string>();
            for (int i = 0; i < nombres.Length; i++)
            {
                string nombre = nombres[i];
                if (nombre[0] != 'A' && nombre[0] != 'E' && nombre[0] != 'I' && nombre[0] != 'O' && nombre[0] != 'U')
                {
                    salida.Add(nombres[i]);
                }
            }


        }
    }
}
