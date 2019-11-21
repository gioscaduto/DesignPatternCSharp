using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.SemDesignPattern
{
    public class ISS: IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            /*Logica de Calculo Similar ao Imposto IPI, verifica se o valor do orcamento esta acima de 600 reais,
             * se sim (Taxacao Maxima), se nao (Taxacao Minima)
             */
            if (orcamento.Valor >= 600)
                return orcamento.Valor * 0.1;

            return orcamento.Valor * 0.08;
        }
    }
}
