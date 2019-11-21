using System;

namespace Strategy.ComDesignPattern
{
    public class IPI : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.12;
        }
    }
}
