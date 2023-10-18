using Patron_De_Diseño_Abstract_Factory.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_De_Diseño_Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FabricaAutomoviles fabricaAutomoviles = new FabricaAutomoviles();
            fabricaAutomoviles.CrearAutomovil();
            FabricaMotos fabricaMotos = new FabricaMotos();
            fabricaMotos.CrearMoto();
            Console.ReadKey();
        }
    }
}
