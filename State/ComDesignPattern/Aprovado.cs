using System;
using System.Collections.Generic;
using System.Text;

namespace State.ComDesignPattern
{
    public class Aprovado : IStatusOrcamento
    {
        public void AplicarDesconto(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor * 0.98;
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta Aprovado");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta Aprovado, nao pode  ser Reprovado");
        }
        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Status = new Finalizado();
        }
    }
}
