using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComDesignPattern
{
    public class IPI : Imposto
    {
        public IPI(Imposto outroImposto) : base(outroImposto){}
        public IPI() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.12 + CalculoDoOutroImposto(orcamento);
        }
    }
}
