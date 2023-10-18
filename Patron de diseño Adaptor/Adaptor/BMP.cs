using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Adaptor.Adaptor
{
    internal class BMP : IImagen
    {
        public void CargarImagen(string imagen)
        {
            Console.WriteLine($"Cargando imagen BMP desde el archivo {imagen}");
        }

        public void GuardarImagen(string imagen)
        {
            Console.WriteLine($"Guardando imagen BMP en el archivo {imagen}");
        }
    }
}
