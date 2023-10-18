using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Adaptor.Adaptor
{
    internal class Jpeg_A_Bmp_Adaptor : IImagen
    {
        readonly JPEG JPEG;

        public Jpeg_A_Bmp_Adaptor(JPEG JPEG)
        {
            this.JPEG = JPEG;
        }

        public void CargarImagen(string imagen)
        {
            JPEG.CargarImagen(imagen);
            Console.WriteLine("Convertido a BMP");
        }

        public void GuardarImagen(string imagen)
        {
            JPEG.GuardarImagen(imagen);
            Console.WriteLine("Convertido a BMP");
        }
    }
}
