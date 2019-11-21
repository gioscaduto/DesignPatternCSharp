using System;

namespace Builder.ComDesignPattern
{
    public static class ExemploDesignPattern
    {
        public static void Executar()
        {
            NotaFiscalBuilder criadorNotaFiscal = new NotaFiscalBuilder();

            criadorNotaFiscal
                .AdicionarEmpresa("Empresa A")
                .AdicionarCnpj("00.000.000/1234-12")
                .AdicionarItem(new ItemNotaFiscal("Televisao", 800))
                .AdicionarItem(new ItemNotaFiscal("NoteBook", 2000))
                .NaDataAtual()
                .AdicionarObs("Observacao");

            NotaFiscal notaFiscal = criadorNotaFiscal.Construir();

            Console.WriteLine($"Valor Bruto da Nota Fiscal: R$ {notaFiscal.ValorBruto}");
            Console.WriteLine($"Valor dos Impostos da Nota Fiscal: R$ {notaFiscal.Impostos}");
        }
    }
}
