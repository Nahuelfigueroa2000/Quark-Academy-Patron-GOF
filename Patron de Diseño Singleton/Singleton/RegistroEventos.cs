using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Singleton.Singleton
{
    internal class RegistroEventos
    {
        // Constructor privado para evitar la creación de instancias
        private RegistroEventos()
        {
            // Constructor privado vacío
        }

        public void RegistrarEvento(string evento)
        {
            Console.WriteLine($"Evento registrado: {evento}");
        }

        private static RegistroEventos instancia;

        public static RegistroEventos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RegistroEventos();
                }
                return instancia;
            }
        }
    }
}
