using Patron_de_Diseño_Proxy.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea una instancia de ProxyImagen
            IImagen imagen = new ProxyImagen("imagen.jpg");

            // Muestra la imagen (se cargará la imagen real solo la primera vez)
            imagen.MostrarImagen();

            // Muestra la imagen nuevamente (utiliza el proxy sin cargar la imagen real nuevamente)
            imagen.MostrarImagen();
            Console.ReadKey();
        }
    }
}
