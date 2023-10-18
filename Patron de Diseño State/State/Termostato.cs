using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_State.State
{
    internal class Termostato
    {
        public ITermostato termostato;
        
        public Termostato() 
        {
            termostato = new ModoApagado();
        }

        public void CambiarModoCalentar()
        {
            termostato = new ModoCalentar();
        }

        public void CambiarModoEnfriar()
        {
            termostato = new ModoEnfriar();
        }

        public void Apagar()
        {
            termostato = new ModoApagado();
        }

        public void AumentarTemperatura()
        {
            termostato.AumentarTemperatura();
        }

        public void ReducirTemperatura()
        {
            termostato.ReducirTemperatura();
        }

        public void MostrarEstado()
        {
            termostato.MostrarEstado();
        }
        

    }
}
