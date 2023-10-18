using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Interpreter.Interpreter
{
    internal class Numero : IExpresion
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int Evaluar()
        {
            return valor;
        }
    }
}
