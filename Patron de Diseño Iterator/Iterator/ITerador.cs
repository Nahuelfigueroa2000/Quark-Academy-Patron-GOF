using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Iterator.Iterator
{
    internal interface ITerador
    {
        int Siguiente();
        bool TieneSiguiente();
    }
}
