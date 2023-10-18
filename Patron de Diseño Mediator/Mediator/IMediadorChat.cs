using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Mediator.Mediator
{
    internal interface IMediadorChat
    {
        void RegistrarUsuario(IUsuario usuario);
        void EnviarMensaje(string mensaje, IUsuario emisor);
    }
}
