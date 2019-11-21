using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ComDesignPattern
{
    public interface IDesconto
    {
        double Descontar(Orcamento orcamento);
        
        IDesconto ProximoDesconto { get; set; }
    }
}
