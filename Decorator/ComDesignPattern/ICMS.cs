using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComDesignPattern
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto){}
        public ICMS() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento); ;
        }
    }
}
