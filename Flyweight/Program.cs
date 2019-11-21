
using Flyweight.ComDesignPattern;
using Flyweight.SemDesignPattern;
using System;

namespace Flyweight
{
    /* Aplicacao para tocar musicas 
     */
    class Program
    {
        static void Main(string[] args)
        {
            ExemploDesignPattern.Executar();
            ExemploSemDesignPattern.Executar();

            Console.ReadKey();
        }
    }
}
