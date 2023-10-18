using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño_Observer.Observer
{
    internal class RedSocial
    {
        private List<IObservador> usuarios = new List<IObservador>();

        public void RegistrarUsuario(IObservador usuario)
        {
            usuarios.Add(usuario);
        }

        public void EliminarUsuario(IObservador usuario)
        {
            usuarios.Remove(usuario);
        }

        public void NotificarActualizacion(string actualizacion)
        {
            foreach (var usuario in usuarios)
            {
                usuario.ActualizarNotificacion(actualizacion);
            }
        }
    }
}
