using ChainOfResponsibility.ComDesignPattern;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ComDesignPattern(); 
        }

        static void ComDesignPattern()
        {
            CalculadorDescontos calculadorDescontos = new CalculadorDescontos();

            Orcamento orcamento = new Orcamento(560.5);

            orcamento.AdicionarItem(new Item("Televisor", 400));
            orcamento.AdicionarItem(new Item("Antena", 40));
            orcamento.AdicionarItem(new Item("Cabo", 20));
            orcamento.AdicionarItem(new Item("Receptor", 100));
            orcamento.AdicionarItem(new Item("Conector", 0.5));

            double desconto = calculadorDescontos.Calcular(orcamento);
            Console.WriteLine($"Valor do Orçamento: R$ {orcamento.Valor}, Qtd de Itens: {orcamento.Itens.Count}, Valor do Desconto: R$ {desconto}");
            Console.ReadKey();
        }
    }
}
