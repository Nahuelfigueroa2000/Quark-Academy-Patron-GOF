using Patron_de_Diseño_ChainOfResponsability.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_ChainOfResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var supervisor = new Supervisor();
            var gerente = new Gerente();
            var director = new Director();
            

            supervisor.EstablacerSiguiente(gerente);
            gerente.EstablacerSiguiente(director);

            var C = new Solicitud();
            double importe = 1;
            while(importe != 0)
            {
                Console.WriteLine("Ingrese el importa para acordar, para terminar el programa (0)");
                importe = double.Parse(Console.ReadLine());
                C.Importe = importe;
                supervisor.Procesar(C);
            }
            Console.ReadKey();
        }
    }
}
