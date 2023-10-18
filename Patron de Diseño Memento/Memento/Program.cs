using Patron_de_Diseño_Memento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DispositivoDeAudio dispositivoDeAudio = new DispositivoDeAudio();

            Console.WriteLine("Volumen Actual: " + dispositivoDeAudio.ObtenerVolumen());
            dispositivoDeAudio.EstablecerVolumen(45);
            Console.WriteLine("Volumen Actual: " + dispositivoDeAudio.ObtenerVolumen());
            dispositivoDeAudio.EstablecerVolumen(75);
            Console.WriteLine("Volumen Actual: " + dispositivoDeAudio.ObtenerVolumen());
            dispositivoDeAudio.EstablecerVolumen(25);
            Console.WriteLine("Volumen Actual: " + dispositivoDeAudio.ObtenerVolumen());

            dispositivoDeAudio.RestaurarEstado(0);
            Console.WriteLine("Volumen Actual: " + dispositivoDeAudio.ObtenerVolumen());
            Console.ReadKey();

        }
    }
}
