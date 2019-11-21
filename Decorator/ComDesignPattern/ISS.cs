using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComDesignPattern
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto){ }
        public ISS() : base() { }
        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.14 + CalculoDoOutroImposto(orcamento);
        }
    }
}
