using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Command.Command
{
    internal class EncenderLampara : IComando
    {
        private Lampara lampara;

        public EncenderLampara(Lampara lampara)
        {
            this.lampara = lampara;
        }

        public void Ejecutar()
        {
            lampara.Encender();
        }
    }
}
