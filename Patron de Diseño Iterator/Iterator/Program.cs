using Patron_de_Diseño_Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColeccionNumeros coleccion = new ColeccionNumeros();
            coleccion.AgregarNumero(1);
            coleccion.AgregarNumero(2);
            coleccion.AgregarNumero(3);
            coleccion.AgregarNumero(4);

            ITerador iterador = coleccion.ObtenerIterador();

            Console.WriteLine("Recorriendo la colección de números:");
            while (iterador.TieneSiguiente())
            {
                int numero = iterador.Siguiente();
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
