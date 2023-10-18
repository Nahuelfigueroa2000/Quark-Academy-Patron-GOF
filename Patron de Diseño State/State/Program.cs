using Patron_de_Diseño_State.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Termostato termostato = new Termostato();
            termostato.CambiarModoCalentar();
            termostato.MostrarEstado();
            termostato.AumentarTemperatura();
            termostato.ReducirTemperatura();
            Console.WriteLine("--------------------------");
            termostato.CambiarModoEnfriar();
            termostato.MostrarEstado();
            termostato.AumentarTemperatura();
            termostato.ReducirTemperatura();
            Console.WriteLine("--------------------------");
            termostato.Apagar();
            termostato.MostrarEstado();
            termostato.AumentarTemperatura();
            termostato.ReducirTemperatura();
            Console.ReadKey();
            
        }
    }
}
