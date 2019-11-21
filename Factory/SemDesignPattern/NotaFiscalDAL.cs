using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Factory.SemDesignPattern
{
    /* Dados de Acesso ao Banco de dados e Comandos SQL ficticios
     * O Objetivo e mostrar o Uso do Design Pattern Factory
     */
    public class NotaFiscalDAL
    {
        public void Inserir()
        {
            try
            {
                //Repeticao do Codigo para Abrir uma Conexao com o Banco de Dados
                IDbConnection conexao = new SqlConnection();
                conexao.ConnectionString = "User Id=root;Password=1234;Server=localhost;DataBase=meuBancoDeDados";
                conexao.Open();

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
                //Repeticao do Codigo para Abrir uma Conexao com o Banco de Dados
                IDbConnection conexao = new SqlConnection();
                conexao.ConnectionString = "User Id=root;Password=1234;Server=localhost;DataBase=meuBancoDeDados";
                conexao.Open();

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
