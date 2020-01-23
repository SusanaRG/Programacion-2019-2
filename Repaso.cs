using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            short VarShort = 0;
            int VarEntera = 0;
            Int16 VarEnt16 = 0;
            string Texto1; //tipo de dato
            String Texto2; //clase

            double Vardoble = 130.16543543620154864312031514611534545115545311;
            float Varfloat = 0.0f;

            char Varchar = 'D';

            //Conversiones CAST:

            //Desde char a numerico
             VarShort = (short)Varchar;

            Console.WriteLine("El numero aschii de la " + Varchar + " es " + VarShort);

            VarShort = (short)Vardoble;
            Console.WriteLine("El doble es " + Vardoble + " \n y queda en short " + VarShort);

            //Parse

            VarEnt16 = Int16.Parse("145");

            Varfloat = float.Parse("953.55");

            VarEntera = int.Parse("54654");

            //Conddicionales

            if(VarEntera == 100 && VarEnt16 != 5000)
            {
                //verddadero
                Console.WriteLine("Es verdadero");
            }
            else
            {
                //falso
                Console.WriteLine("Es falso");
            }

            /*Texto1 = "azul";
            Texto2 = "rojo";
            string Texto3 = "verde";
            */


            Console.WriteLine("Ingrese  color 1: ");
            Texto1 = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese  color 2: ");
            Texto2 = Console.ReadLine().ToLower();



            if (Texto1.Equals("roja") && Texto2.Equals("azul") || Texto1.Equals("azul") && Texto2.Equals("roja"))
            {
                Console.WriteLine("Gana premio mayor");
            }
            else if (Texto1.Equals("azul") || Texto2.Equals("azul"))
            {
                Console.WriteLine("Gana segundo premio");
            }
            else if (Texto1.Equals("roja") && Texto2.Equals("roja"))
            {
                Console.WriteLine("Gana tercer premio");
            }
            else
            {
                Console.WriteLine("efe");
            }


            //Switch
            Console.WriteLine("Seleccione su opción de almuerzo entre 1 y 4: ");
            VarShort = short.Parse(Console.ReadLine());

            switch (VarShort)
            {
                case 1: Console.WriteLine("Sancocho");
                    break;
                case 2:
                    Console.WriteLine("Mondongo");
                    break;
                case 3:
                    Console.WriteLine("Changua");
                    break;
                case 4:
                    Console.WriteLine("Mote de queso");
                    break;
                default:
                    Console.WriteLine("No come");
                    break;

            }

            //Ciclos
            //while

            VarEntera = 0;

            while (VarEntera < 100) //Se cumple siempre que la condición sea verdadera
            {
                Console.Write((VarEntera += 2) + "-");
            }

            do
            {
                Console.WriteLine("Entré al do while");

            } while (VarEntera < 100);

            Console.WriteLine("********");
            for (short i=0; i <=100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            



            
        }

        // Zona de subrutinas 

    }
}
