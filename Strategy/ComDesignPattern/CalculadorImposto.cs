using System;

namespace Strategy.ComDesignPattern
{
    public class CalculadorImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var valorImposto = imposto.Calcular(orcamento);

            Console.WriteLine($"Valor do orçamento: R$ {orcamento.Valor}, Valor do imposto: R$ {valorImposto}.");
        }
    }
}
