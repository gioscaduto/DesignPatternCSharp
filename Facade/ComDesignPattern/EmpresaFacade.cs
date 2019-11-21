using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ComDesignPattern
{
    public class EmpresaFacade
    {
        public Cliente BuscarCliente(string cpf)
        {
            return new ClienteDAL().BuscarPorCpf(cpf);
        }

        public Fatura CriarFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GerarCobranca(TipoCobranca tipoCobranca, Fatura fatura)
        {
            var cobranca = new Cobranca(tipoCobranca, fatura);
            cobranca.Emitir();
            return cobranca;
        }

        public ContatoCliente RealizarContato(Cliente cliente, Cobranca cobranca)
        {
            var contato = new ContatoCliente(cliente, cobranca);
            contato.Enviar();
            return contato;
        }
    }
}
