using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Mediator.Mediator
{
    internal class MediadorChat : IMediadorChat
    {
        private List<IUsuario> usuarios = new List<IUsuario>();

        public void RegistrarUsuario(IUsuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void EnviarMensaje(string mensaje, IUsuario emisor)
        {
            Console.WriteLine($"{emisor.Nombre} dice: {mensaje}");
            foreach (var usuario in usuarios)
            {
                if (usuario != emisor)
                {
                    usuario.RecibirMensaje();
                }
            }
        }
    }
}
