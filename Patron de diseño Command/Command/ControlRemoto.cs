using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Patron_de_diseño_Command.Command
{
    internal class ControlRemoto
    {
        private IComando comando;

        public void EstablecerComando(IComando comando)
        {
            this.comando = comando;
        }

        public void PresionarBoton()
        {
            comando.Ejecutar();
        }
    }

}
