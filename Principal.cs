using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo1
{
    class Principal
    {
        //Metodo para el menú
        public void Menu()
        {
            Console.WriteLine("Hola bienvenidos");
            Console.WriteLine("Menu:");

            Console.WriteLine("1-Triangulo:");
            Console.WriteLine("2-Cuadrado:");
            Console.WriteLine("3-Rectangulo:");
            Console.WriteLine("4-Rombo:");
            Console.WriteLine("5-Salir");
            //Variable con la que controlare el ciclo y el switch
            int M = Convert.ToInt32(Console.ReadLine());
            //Declaración de variables
            double a, b, c=0, d=0;
            do
            {
                
                double R;
                Operación S = new Operación();

                switch (M)
                {
                    case 1:
                        Console.WriteLine("Ingresa valores:");
                        Console.WriteLine("Ingresa valor de la base:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa valor de la altura:");
                        b = Convert.ToDouble(Console.ReadLine());
                        d = 2;
                        R=S.CalcularArea(a,b,d);//Se manda como parametros los  valores ingresados por el usuario
                        //Al metodo CalcularArea
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Ingresa valores:");
                        Console.WriteLine("Ingresa valor del lado:");
                        a = Convert.ToDouble(Console.ReadLine());             
                        R = S.CalcularArea(a);//Se manda como parametro el valor ingresado al metodo que guarda solo 1 parametro
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Ingresa valores:");
                        Console.WriteLine("Ingresa valor de la base:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa valor de la altura:");
                        b = Convert.ToDouble(Console.ReadLine());
                        R = S.CalcularArea(a, b);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Ingresa valores:");
                        Console.WriteLine("Ingresa valor de la diagonal mayor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingresa valor de la diagonal menor:");
                        b = Convert.ToDouble(Console.ReadLine());
                        c = 2;
                        R = S.CalcularArea(a, b,c);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        
                       Salir();
                        break;
                    default:
                        Console.WriteLine("Valor no encontrado");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }

                Menu();//Se llama al menú por si el usuario quiere seguir realizando operaciones
            } while (M == 5);

        }
        //Metodo para salir
        public void Salir()
        {
            Environment.Exit(0);
        }

    }
}
