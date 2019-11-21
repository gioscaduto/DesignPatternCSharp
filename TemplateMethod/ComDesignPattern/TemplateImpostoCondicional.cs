using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.ComDesignPattern
{
    public abstract class TemplateImpostoCondicional: IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
