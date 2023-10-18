using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_ChainOfResponsability.ChainOfResponsability
{
    internal class Gerente : Autoridad
    {
        public override void Procesar(Solicitud S)
        {
            if (S.Importe <= 1000)
            {
                Console.WriteLine("compra aprobada por el gerente");
            }
            else
            {
                siguiente.Procesar(S);
            }
        }
    }
}
