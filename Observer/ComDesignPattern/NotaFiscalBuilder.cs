using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ComDesignPattern
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Obs { get; private set; }
        public DateTime DataEmissao { get; private set; }

        private double valorBruto;
        private double impostos;
        private IList<ItemNotaFiscal> itens = new List<ItemNotaFiscal>();

        private IList<IAcaoAposGerarNota> acoesSeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscal Construir()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, valorBruto, impostos, itens, Obs);

            foreach (var acao in acoesSeremExecutadas)
            {
                acao.Executar(nf);
            } 

            return nf;
        }

        public void AdicionarAcao(IAcaoAposGerarNota acao)
        {
            acoesSeremExecutadas.Add(acao);
        }
            
        public NotaFiscalBuilder AdicionarEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder AdicionarCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder AdicionarItem(ItemNotaFiscal item)
        {
            itens.Add(item);
            valorBruto += item.Valor;
            impostos += item.Valor * 0.10;
            return this;
        }

        public NotaFiscalBuilder AdicionarObs(string obs)
        {
            Obs = obs;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            DataEmissao = DateTime.Now;
            return this;
        }
    }
}
