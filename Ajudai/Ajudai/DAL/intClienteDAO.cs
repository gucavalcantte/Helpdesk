using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    interface intClienteDAO
    {
        void CadastrarCliente(ddCliente cliente);
        bool Acessar(ddCliente cliente);
        List<ddChamado> ListarChamadosDoCliente(ddCliente cliente);
        ddCliente PesquisarClientePorLogin(ddCliente cliente);
    }
}
    