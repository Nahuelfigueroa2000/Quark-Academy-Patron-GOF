using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_ChainOfResponsability.ChainOfResponsability
{
    internal abstract class Autoridad
    {
        protected Autoridad siguiente;

        public void EstablacerSiguiente(Autoridad autoridad)
        {
            siguiente = autoridad;
        }

        public abstract void Procesar(Solicitud S);
    }
}
