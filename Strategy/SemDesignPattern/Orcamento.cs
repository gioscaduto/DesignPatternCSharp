using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.SemDesignPattern
{
    public class Orcamento
    {
        public Orcamento(double valor) => Valor = valor;

        public double Valor { get; private set; }
    }
}
