using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Proxy.Proxy
{
    internal class ProxyImagen : IImagen
    {
        private ImagenReal imagenReal;
        private string rutaImagen;

        public ProxyImagen(string ruta)
        {
            rutaImagen = ruta;
        }

        public void MostrarImagen()
        {
            if (imagenReal == null)
            {
                imagenReal = new ImagenReal(rutaImagen);
            }
            imagenReal.MostrarImagen();
        }
    }
}
