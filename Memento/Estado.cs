using System;

namespace Memento
{
    public class Estado
    {
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }
        
        //Data da Alteracao do Estado
        public DateTime DtAlteracao => DateTime.Now;

        public Contrato Contrato { get; private set; }
    }
}
