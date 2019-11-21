
using System;

namespace Command
{
    public class PagaPedido: IComando
    {
        private Pedido pedido;
        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executar()
        {
            Console.WriteLine($"Pagando o pedido do cliente: {pedido.Cliente}");
            pedido.Pagar();
        }
    }
}
