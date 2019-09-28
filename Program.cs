using System;

namespace Calculo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase principal para llamar al menú el cual contiene las opciones
            //donde escogera el usuario.
            Principal S = new Principal();
            S.Menu();
        }
    }
}
