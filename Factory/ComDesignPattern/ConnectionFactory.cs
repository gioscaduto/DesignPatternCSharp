using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Factory.ComDesignPattern
{
    public class ConnectionFactory
    {
        /* Isolamento do Codigo para Abrir uma Conexao com o Banco de Dados
         * Factory e parecida com o Design Pattern Builder
         * No Builder o objeto que e criado varia de acordo com os parametros
         * Na Factory o objeto que e criado basicamente tem as mesmas configuracoes
         * No nosso caso, sempre retorna uma conexao com o Banco de Dados com as mesmas configuracoes (Nome do Servidor, Banco de Dados, etc)
         */
        public IDbConnection ObterConexao()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=1234;Server=localhost;DataBase=meuBancoDeDados";
            conexao.Open();

            return conexao;
        }
    }
}
