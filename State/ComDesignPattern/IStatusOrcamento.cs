using System;
using System.Collections.Generic;
using System.Text;

namespace State.ComDesignPattern
{
    public interface IStatusOrcamento
    {
        void AplicarDesconto(Orcamento orcamento);

        void Aprovar(Orcamento orcamento);
        void Reprovar(Orcamento orcamento);
        void Finalizar(Orcamento orcamento);
    }
}
