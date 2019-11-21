using System;
using System.Collections.Generic;
using System.Text;

namespace State.ComDesignPattern
{
    public class EmAprovacao : IStatusOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor * 0.95;
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.Status = new Aprovado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.Status = new Reprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Nao e possivel Finalizar um Orcamento em Aprovacao");
        }

    }
}
