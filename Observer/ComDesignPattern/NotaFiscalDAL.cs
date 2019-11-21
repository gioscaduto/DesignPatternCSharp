using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ComDesignPattern
{
    public class NotaFiscalDAL : IAcaoAposGerarNota
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Salvando no Banco de Dados a Nota Fiscal");
        }
    }
}
