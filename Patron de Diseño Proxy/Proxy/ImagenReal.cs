using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Proxy.Proxy
{
    internal class ImagenReal : IImagen
    {
        private string rutaImagen;

        public ImagenReal(string ruta)
        {
            rutaImagen = ruta;
            CargarImagenDesdeDisco();
        }

        private void CargarImagenDesdeDisco()
        {
            // Simular la carga de la imagen desde el disco.
            Console.WriteLine($"Cargando imagen desde {rutaImagen}");
        }

        public void MostrarImagen()
        {
            // Simular la visualización de la imagen.
            Console.WriteLine($"Mostrando imagen: {rutaImagen}");
        }
    }
}
