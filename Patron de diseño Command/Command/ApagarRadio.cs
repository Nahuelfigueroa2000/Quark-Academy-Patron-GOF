using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Command.Command
{
    internal class ApagarRadio : IComando
    {
        private Radio radio;

        public ApagarRadio(Radio radio)
        {
            this.radio = radio;
        }

        public void Ejecutar()
        {
            radio.Apagar();
        }
    }
}
