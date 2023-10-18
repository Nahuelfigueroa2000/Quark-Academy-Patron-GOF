using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Strategy.Strategy
{
    internal class EstrategiaOfensiva : IEstrategia
    {
        public void EjecutarTacticas()
        {
            Console.WriteLine("Atacar constantemente al enemigo.");
        }
    }
}
