using Patron_de_diseño_Adaptor.Adaptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Adaptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImagen imagen = new Jpeg_A_Bmp_Adaptor(new JPEG());
            imagen.CargarImagen("imagen.jpg");
            imagen.GuardarImagen("imagen_convertida.bmp");
            Console.WriteLine("-----------------");
            IImagen imagen1 = new Png_A_Bmp_Adaptor(new PNG());
            imagen1.CargarImagen("imagen.png");
            imagen1.GuardarImagen("imagen_convertida.bmp");
            Console.ReadKey();
        }
    }
}
