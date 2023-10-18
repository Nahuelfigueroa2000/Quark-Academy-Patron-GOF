using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_diseño_Builder.Builder
{
    internal class PedidoBuilder
    {
        private Pedido pedido = new Pedido();

        public PedidoBuilder EstablecerNumeroPedido(int numeroPedido)
        {
            pedido.NumeroPedido = numeroPedido;
            return this;
        }

        public PedidoBuilder EstablecerNombreCliente(string Cliente)
        {
            pedido.Cliente = Cliente;
            return this;
        }

        public PedidoBuilder EstablecerDireccionCliente(string Direccion)
        {
            pedido.DireccionCliente = Direccion;
            return this;
        }

        public PedidoBuilder EstablacerNumeroDeDireccion(int NumDireccion)
        {
            pedido.NumeroDireccion = NumDireccion;
            return this;
        }

        public PedidoBuilder EstablacerProductos(string producto)
        {
            if (pedido.Productos == null)
            {
                pedido.Productos = new List<string>();
            }
            pedido.Productos.Add(producto);
            return this;
        }

        public Pedido Construir()
        {
            return pedido;
        }
    }
}
