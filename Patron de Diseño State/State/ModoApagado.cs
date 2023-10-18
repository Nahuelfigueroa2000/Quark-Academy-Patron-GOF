using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_State.State
{
    internal class ModoApagado : ITermostato
    {
        public void AumentarTemperatura()
        {
            Console.WriteLine("No se puede aumentar esta modo apagado");
        }

        public void MostrarEstado()
        {
            Console.WriteLine("Termostato en modo apagado");
        }

        public void ReducirTemperatura()
        {
            Console.WriteLine("No se puede reducir esta modo apagado");
        }
    }
}
