using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.SemDesignPattern
{
    public static class ExemploSemDesignPattern
    {
        /* Codigo pode se tornar complexo 
         * O Metodo possui muitas responsabilidades
         * Esta sendo realizado os calculos de Valor Total, Impostos e no mesmo metodo os itens sao adicionados
         * O Construtor da Nota Fiscal possui muitos parametros
         */
        public static void Executar()
        {
            IList<ItemNotaFiscal> itens = new List<ItemNotaFiscal>();

            itens.Add(new ItemNotaFiscal("Televisao", 800));
            itens.Add(new ItemNotaFiscal("NoteBook", 2000));

            double valorTotal = itens.Sum(i => i.Valor);
            double impostos = valorTotal * 0.10;


            NotaFiscal nf = new NotaFiscal("Empresa A", "00.000.000/1234-12", DateTime.Now, valorTotal, impostos, itens, "Observacao");
        }
    }
}
