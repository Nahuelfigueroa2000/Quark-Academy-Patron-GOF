using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Interpreter.Interpreter
{
    internal class Resta : IExpresion
    {
        private IExpresion izquierda;
        private IExpresion derecha;

        public Resta(IExpresion izquierda, IExpresion derecha)
        {
            this.izquierda = izquierda;
            this.derecha = derecha;
        }

        public int Evaluar()
        {
            return izquierda.Evaluar() - derecha.Evaluar();
        }
    }
}
