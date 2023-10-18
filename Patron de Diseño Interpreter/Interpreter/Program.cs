using Patron_de_Diseño_Interpreter.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una expresión matemática '5 + 3 - 2'");
            string expresionMatematica = Console.ReadLine();

            Parser parser = new Parser(expresionMatematica);
            int resultado = parser.Evaluar();

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
        }
    }
}
