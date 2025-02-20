using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio.coche._6105188
{
    internal class coche
    {
        public string Marca;
        public string Modelo;
        public int Velocidadmaxima;
        public int Velocidadactual;


        public coche(string marca, string modelo, int velocidadmaxima, int velocidadactual)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidadmaxima = velocidadmaxima;
            Velocidadactual = velocidadactual;
        }

        public void acelerar(int acelerar)
        {
            
                acelerar += 5;
            
                
           
            Console.WriteLine("Al incrementar la velocidad: " + acelerar + "km/h");
        }

        public void decelerar(int decelerar)
        {
            decelerar -= 5;

            Console.WriteLine("Decelera a " + decelerar +" km/h");

        }
       
    }
}
