using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Mediator.Mediator
{
    internal class Usuario : IUsuario
    {
        private IMediadorChat mediador;

        public string Nombre { get; private set; }

        public Usuario(string nombre, IMediadorChat mediador)
        {
            this.Nombre = nombre;
            this.mediador = mediador;
            mediador.RegistrarUsuario(this);
        }

        public void EnviarMensaje(string mensaje)
        {
            mediador.EnviarMensaje(mensaje, this);
        }

        public void RecibirMensaje()
        {
            Console.WriteLine($"Mensaje recibido por {Nombre}");
        }
    }
}
