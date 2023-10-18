using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patron_de_diseño_Composite.Composite
{
    internal class Archivo : ISistemaComponente
    {
        private string nombre;
        private int tamanio;

        public Archivo(string nombre,int tamanio) 
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public void Pantalla()
        {
            Console.WriteLine($"Archivo: {nombre}");
        }

        public int Tamanio()
        {
            return tamanio;
        }
    }
}
