using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.SemDesignPattern
{
    public class IPI : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            /*Logica de Calculo Similar ao Imposto ISS, verifica se o valor do orcamento esta acima de 600 reais,
             * se sim (Taxacao Maxima), se nao (Taxacao Minima)
             */
            if (orcamento.Valor >= 600 && HaItemValorMaiorQue200Reais(orcamento))
                return orcamento.Valor * 0.03;

            return orcamento.Valor * 0.01;
        }

        public bool HaItemValorMaiorQue200Reais(Orcamento orcamento)
        {
            return orcamento.Itens
                            .Any(i => i.Valor > 200);
        }
    }
}
