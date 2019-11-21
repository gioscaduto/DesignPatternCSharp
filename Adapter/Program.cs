using System;
using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    class Program
    {
        /* Adapter
         * Exemplo Biblioteca que gera XML
         * Objetivo isolar um codigo de biblioteca ou sistema legado para adaptar ao meu projeto
         * A implementacao do Adapter se parece com a do Command e Strategy
         * Adapter: Utilizado para adaptar um codigo que nao pode ser modificado (Por exemplo: Biblioteca ou Sistema Legado).
         *          Adaptar uma interface de um sistema antigo para que ela  se encaixe em um sistema novo.
         * Command: Guardar um codigo para ser executado posteriormente
         * Strategy: Utilizar diferentes estategias para resolver um problema
         */
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "João";
            cliente.Endereco = "Avenida Paulista";
            cliente.DtNascimento = DateTime.Now;

            string xml = new GeradorXml().GerarXml(cliente);

            Console.WriteLine(xml);
            Console.ReadKey();
        }
    }
}
