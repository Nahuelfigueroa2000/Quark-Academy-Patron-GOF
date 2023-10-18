using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Memento.Memento
{
    internal class Memento
    {
        public int Volumen { get; set; }

        public Memento(int volumen)
        {
            Volumen = volumen;
        }
    }
}
