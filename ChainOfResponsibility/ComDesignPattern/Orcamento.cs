using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ComDesignPattern
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
