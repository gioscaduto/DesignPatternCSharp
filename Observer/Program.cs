using Observer.ComDesignPattern;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ComDesignPattern();
            Console.ReadKey();
        }

        static void ComDesignPattern()
        {
            NotaFiscalBuilder criadorNotaFiscal = new NotaFiscalBuilder();

            criadorNotaFiscal
                .AdicionarEmpresa("Empresa A")
                .AdicionarCnpj("00.000.000/1234-12")
                .AdicionarItem(new ItemNotaFiscal("Televisao", 800))
                .AdicionarItem(new ItemNotaFiscal("NoteBook", 2000))
                .NaDataAtual()
                .AdicionarObs("Observacao");

            criadorNotaFiscal.AdicionarAcao(new EnviadorEmail());
            criadorNotaFiscal.AdicionarAcao(new NotaFiscalDAL());
            criadorNotaFiscal.AdicionarAcao(new EnviadorSMS());

            NotaFiscal notaFiscal = criadorNotaFiscal.Construir();

            Console.WriteLine($"Valor Bruto da Nota Fiscal: R$ {notaFiscal.ValorBruto}");
            Console.WriteLine($"Valor dos Impostos da Nota Fiscal: R$ {notaFiscal.Impostos}");
        }
    }
}
