using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ComDesignPattern
{
    public class EnviadorEmail : IAcaoAposGerarNota
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Enviando Nota Fiscal por Email");
        }
    }
}
