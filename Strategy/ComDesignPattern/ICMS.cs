using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.ComDesignPattern
{
    public class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
