using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ComDesignPattern
{
    public class Fatura
    {
        public Fatura(Cliente cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

        public Cliente Cliente { get; private set; }
        public double Valor { get; private set; }
    }
}
