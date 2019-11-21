using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Factory.ComDesignPattern
{
    public class NotaFiscalDAL
    {
        /* Dados de Acesso ao Banco de dados e Comandos SQL ficticios
        * O Objetivo e mostrar o Uso do Design Pattern Factory
        */
        public void Inserir()
        {
            try
            {
                IDbConnection conexao = new ConnectionFactory().ObterConexao();

                IDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into tb_nota_fiscal values (123, 'Teste')";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Alterar()
        {
            try
            {
                IDbConnection conexao = new ConnectionFactory().ObterConexao(); ;

                IDbCommand comando = conexao.CreateCommand();
                comando.CommandText = "update tb_nota_fiscal set Numero = 123 where Id = 1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
