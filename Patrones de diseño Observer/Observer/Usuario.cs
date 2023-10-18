using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño_Observer.Observer
{
    internal class Usuario : IObservador
    {
        private readonly string nombreRedSocial;
        
        public Usuario(string nombreRedSocial)
        {
            this.nombreRedSocial = nombreRedSocial;
        }

        public void ActualizarNotificacion(string actualizacion)
        {
            Console.WriteLine($"Hola {nombreRedSocial}, has recibido una nueva actualización:{actualizacion}");
        }
    }
}
