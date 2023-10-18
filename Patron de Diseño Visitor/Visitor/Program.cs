using Patron_de_Diseño_Visitor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimalVisitable> animales = new List<IAnimalVisitable>
            {
            new Perro(),
            new Gato(),
            new Pato()
            };

            CaracteristicasDeAnimales caracteristicasAnimales = new CaracteristicasDeAnimales();

            foreach (var animal in animales)
            {
                animal.Aceptar(caracteristicasAnimales);
            }

            Console.ReadKey();
        }
    }
}
