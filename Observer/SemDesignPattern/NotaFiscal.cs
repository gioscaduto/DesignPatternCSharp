using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.SemDesignPattern
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dtEmissao, double valorBruto, double impostos, IList<ItemNotaFiscal> itens, string obs)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DtEmissao = dtEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Obs = obs;
        }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DtEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNotaFiscal> Itens { get; set; }
        public string Obs { get; set; }
    }
}
