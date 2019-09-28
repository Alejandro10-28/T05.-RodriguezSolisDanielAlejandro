using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo1
{
    class Operación
    {
        //Se crea una variable global para almacenar las areas de las figuras que escoja el usuario.
        double A;
        //Dependiendo la cantidad de valores requeridos para la operación elegida por el usuario esta los almacenara para
        //retornar el resultado
        public double CalcularArea(double LadoA, double LadoB,double V)//Metodo que almacena 3 parametros
        {
             A = (LadoA * LadoB) / V;
            Console.WriteLine("El resultado es:{0}", A);

            return A;

        }
        public double CalcularArea(double L)//Metodo que almacena 1 parametro
        {
            A = L*L;
            Console.WriteLine("El resultado es:{0}" , A);

            return A;
            

        }
        public double CalcularArea(double LadoA, double LadoB)//Metodo que almacena 2 parametros
        {
          A = LadoA * LadoB;
            Console.WriteLine("El resultado es:{0}", A);

            return A;
        }
            
       
    }
}
