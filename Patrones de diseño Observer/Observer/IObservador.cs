using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño_Observer.Observer
{
    internal interface IObservador
    {
        void ActualizarNotificacion(string notificacion);
    }
}
