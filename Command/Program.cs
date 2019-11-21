using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Command
             * Utilizado para Criar uma Lista de Comandos A serem executados posteriormente
             * Exemplo
             * Uma fila de processamento que executa os comandos em cima dos pedidos
             */

            FilaDeTrabalho filaDeTrabalho = new FilaDeTrabalho();

            Pedido pedidoJoao = new Pedido("João", 900.00);
            Pedido pedidoGiovanni = new Pedido("Giovanni", 1000.99);

            filaDeTrabalho.Adicionar(new PagaPedido(pedidoJoao));
            filaDeTrabalho.Adicionar(new FinalizaPedido(pedidoJoao));

            filaDeTrabalho.Adicionar(new PagaPedido(pedidoGiovanni));

            filaDeTrabalho.Processar();

            Console.ReadKey();
        }
    }
}
