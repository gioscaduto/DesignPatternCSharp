using System;
using System.Collections.Generic;
using System.Text;

namespace State.ComDesignPattern
{
    public class Reprovado : IStatusOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            throw new Exception("Orcamento Reprovado nao pode receber desconto");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta reprovado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta reprovado");
        }
        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta reprovado");
        }
    }
}
