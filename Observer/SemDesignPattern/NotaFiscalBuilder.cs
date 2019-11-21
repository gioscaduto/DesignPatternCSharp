using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.SemDesignPattern
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

        public NotaFiscal Construir()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, valorBruto, impostos, itens, Obs);

            EnviarPorEmail(nf);
            Salvar(nf);
            EnviarPorSms(nf);

            return nf;
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

        /* Novos Metodos
         * Problema
         * A Classe Builder esta com muitas responsabilidades
         * Construir uma Nota Fiscal, Enviar Por Email, Sms e Salvar no Banco de Dados 
         */ 
        private void EnviarPorEmail(NotaFiscal nf)
        {
            Console.WriteLine("Enviando Nota Fiscal por Email");
        }

        private void Salvar(NotaFiscal nf)
        {
            Console.WriteLine("Salvando no Banco de Dados a Nota Fiscal");
        }

        private void EnviarPorSms(NotaFiscal nf)
        {
            Console.WriteLine("Enviando Nota Fiscal por SMS");
        }
    }
}
