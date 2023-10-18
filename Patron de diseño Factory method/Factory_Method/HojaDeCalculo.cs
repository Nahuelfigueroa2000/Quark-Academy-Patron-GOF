using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Factory_method.Factory_Method
{
    internal class HojaDeCalculo : IDocumento
    {
        public void AbrirDocumento()
        {
            Console.WriteLine("Abriendo Hoja de calculo");
        }

        public void CerrarDocumento()
        {
            Console.WriteLine("Cerrando Hoja de calculo");
        }

        public void GuardarDocumento()
        {
            Console.WriteLine("Guardando Hoja de calculo");
        }
    }
}
