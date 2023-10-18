using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Interpreter.Interpreter
{
    internal class Parser
    {
        private IExpresion expresion;

        public Parser(string expresionMatematica)
        {
            expresion = ParseExpresion(expresionMatematica);
        }

        private IExpresion ParseExpresion(string expresionMatematica)
        {
            // Implementa la lógica para analizar la cadena y crear la estructura de objetos.
            // En este ejemplo, asumiremos una cadena simple: "5 + 3 - 2".
            IExpresion izquierda = new Numero(5);
            IExpresion derecha = new Resta(new Numero(3), new Numero(2));
            return new Suma(izquierda, derecha);
        }

        public int Evaluar()
        {
            return expresion.Evaluar();
        }
    }
}
