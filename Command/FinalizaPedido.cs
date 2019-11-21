
using System;

namespace Command
{
    public class FinalizaPedido: IComando
    {
        private Pedido pedido;
        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executar()
        {
            Console.WriteLine($"Finalizando o pedido do cliente: {pedido.Cliente}");
            pedido.Finalizar();
        }
    }
}
