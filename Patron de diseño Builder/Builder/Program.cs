using Patron_de_diseño_Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedidoBuilder builder = new PedidoBuilder();
            Pedido pedido = builder
                .EstablecerNumeroPedido(123)
                .EstablecerNombreCliente("Nahuel")
                .EstablacerProductos("arroz")
                .EstablacerProductos("pollo")
                .EstablacerProductos("Fideos")
                .EstablecerDireccionCliente("Calle Principal")
                .EstablacerNumeroDeDireccion(504)
                .Construir();

            pedido.MostrarPedido();
            Console.ReadKey();  
        }
    }
}
