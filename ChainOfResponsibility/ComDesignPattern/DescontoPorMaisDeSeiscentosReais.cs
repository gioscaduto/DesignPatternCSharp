using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ComDesignPattern
{
    public class DescontoPorMaisDeSeiscentoReais: IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor > 600)
                return orcamento.Valor * 0.07;

            return ProximoDesconto.Descontar(orcamento);
        }
    }
}
