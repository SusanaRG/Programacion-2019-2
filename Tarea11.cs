using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_11
{
    class Program
    {
        static void Main()
        {

            int[] A = { 0, 15, 12, 6, 3, 18, 12, 6, 9 };
            int[] B = { 0, 4, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 };
            int[] U = new int[31];
            List<int> interseccion = new List<int>();
            List<int> Complemento = new List<int>();
            int P, Q = 0, R = 0, E, C, F, G, Z;
            for (int i = 0; i < U.Length; i++) {
                U[i] = i;
            }           
            //union
            int[] AuB = A.Union(B).ToArray();
            while (Q < AuB.Length)
            {
                Q++;
                for (int l = 0; l < AuB.Length - 1; l++)
                {
                    if (AuB[l] > AuB[l + 1])
                    {
                        C = AuB[l];
                        AuB[l] = AuB[l + 1];
                        AuB[l + 1] = C;
                    }
                }
            }
            for (int i = 0; i < AuB.Length; i++)
            {
                Console.WriteLine("union: " + AuB[i]);
            }
            //complemento
            for (G = 0; G < AuB.Length; G++)
            {
                for (F = 0; F < U.Length; F++)
                {
                    if (AuB[G] == U[F])
                    {
                        U[F] = -1;                                       
                    }
                }
            }
            // LLENAR LISTA COMPLEMENTO            
                for (Z = 0; Z < U.Length; Z++)
                {
                    if (U[Z] != -1)
                    {
                        Complemento.Add(U[Z]);
                    }
                }            

            //interseccion
            for (E = 0; E  < A.Length; E++) {
                for (P = 0; P < B.Length; P++)
                {
                    if (A[E] == B[P])
                    {
                        interseccion.Add(A[E]);
                    }
                }             
            }
            interseccion.Sort();
            while (R < interseccion.Count)
            {
                for (int i = 0; i < interseccion.Count - 1; i++)
                {
                    if (interseccion[i] == interseccion[i + 1])
                    {
                        interseccion.RemoveAt(i);
                    }
                }
                R++;
            }
            for (int i = 0; i < interseccion.Count; i++)
            {
                Console.WriteLine("interseccion: " + interseccion[i]);
            }
            for (int i = 0; i < Complemento.Count; i++)
            {
                Console.WriteLine("complemento: " + Complemento[i]);
            }


        }
    }
}
