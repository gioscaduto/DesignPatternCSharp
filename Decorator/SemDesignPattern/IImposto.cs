using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.SemDesignPattern
{
    public interface IImposto
    {
        double Calcular(Orcamento orcamento);
    }
}
