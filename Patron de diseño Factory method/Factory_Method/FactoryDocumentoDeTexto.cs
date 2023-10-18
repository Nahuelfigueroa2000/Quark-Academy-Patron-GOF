using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Factory_method.Factory_Method
{
    internal class FactoryDocumentoDeTexto : IFactoryDocumento
    {
        public IDocumento CrearDocumento()
        {
            return new DocumentoTexto();
        }
    }
}
