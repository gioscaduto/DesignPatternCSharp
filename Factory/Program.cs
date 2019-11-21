using Factory.ComDesignPattern;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ComDesignPattern();
        }

        static void ComDesignPattern()
        {
            var notaFiscalDAL = new NotaFiscalDAL();
            notaFiscalDAL.Inserir();
        }
    }
}
