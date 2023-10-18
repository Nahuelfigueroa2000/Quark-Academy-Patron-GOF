using Patron_de_diseño_Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(1.2, "rojo");
            Circulo circuloClonado = (Circulo)circulo.Clonar();
            Console.WriteLine("Círculo Original:");
            circulo.MostrarCirculo();

            Console.WriteLine("Círculo Clonado:");
            circuloClonado.MostrarCirculo();
            Console.ReadKey();

        }
    }
}
