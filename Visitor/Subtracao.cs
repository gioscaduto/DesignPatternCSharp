using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Subtracao: Operacao
    {
        public Subtracao(IExpressao esquerda, IExpressao direita): base(esquerda, direita){}

        public override void Aceitar(IVisitor impressora)
        {
            impressora.VisitaSubtracao(this);
        }

        public override int Avaliar()
        {
            return ObterValorEsquerda() - ObterValorDireita();
        }
    }
}
