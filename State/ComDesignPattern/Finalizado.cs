using System;
using System.Collections.Generic;
using System.Text;

namespace State.ComDesignPattern
{
    public class Finalizado : IStatusOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            throw new Exception("Orcamento Finalizado nao pode receber desconto");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
    }
}
