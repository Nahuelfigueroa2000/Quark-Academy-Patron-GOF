using Patron_de_Diseño_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediadorChat mediador = new MediadorChat();

            IUsuario usuario1 = new Usuario("Usuario 1", mediador);
            IUsuario usuario2 = new Usuario("Usuario 2", mediador);

            bool chatAbierto = true;

            while (chatAbierto)
            {
                Console.WriteLine("Usuario 1, escribe un mensaje (o 'cerrar' para salir):");
                string mensajeUsuario1 = Console.ReadLine();

                if (mensajeUsuario1.ToLower() == "cerrar")
                {
                    chatAbierto = false;
                    Console.WriteLine("El usuario 1 cerro chat");
                }
                else
                {
                    usuario1.EnviarMensaje(mensajeUsuario1);

                    Console.WriteLine("Usuario 2, responde (o 'cerrar' para salir):");
                    string mensajeUsuario2 = Console.ReadLine();

                    if (mensajeUsuario2.ToLower() == "cerrar")
                    {
                        chatAbierto = false;
                        Console.WriteLine("El usuario 2 cerro chat");
                    }
                    else
                    {
                        usuario2.EnviarMensaje(mensajeUsuario2);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
