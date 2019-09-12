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

  double total = 0;
        double total2 = 0;        
        
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
            total2 += Math.Pow(notas[i], 2);            
        }
        double media = total / notas.Length;
        double desviacion = Math.Sqrt((total2 / notas.Length) - Math.Pow(media,2));        
        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] >= (desviacion+media)) salida++;
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

  double promedio = 0, promediotemp = 0;
        double[] desviacionIND = new double[notas.Length];
        for (int i = 0; i < notas.Length; i++)
        {
            promediotemp += notas[i];
        }
        promedio = promediotemp / notas.Length;
        for (int i = 0; i < notas.Length; i++)
        {
            desviacionIND[i] += Math.Pow(promedio - notas[i], 2);
        }
        for( int i = 0; i < desviacionIND.Length; i++)
        {
            for (int j = 0; j < desviacionIND.Length - 1; j++)
            {
                double temp1 = 0;
                string temptxt = "";
                if (desviacionIND[j] < desviacionIND[j + 1])
                {
                    temp1 = desviacionIND[j + 1];
                    desviacionIND[j + 1] = desviacionIND[j];
                    desviacionIND[j] = temp1;

                    temptxt = nombres[j + 1];
                    nombres[j + 1] = nombres[j];
                    nombres[j] = temptxt;
                }
            }
        }
        for(int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }

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


