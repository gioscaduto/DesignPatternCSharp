using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Multiplicao: Operacao
    {
        public Multiplicao(IExpressao esquerda, IExpressao direita) : base(esquerda, direita) { }

        public override void Aceitar(IVisitor impressora)
        {
            impressora.VisitaMultiplicacao(this);
        }

        public override int Avaliar()
        {
            return ObterValorEsquerda() * ObterValorDireita();
        }
    }
}
