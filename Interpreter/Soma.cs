using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Soma: Operacao
    {
        public Soma(IExpressao esquerda, IExpressao direita): base(esquerda, direita){}

        public override int Avaliar()
        {
            return ObterValorEsquerda() + ObterValorDireita();
        }
    }
}
