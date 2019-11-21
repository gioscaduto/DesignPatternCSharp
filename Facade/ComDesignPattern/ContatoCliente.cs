using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ComDesignPattern
{
    public class ContatoCliente
    {
        public Cliente Cliente { get; private set; }
        public Cobranca Cobranca { get; private set; }

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            Cliente = cliente;
            Cobranca = cobranca;
        }

        public void Enviar()
        {
            Console.WriteLine("Enviando a cobrança para o cliente");
        }
    }
}
