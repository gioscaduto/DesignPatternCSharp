using Decorator.ComDesignPattern;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ComDesignPattern();
        }

        static void ComDesignPattern()
        {
            Orcamento orcamento = new Orcamento(500);

            Console.WriteLine($"Valor do Orcamento: R$ {orcamento.Valor}");
            Console.WriteLine();

            Imposto icms = new ICMS();
            Imposto ipi = new IPI();
            Imposto iss = new ISS();

            //Impostos Separados
            var valorIcms = icms.Calcular(orcamento);
            var valorIpi = ipi.Calcular(orcamento);
            var valorIss = iss.Calcular(orcamento);

            Console.WriteLine($"Valor do ICMS: R$ {valorIcms}");
            Console.WriteLine($"Valor do IPI: R$ {valorIpi}");
            Console.WriteLine($"Valor do ISS: R$ {valorIss}");
            Console.WriteLine();

            //Impostos Juntos
            Imposto icmsComIpi = new ICMS(new IPI());
            Imposto ipiComIss = new IPI(new ISS());
            Imposto icmsComIpiComIss = new ICMS(new IPI(new ISS()));

            var valorICMScomIpi = icmsComIpi.Calcular(orcamento);
            var valorIpicomIss = ipiComIss.Calcular(orcamento);
            var valorICMScomIpiComIss = icmsComIpiComIss.Calcular(orcamento);

            Console.WriteLine($"Valor do ICMS Com Ipi: R$ {valorICMScomIpi}");
            Console.WriteLine($"Valor do IPI com ISS: R$ {valorIpicomIss}");
            Console.WriteLine($"Valor do ICMS Com IPI e ISS: R$ {valorICMScomIpiComIss}");

            Console.ReadKey();
        }
    }
}
