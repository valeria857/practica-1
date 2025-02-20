using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio.coche._6105188
{
    internal class program
    {
        static void Main(string[] args)
        {
            //llamando a la clase heredada
            coche coche1 = new coche("Toyota ", "Corola", 215, 100);
            Console.WriteLine("Descripción del cohce ");
            Console.WriteLine("Marca:" + coche1.Marca);
            Console.WriteLine("Modelo:" + coche1.Modelo);

            Console.WriteLine("Velocidad Maxima:" + coche1.Velocidadmaxima);
            Console.WriteLine("Velocidad Actual:" + coche1.Velocidadactual);
            Console.WriteLine("\nAcciones:");
            coche1.acelerar(100);
            coche1.decelerar(100);

            frenar frenar1 = new frenar();
            frenar1.frenarr(0);

            Console.ReadKey();

        }
    }
}
