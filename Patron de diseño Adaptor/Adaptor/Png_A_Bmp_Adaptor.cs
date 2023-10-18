using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Adaptor.Adaptor
{
    internal class Png_A_Bmp_Adaptor: IImagen
    {
        readonly PNG PNG;

        public Png_A_Bmp_Adaptor(PNG pNG)
        {
            this.PNG = pNG;
        }

        public void CargarImagen(string imagen)
        {
            PNG.CargarImagen(imagen);
            Console.WriteLine("Convertido a BMP");
        }

        public void GuardarImagen(string imagen)
        {
            PNG.GuardarImagen(imagen);
            Console.WriteLine("Convertido a BMP");
        }
    }
}
