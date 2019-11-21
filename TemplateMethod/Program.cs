using System;
using TemplateMethod.ComDesignPattern;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ComDesignPattern();
        }

        static void ComDesignPattern()
        {
            Orcamento orcamento = new Orcamento(300);

            IImposto ipi = new IPI();
            IImposto iss = new ISS();

            var valorIpi = ipi.Calcular(orcamento);
            var valorIss = iss.Calcular(orcamento);

            Console.WriteLine($"Valor Orçamento: R$ {orcamento.Valor}, Valor IPI: R$ {valorIpi}, Valor ISS: R$ {valorIss}");
        }
    }
}
