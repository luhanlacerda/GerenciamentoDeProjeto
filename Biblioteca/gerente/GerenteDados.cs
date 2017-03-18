using Biblioteca.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.gerente
{
    public class GerenteDados : ConexaoSqlServer, GerenteInterface
    {
        public void Cadastrar(Gerente gerente)
        {
            try
            {
                //abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Gerente (Nr_Gerente, Nm_Gerente) VALUES(@numero,@nome)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = gerente.numero;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = gerente.nome;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void Atualizar(Gerente gerente)
        {
            try
            {
                //abrindo conexão
                this.abrirConexao();
                string sql = "UPDATE Gerente SET Nr_Gerente = @numero, Nm_Gerente = @nome WHERE Nr_Gerente = @numero";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = gerente.numero;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = gerente.nome;

                //executando a instrução
                cmd.ExecuteNonQuery();
                //liberando espaço na memória
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e atualizar " + ex.Message);
            }
        }

        public void Remover(Gerente gerente)
        {
            try
            {
                //abrindo conexão
                this.abrirConexao();
                string sql = "DELETE FROM gerente WHERE Nr_Gerente = @numero";
                //instrução a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = gerente.numero;

                //executando a instrução
                cmd.ExecuteNonQuery();
                //libernado espaço na memória
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public List<Gerente> Selecionar(Gerente filtro)
        {
            List<Gerente> retorno = new List<Gerente>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT Nr_Gerente, Nm_Gerente FROM Gerente WHERE Nr_Numero = Nr_Numero ";
                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.numero > 0)
                {
                    sql += " AND Nr_Numero = @numero";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.nome != null && filtro.nome.Trim().Equals("") == false)
                {
                    sql += " AND Nm_Nome LIKE '%@nome%'";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.numero > 0)
                {
                    cmd.Parameters.Add("@numero", SqlDbType.Int);
                    cmd.Parameters["@numero"].Value = filtro.numero;
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.nome != null && filtro.nome.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = filtro.nome;

                }
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Gerente gerente = new Gerente();
                    //acessando os valores das colunas do resultado
                    gerente.numero = DbReader.GetInt32(DbReader.GetOrdinal("numero"));
                    gerente.nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    retorno.Add(gerente);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }

        public bool VerificarDuplicidade(Gerente gerente)
        {
            bool retorno = false;

            try
            {
                this.abrirConexao();
                //instrução a ser executada
                string sql = "SELECT Nr_Gerente, Nm_Gerente FROM Gerente WHERE Nr_Gerente = @numero";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@numero", SqlDbType.Int);
                cmd.Parameters["@numero"].Value = gerente.numero;
                //executando a instrução
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando memório
                cmd.Dispose();
                //fechando conexão
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
    }

}
