using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_State.State
{
    internal interface ITermostato
    {
        void AumentarTemperatura();
        void ReducirTemperatura();
        void MostrarEstado();

    }
}
