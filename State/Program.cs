using State.ComDesignPattern;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ComDesignPattern();
        }

        static void ComDesignPattern()
        {
            try
            {
                Orcamento orcamento = new Orcamento(1000);

                Console.WriteLine($"Valor do Orcamento: R$ {orcamento.Valor}");
                Console.WriteLine();

                //Orcamento Com Status Em Aprovacao
                orcamento.AplicarDesconto();
                Console.WriteLine($"Valor do Orcamento Com Desconto (Em Aprovacao): R$ {orcamento.Valor}");
                Console.WriteLine();

                //Orcamento Com Status Aprovado
                orcamento.Aprovar();
                orcamento.AplicarDesconto();
                Console.WriteLine($"Valor do Orcamento Com Desconto (Aprovado): R$ {orcamento.Valor}");
                Console.WriteLine();

                orcamento.Finalizar();

                //Erro
                orcamento.Finalizar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
