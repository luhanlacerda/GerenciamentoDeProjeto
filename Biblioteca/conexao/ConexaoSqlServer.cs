﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.conexao
{
    public class ConexaoSqlServer
    {
        #region variáveis
        //tipo responsável para se trabalhar com o sqlserver
        public SqlConnection sqlConn;
        //máquina no qual estará o banco de dados
        private const string local = "localhost";
        //nome do banco de dados no qual desejamos nos comunicar
        private const string banco_de_dados = "Projetinho";
        //usuário que tenha os privilégios para utilizar o banco de dados
        private const string usuario = "sa";
        //senha do usuario
        private const string senha = "123";
        #endregion

        //string de conexão obtida para o sql sever
        string connectionStringSqlServer = @"Data Source=" + local + ";Initial Catalog=" + banco_de_dados + ";UId=" + usuario + ";Password=" + senha + ";";

        public void abrirConexao()
        {
            //iniciando uma conexão com o sql server, utilizando os parâmetros da string de conexão
            this.sqlConn = new SqlConnection(connectionStringSqlServer);
            //abrindo a conexão com a base de dados
            this.sqlConn.Open();
        }


        public void fecharConexao()
        {
            //fechando a conexao com a base de dados
            sqlConn.Close();
            //liberando a conexao da memoria
            sqlConn.Dispose();
        }
    }
}
