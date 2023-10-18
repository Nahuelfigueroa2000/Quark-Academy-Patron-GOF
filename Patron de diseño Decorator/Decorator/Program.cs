using Patron_de_diseño_Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICafe cafe = new Cafe_Simple();
            cafe = new CafeConLeche(cafe);
            cafe = new Azucar(cafe);


            double costo = cafe.CostoCafe();
            string descripcion = cafe.DescripcionCafe(); 

            Console.WriteLine($"Café personalizado: {descripcion}, Costo: ${costo}");
            Console.ReadKey();
        }
    }
}
