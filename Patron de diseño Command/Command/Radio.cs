using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Command.Command
{
    internal class Radio
    {
        public void Encender()
        {
            Console.WriteLine("Encender Radio");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagar Radio");
        }
    }
}
