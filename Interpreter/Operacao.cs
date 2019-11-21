using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public abstract class Operacao : IExpressao
    {
        protected IExpressao esquerda;
        protected IExpressao direita;

        protected Operacao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        protected int ObterValorEsquerda()
        {
            return this.esquerda.Avaliar();
        }

        protected int ObterValorDireita()
        {
            return this.direita.Avaliar();
        }

        public abstract int Avaliar();
    }
}
