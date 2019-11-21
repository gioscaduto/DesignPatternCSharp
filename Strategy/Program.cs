using Strategy.ComDesignPattern;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ComDesignPattern();
        }

        static void ComDesignPattern()
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto ipi = new IPI();

            Orcamento orcamento = new Orcamento(1000);

            CalculadorImposto calculador = new CalculadorImposto();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, ipi);
        }
    }
}
