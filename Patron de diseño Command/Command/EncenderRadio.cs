using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Command.Command
{
    internal class EncenderRadio : IComando
    {
        private Radio radio;

        public EncenderRadio(Radio radio)
        {
            this.radio = radio;
        }

        public void Ejecutar()
        {
            radio.Encender();
        }
    }
}
