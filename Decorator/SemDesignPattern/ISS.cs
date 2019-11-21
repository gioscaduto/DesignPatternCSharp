using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.SemDesignPattern
{
    public class ISS: IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.14;
        }
    }
}
