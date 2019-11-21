using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ComDesignPattern
{
    public interface IAcaoAposGerarNota
    {
        void Executar(NotaFiscal nf);
    }
}
