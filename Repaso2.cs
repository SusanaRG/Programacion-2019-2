using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Repaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try y Catch para buscar errores
            try
            {
               /* string Linea;
                string[] Arreglo;

                StreamReader LeerArchivo = new StreamReader("C:\\Users\\B09S107est\\Downloads\\Autos.txt");

                Linea = LeerArchivo.ReadLine();

                while(Linea != null)
                {
                    Arreglo = Linea.Split('|');

                    Console.WriteLine("El carro con placa " + Arreglo[0] + "Tiene " + Arreglo[4] + "Kms");
                    Linea = LeerArchivo.ReadLine();
                }

                short[] Marcadores = new short[] { 65, 98, 64, 47 };
                short Total = 0;
                Random NumAleatorio = new Random();

                for (short i = 0; i <= 3; i++)
                
                    Total += Marcadores[i];
                
                //Console.WriteLine("El marcador en el juego " + (i + 1) + "fue " + Marcadores[i]);
                Console.WriteLine("El total marcado fue: " + Total);

                string[] Vector2 = new string[100];

                long[,] MatrizLongs = new long[50, 40];

                //llenamos la matriz long con aleatorios
                for(short i = 0; i <50; i++)
                {
                    for (short j = 0; j < 40; j++)
                    {
                        MatrizLongs[i , j] = NumAleatorio.Next(10, 80);
                    }
                }

                for (short i = 0; i < 50; i++)
                {
                    for (short j = 0; j < 40; j++)
                    {
                       Console.Write (MatrizLongs[i, j] + " - ");
                    }
                    Console.WriteLine();
                }
                */

                //Listas(arreglo dinamico)

                List<string> Lista_juegos = new List<string>();
                string Linea1;

            StreamReader LeerArchivo1 = new StreamReader("C:\\Users\\B09S107est\\Downloads\\juegos.txt");
                Linea1 = LeerArchivo1.ReadLine();

                while (Linea1 != null)
                {
                    Lista_juegos.Add(Linea1);
                    Linea1 = LeerArchivo1.ReadLine();
                }

                Console.WriteLine("******* LISTA DE JUEGOS *******");
                ImprimirLista(Lista_juegos);
                Lista_juegos.Sort();

                Console.WriteLine("******* LISTA DE JUEGOS ORDENADA *******");
                ImprimirLista(Lista_juegos);

                // uso foreach(ciclo que pasa por cada elemento de la lista)

                /* foreach(string elemento in Lista_juegos)
                 {
                     Console.WriteLine(elemento);
                 }
                 Console.ReadKey();*/


                Console.ReadKey();
            }
            catch(Exception error)
            {
                Console.WriteLine("Se presentó una excepción: " + error);
                Console.ReadKey();
            }
        }

        public static void ImprimirLista(List<string>  Lista_aImprimir)
        {
            try
            {
                foreach (string elemento in Lista_aImprimir)
                {
                    Console.WriteLine(elemento);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Se presentó una excepción: " + error);
                Console.ReadKey();
            }
        }
    }
}
