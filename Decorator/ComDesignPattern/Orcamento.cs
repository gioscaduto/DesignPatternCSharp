using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComDesignPattern
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
