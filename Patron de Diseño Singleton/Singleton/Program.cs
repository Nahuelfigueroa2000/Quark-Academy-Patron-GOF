using Patron_de_Diseño_Singleton.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistroEventos registro= RegistroEventos.Instancia;
            RegistroEventos registro1 = RegistroEventos.Instancia;

            Console.WriteLine($"RegistroEventos y RegistroEventos1 son la misma instancia: {registro == registro1}");
            registro.RegistrarEvento("Evento nuevo");
            registro1.RegistrarEvento("Evento importante");
            Console.ReadKey();

        }
    }
}
