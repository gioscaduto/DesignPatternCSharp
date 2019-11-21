using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.ComDesignPattern
{
    public class IPI : TemplateImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 600 && HaItemValorMaiorQue200Reais(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.03;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
           return orcamento.Valor * 0.01;
        }

        public bool HaItemValorMaiorQue200Reais(Orcamento orcamento)
        {
            return orcamento.Itens
                            .Any(i => i.Valor > 200);
        }
    }
}
