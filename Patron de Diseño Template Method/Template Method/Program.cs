using Patron_de_Diseño_Template_Method.Template_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cafe espresso = new Espresso();
            Cafe americano = new Americano();
            Cafe cappuccino = new Capuccino();

            Console.WriteLine("Preparando un  Cafe Espresso:");
            espresso.PrepararCafe();

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Preparando un Cafe Americano:");
            americano.PrepararCafe();

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Preparando un Cafe Cappuccino:");
            cappuccino.PrepararCafe();

            Console.ReadKey();
        }
    }
}
