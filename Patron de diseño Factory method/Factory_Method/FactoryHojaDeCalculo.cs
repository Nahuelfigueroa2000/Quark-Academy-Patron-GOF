using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Factory_method.Factory_Method
{
    internal class FactoryHojaDeCalculo : IFactoryDocumento
    {
        public IDocumento CrearDocumento()
        {
            return new HojaDeCalculo();
        }
    }
}
