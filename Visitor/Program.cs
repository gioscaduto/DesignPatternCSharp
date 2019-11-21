using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Visitor 
               Usado para visitar e realizar o processamento em cada parte(nó) de uma arvore de Expressoes

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
            Console.WriteLine(soma.Avaliar()); 


            ImpresoraVisitor impressora = new ImpresoraVisitor();
            soma.Aceitar(impressora); // ( ( 2 + 30 ) + ( 35 - 15 ) )

            Console.ReadKey();
        }
    }
}
