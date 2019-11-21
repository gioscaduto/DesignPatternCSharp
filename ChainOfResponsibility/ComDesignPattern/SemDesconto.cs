using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ComDesignPattern
{
    public class SemDesconto : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}
