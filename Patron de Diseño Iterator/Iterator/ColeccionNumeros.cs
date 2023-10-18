using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Iterator.Iterator
{
    internal class ColeccionNumeros
    {
        private List<int> numeros = new List<int>();

        public void AgregarNumero(int numero)
        {
            numeros.Add(numero);
        }

        public ITerador ObtenerIterador()
        {
            return new IteradorNumeros(this);
        }

        public int ObtenerNumero(int indice)
        {
            return numeros[indice];
        }

        public int ContarNumeros()
        {
            return numeros.Count;
        }
    }
}
