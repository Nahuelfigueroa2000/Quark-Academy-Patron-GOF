using Patrones_de_diseño_Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño_Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RedSocial redSocial = new RedSocial();
            Usuario usuario =  new Usuario("Usuario 1");
            Usuario usuario1 = new Usuario("Usuario 2");
            Usuario usuario2 = new Usuario("Usuario 3");


            redSocial.RegistrarUsuario(usuario);
            redSocial.RegistrarUsuario(usuario1);

            redSocial.NotificarActualizacion("Registro exitoso");

            redSocial.EliminarUsuario(usuario);
            redSocial.EliminarUsuario(usuario1);

            Console.WriteLine("Se elimino usuarios");

            redSocial.RegistrarUsuario(usuario2);

            redSocial.NotificarActualizacion("Registro exitoso");

            Console.ReadKey();  


        }
    }
}
