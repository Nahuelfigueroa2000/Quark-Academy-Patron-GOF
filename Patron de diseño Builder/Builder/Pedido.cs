using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Builder.Builder
{
    internal class Pedido
    {
        public string Cliente {get; set;}
        public int NumeroPedido {get; set;}
        public string DireccionCliente {get; set;}
        public int NumeroDireccion {get; set;}
        public List<String> Productos {get; set;}

        public void MostrarPedido()
        {
            Console.WriteLine($"Nombre del Cliente es: {Cliente}");
            Console.WriteLine($"Numero del pedido es: {NumeroPedido}");
            foreach (var producto in Productos)
            {
                Console.WriteLine($" - {producto}");
            }
            Console.WriteLine($"Entregar el pedido ya pago en esta direccion del cliente: {DireccionCliente} y el numero es: {NumeroDireccion}");
        }



    }
}
