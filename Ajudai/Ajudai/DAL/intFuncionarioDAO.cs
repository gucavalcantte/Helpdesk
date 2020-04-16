using Ajudai.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.DAL
{
    interface intFuncionarioDAO
    {
        void CadastrarFuncionario(ddFuncionario funcionario);
        bool Acessar(ddFuncionario funcionario);
        void EditarFuncionario(ddFuncionario funcionario);
        void ExcluirFuncionario(ddFuncionario funcionario);
        ddFuncionario PesquisarFuncionarioPorId(ddFuncionario funcionario);
        ddFuncionario PesquisarFuncionarioPorNomeUsuario(ddFuncionario funcionario);
        List<Funcionario> ListarFuncionarios();
    }
}
