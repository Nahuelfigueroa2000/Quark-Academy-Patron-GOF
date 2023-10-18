using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Composite.Composite
{
    internal class Directorio: ISistemaComponente
    {
        private string nombre;
        private List<ISistemaComponente> componentes = new List<ISistemaComponente>();

        public Directorio(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarComponente(ISistemaComponente componente)
        {
            componentes.Add(componente);
        }

        public void Pantalla()
        {
            Console.WriteLine($"Directorio: {nombre}");
            foreach (var componente in componentes)
            {
                componente.Pantalla();
            }
        }

        public int Tamanio()
        {
            int totalTamanio = 0;
            foreach (var componente in componentes)
            {
                totalTamanio += componente.Tamanio();
            }
            return totalTamanio;
        }
    }
}
