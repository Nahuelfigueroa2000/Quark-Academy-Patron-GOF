using Patron_de_Diseño_Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstrategiaDefensiva estrategiaDefensiva = new EstrategiaDefensiva();
            EstrategiaEconomica estrategiaEconomica = new EstrategiaEconomica();
            EstrategiaOfensiva estrategiaOfensiva = new EstrategiaOfensiva();

            string linea;
            bool cerrarPrograma = false;

            do
            {
                Planilla();

                linea = Console.ReadLine();
                int opcion = int.Parse(linea);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elegiste la Estrategia Defensiva");
                        estrategiaDefensiva.EjecutarTacticas();
                        break;
                    case 2:
                        Console.WriteLine("Elegiste la Estrategia Ofensiva");
                        estrategiaOfensiva.EjecutarTacticas();
                        break;
                    case 3:
                        Console.WriteLine("Elegiste la Estrategia Económica");
                        estrategiaEconomica.EjecutarTacticas();
                        break;
                    default:
                        Console.WriteLine("Error: Opción no válida, no elegiste ninguna estrategia.");
                        break;
                }

                if (!cerrarPrograma)
                {
                    Console.Write("¿Quieres cambiar de estrategia? (Si/No): ");
                    string respuesta = Console.ReadLine();

                    if (respuesta.ToLower() != "si")
                    {
                        cerrarPrograma = true;
                        Console.WriteLine("Cerro el programa");
                    }
                }
            } while (!cerrarPrograma);

            Console.ReadKey();
        }

        public static void Planilla()
        {
            Console.WriteLine("Bienvenido al Juego de elegir una estrategia de combate");
            Console.WriteLine(@"Elegir la estretegia que quieras implementar:
            1-Estrategia Defensiva
            2-Estrategia Ofensiva
            3-Estrategia Economica");
        }
    }
}
