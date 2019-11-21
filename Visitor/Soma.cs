using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Soma: Operacao
    {
        public Soma(IExpressao esquerda, IExpressao direita): base(esquerda, direita){}

        public override void Aceitar(IVisitor impressora)
        {
            impressora.VisitaSoma(this);
        }

        public override int Avaliar()
        {
            return ObterValorEsquerda() + ObterValorDireita();
        }

    }
}
