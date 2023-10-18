using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Adaptor.Adaptor
{
    internal class JPEG
    {
        public void CargarImagen(string imagen)
        {
            Console.WriteLine($"Cargando imagen JPEG desde el archivo {imagen}");         
        }

        public void GuardarImagen(string imagen)
        {
            Console.WriteLine($"Guardando imagen JPEG en el archivo {imagen}");
        }
    }
}
