using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ComDesignPattern
{
    public class ItemNotaFiscal
    {
        public ItemNotaFiscal(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; private set; }
        public double Valor { get; private set; }
    }
}
