using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Command.Command
{
    internal class ApagarLampara : IComando
    {
        private Lampara lampara;

        public ApagarLampara(Lampara lampara)
        {
            this.lampara = lampara;
        }

        public void Ejecutar()
        {
            lampara.Apagar();
        }
    }
}
