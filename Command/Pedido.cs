using System;

namespace Command
{
    public class Pedido
    {
        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = Status.Novo;
        }

        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime DtFinalizacao { get; private set; }

        public Status Status { get; private set; }

        public void Pagar()
        {
            Status = Status.Pago;
        }

        public void Finalizar()
        {
            Status = Status.Entregue;
            DtFinalizacao = DateTime.Now;
        }
    }
}
