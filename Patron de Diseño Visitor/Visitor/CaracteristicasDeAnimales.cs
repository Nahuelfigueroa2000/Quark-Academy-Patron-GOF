using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Visitor.Visitor
{
    internal class CaracteristicasDeAnimales : IAnimalVisitor
    {
        public void VisitarPerro(Perro perro)
        {
            Console.WriteLine("Perro: 4 patas, ladra");
        }

        public void VisitarGato(Gato gato)
        {
            Console.WriteLine("Gato: 4 patas, maulla");
        }

        public void VisitarPato(Pato pato)
        {
            Console.WriteLine("Pato: 2 patas, hace cuac");
        }
    }
}
