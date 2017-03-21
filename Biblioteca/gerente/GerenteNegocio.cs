using Biblioteca.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.gerente
{
    public class GerenteNegocio : ConexaoSqlServer, GerenteInterface
    {

        private const string ERRO_NUMERO = "Número do gerente inválido!";
        private const string ERRO_NOME = "Nome do gerente inválido!";

        public void Cadastrar(Gerente gerente)
        {
            if (gerente.Nr_Gerente <= 0)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if(gerente.Nm_Gerente.Trim().Equals("") || gerente.Nm_Gerente == null)
            {
                throw new Exception(ERRO_NOME);
            }

            if (VerificarDuplicidade(gerente) != false)
            {
                throw new Exception("Gerente já cadastrado no sistema!");
            }

            new GerenteDados().Cadastrar(gerente);
        }

        public void Atualizar(Gerente gerente)
        {
            if (gerente.Nr_Gerente < 0)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (gerente.Nm_Gerente.Trim().Equals("") || gerente.Nm_Gerente == null)
            {
                throw new Exception(ERRO_NUMERO);
            }

            if (VerificarDuplicidade(gerente) == false)
            {
                throw new Exception("Gerente não cadastrado no sistema!");
            }
            new GerenteDados().Atualizar(gerente);
        }

        public void Remover(Gerente gerente)
        {
            if (gerente.Nr_Gerente < 0)
            {
                throw new Exception(ERRO_NUMERO);
            }
            new GerenteDados().Remover(gerente);
        }

        public List<Gerente> Selecionar(Gerente filtro)
        {
            return new GerenteDados().Selecionar(filtro);
        }

        public bool VerificarDuplicidade(Gerente gerente)
        {
            if (gerente.Nr_Gerente < 0)
            {
                throw new Exception(ERRO_NUMERO);
            }

            return new GerenteDados().VerificarDuplicidade(gerente);
        }
    }
}
