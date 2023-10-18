using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Mediator.Mediator
{
    internal interface IUsuario
    {
        string Nombre { get; }
        void EnviarMensaje(string mensaje);
        void RecibirMensaje();
    }
}
