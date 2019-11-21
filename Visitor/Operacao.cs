using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Operacao : IExpressao
    {
        public IExpressao Esquerda { get; protected set; }
        public IExpressao Direita { get; protected set; }

        protected Operacao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        protected int ObterValorEsquerda()
        {
            return Esquerda.Avaliar();
        }

        protected int ObterValorDireita()
        {
            return Direita.Avaliar();
        }

        public abstract int Avaliar();

        public abstract void Aceitar(IVisitor impressora);
    }
}
