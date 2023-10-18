using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Factory_method.Factory_Method
{
    internal class Presentancion : IDocumento
    {
        public void AbrirDocumento()
        {
            Console.WriteLine("Abriendo presentacion");
        }

        public void CerrarDocumento()
        {
            Console.WriteLine("Cerrando presentacion");
        }

        public void GuardarDocumento()
        {
            Console.WriteLine("Guardando presentacion");
        }
    }
}
