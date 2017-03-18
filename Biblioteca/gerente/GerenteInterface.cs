using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.gerente
{
    public interface GerenteInterface
    {
        void Cadastrar(Gerente gerente);
        void Atualizar(Gerente gerente);
        void Remover(Gerente gerente);
        bool VerificarDuplicidade(Gerente gerente);
        List<Gerente> Selecionar(Gerente filtro);
    }
}
