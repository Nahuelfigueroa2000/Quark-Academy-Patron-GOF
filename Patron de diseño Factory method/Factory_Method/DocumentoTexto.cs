using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Factory_method.Factory_Method
{
    internal class DocumentoTexto : IDocumento
    {
        public void AbrirDocumento()
        {
            Console.WriteLine("Abriendo documento de texto");
        }

        public void CerrarDocumento()
        {
            Console.WriteLine("Cerrando documento de texto");
        }

        public void GuardarDocumento()
        {
            Console.WriteLine("Guardando documento de texto");
        }
    }
}
