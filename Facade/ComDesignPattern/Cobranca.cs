using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ComDesignPattern
{
    public class Cobranca
    {
        public Cobranca(TipoCobranca tipoCobranca, Fatura fatura)
        {
            TipoCobranca = tipoCobranca;
            Fatura = fatura;
        }

        public TipoCobranca TipoCobranca { get; private set; }
        public Fatura Fatura { get; private set; }

        public void Emitir()
        {
            Console.WriteLine("Emitindo cobrança");
        }
    }
}
