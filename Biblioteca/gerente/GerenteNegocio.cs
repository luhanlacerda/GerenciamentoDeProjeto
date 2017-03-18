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
        public void Cadastrar(Gerente gerente)
        {
            if (gerente.numero <= 0)
            {
                throw new Exception("Código inválido!");
            }
            if(gerente.nome.Trim().Equals("") || gerente.nome == null)
            {
                throw new Exception("Favor informar o nome!");
            }
            Cadastrar(gerente);
        }

        public void Atualizar(Gerente gerente)
        {
            throw new NotImplementedException();
        }

        public void Remover(Gerente gerente)
        {
            throw new NotImplementedException();
        }

        public List<Gerente> Selecionar(Gerente filtro)
        {
            throw new NotImplementedException();
        }

        public bool VerificarDuplicidade(Gerente gerente)
        {
            throw new NotImplementedException();
        }
    }
}
