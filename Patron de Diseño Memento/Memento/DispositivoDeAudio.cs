using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Memento.Memento
{
    internal class DispositivoDeAudio
    {
        private int volumen;
        
        private List<Memento> mementos = new List<Memento>();

        public DispositivoDeAudio()
        {
            volumen = 1;
        }

        public int ObtenerVolumen()
        {
            return volumen;
        }

        public void EstablecerVolumen(int nuevoVolumen)
        {
            mementos.Add(new Memento(volumen));
            volumen = nuevoVolumen;
        }

        
        public void RestaurarEstado(int indice)
        {
            if (indice >= 0 && indice < mementos.Count)
            {
                volumen = mementos[indice].Volumen;
            }
        }
    }
}
