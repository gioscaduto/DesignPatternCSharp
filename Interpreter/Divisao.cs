using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Divisao: Operacao
    {
        public Divisao(IExpressao esquerda, IExpressao direita) : base(esquerda, direita) { }

        public override int Avaliar()
        {
            try
            {
                return ObterValorEsquerda() / ObterValorDireita();
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }
    }
}
