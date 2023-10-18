using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Strategy.Strategy
{
    internal class EstrategiaEconomica : IEstrategia
    {
        public void EjecutarTacticas()
        {
            Console.WriteLine("Centrarse en la recolección de recursos y la construcción económica.");
        }
    }
}
