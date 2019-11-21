using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.ComDesignPattern
{
    public class Orcamento
    {
        public Orcamento(double valor) => Valor = valor;

        public double Valor { get; private set; }
    }
}
