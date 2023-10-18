using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_State.State
{
    internal class ModoCalentar : ITermostato
    {
        public void AumentarTemperatura()
        {
            Console.WriteLine("La temperatura esta aumentando en modo calentar");
        }

        public void MostrarEstado()
        {
            Console.WriteLine("Termostato en modo calentar");
        }

        public void ReducirTemperatura()
        {
            Console.WriteLine("La temperatura esta reduciendo en modo calentar");
        }
    }
}

