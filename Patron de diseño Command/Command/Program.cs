using Patron_de_diseño_Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Patron_de_diseño_Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampara lampara = new Lampara();
            Radio radio = new Radio();

            IComando encenderLampara = new EncenderLampara(lampara);
            IComando apagarLampara = new ApagarLampara(lampara);
            IComando encenderRadio = new EncenderRadio(radio);
            IComando apagarRadio = new ApagarRadio(radio);

            ControlRemoto controlRemoto = new ControlRemoto();

            controlRemoto.EstablecerComando(encenderLampara);
            controlRemoto.PresionarBoton(); // Enciende la lámpara

            controlRemoto.EstablecerComando(apagarLampara);
            controlRemoto.PresionarBoton(); // Apaga la lámpara

            controlRemoto.EstablecerComando(encenderRadio);
            controlRemoto.PresionarBoton(); // Enciende el radio

            controlRemoto.EstablecerComando(apagarRadio);
            controlRemoto.PresionarBoton(); // Apaga el radio
            Console.ReadKey();
        }
    }
}
