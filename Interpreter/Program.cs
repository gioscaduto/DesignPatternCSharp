using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Interpreter 
             * Usado para avaliar uma arvore de Expressoes

               EXEMPLO COM UMA EXPRESSAO MATEMATICA:

                ( 2 + 30 ) + ( 35 - 15)
                           +        
                    +             -
                  2 e 30       35 e 15
              (Resultado: 32) (Resultado: 20)

            */


            IExpressao esquerda;
            IExpressao direita;
            IExpressao soma;

            esquerda = new Soma(new Numero(2), new Numero(30)); // ( 2 + 30 ) = 32
            direita = new Subtracao(new Numero(35), new Numero(15)); // ( 35 - 15 ) = 20

            soma = new Soma(esquerda, direita); // ( 32 ) + ( 20 )

            Console.WriteLine($" ( 2 + 30 ) + ( 35 - 15 ) = {soma.Avaliar()}");
            Console.WriteLine();

            // AUMENTANDO A COMPLEXIDADE
            // ( ( ( 2 + 20 ) + ( 20 - 10 ) ) * 4 )  / 2 

            esquerda = new Soma(new Numero(2), new Numero(20));
            direita = new Subtracao(new Numero(20), new Numero(10));

            soma = new Soma(esquerda, direita); // (2 + 20) + (20 - 10) = 32

            IExpressao multiplicao = new Multiplicao(soma, new Numero(4)); // 32 * 4

            IExpressao divisao = new Divisao(multiplicao, new Numero(2)); // ( 32 * 4 ) / 2

            Console.WriteLine($" ( ( ( 2 + 20 ) + ( 20 - 10 ) ) * 4 ) / 2 = {divisao.Avaliar()}");

            Console.ReadKey();
        }
    }
}
