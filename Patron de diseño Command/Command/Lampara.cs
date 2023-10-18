using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Command.Command
{
    internal class Lampara
    {
        public void Encender()
        {
            Console.WriteLine("Encender Lampara");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagar Lampara");
        }
    }
}
