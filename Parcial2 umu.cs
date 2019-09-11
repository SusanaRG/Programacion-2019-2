using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------




        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

 

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        double prom = total / notas.Length;

        total = 0;
        double sum = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            double desv = Math.Pow(notas[i] - prom, 2);
            total += desv;
        }
        double desviacion = Math.Sqrt(total / notas.Length);

        for (int i = 0; i < nombres.Length; i++)
        {
            double sumatotal = prom + desviacion;
            if (notas[i] > sumatotal)
            {
                salida.Add(nombres[i]);
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        // cuarto mal hecho 
        string letra = "A";
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombre = nombres[i];
            for(int j = 0; j < nombres.Length - letra.Length + 1; j++)
            {
                nombre += nombres[i + j];
            }
            if (nombre == letra)
            {
                salida.Add(nombres[i]);
            }
        }


        //cuarto bien
        for (int i = 0; i < nombres.Length; i++)
        {

            for (int j = 0; j <= nombres[i].Length - 1; j++)
            {
                string nombre = nombres[i];
                if (nombre[j] == 'A')
                {
                    salida.Add(nombres[i]);

                    break;
                }
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }
}


