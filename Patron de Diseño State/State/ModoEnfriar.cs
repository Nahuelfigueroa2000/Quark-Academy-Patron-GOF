using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_State.State
{
    internal class ModoEnfriar : ITermostato
    {
        public void AumentarTemperatura()
        {
            Console.WriteLine("La temperatura esta aumentado en modo enfriar");
        }

        public void MostrarEstado()
        {
            Console.WriteLine("Termostato en modo enfriar");
        }

        public void ReducirTemperatura()
        {
            Console.WriteLine("La temperatura esta reduciendo en modo enfriar");
        }
    }
}
