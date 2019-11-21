using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Numero: IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int numero)
        {
            Valor = numero;
        }

        public int Avaliar()
        {
            return Valor;
        }

        public void Aceitar(IVisitor impressora)
        {
            impressora.VisitaNumero(this);
        }
    }
}
