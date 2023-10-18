using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_Diseño_Iterator.Iterator
{
    internal class IteradorNumeros : ITerador
    {
        private ColeccionNumeros coleccion;
        private int indice;

        public IteradorNumeros(ColeccionNumeros coleccion)
        {
            this.coleccion = coleccion;
            this.indice = 0;
        }

        public int Siguiente()
        {
            int numero = coleccion.ObtenerNumero(indice);
            indice++;
            return numero;
        }

        public bool TieneSiguiente()
        {
            return indice < coleccion.ContarNumeros();
        }
    }
}
