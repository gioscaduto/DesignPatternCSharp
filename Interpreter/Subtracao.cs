using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Subtracao: Operacao
    {
        public Subtracao(IExpressao esquerda, IExpressao direita): base(esquerda, direita){}

        public override int Avaliar()
        {
            return ObterValorEsquerda() - ObterValorDireita();
        }
    }
}
