using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ImpresoraVisitor: IVisitor
    {
        public void VisitaSoma(Soma soma)
        {
            Console.Write("( ");
            soma.Esquerda.Aceitar(this);
            Console.Write(" + ");
            soma.Direita.Aceitar(this);
            Console.Write(" )");
        }

        public void VisitaSubtracao(Subtracao subtracao)
        {
            Console.Write("( ");
            subtracao.Esquerda.Aceitar(this);
            Console.Write(" - ");
            subtracao.Direita.Aceitar(this);
            Console.Write(" )");
        }

        public void VisitaDivisao(Divisao  divisao)
        {
            Console.Write("( ");
            divisao.Esquerda.Aceitar(this);
            Console.Write(" / ");
            divisao.Direita.Aceitar(this);
            Console.Write(" )");
        }

        public void VisitaMultiplicacao(Multiplicao multiplicao)
        {
            Console.Write("( ");
            multiplicao.Esquerda.Aceitar(this);
            Console.Write(" * ");
            multiplicao.Direita.Aceitar(this);
            Console.Write(" )");
        }

        public void VisitaNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
