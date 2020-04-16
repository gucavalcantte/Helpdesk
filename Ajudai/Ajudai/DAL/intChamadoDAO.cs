using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    interface intChamadoDAO
    {
        void CadastrarChamado(ddChamado chamado);
        ddChamado PesquisarChamadoPorId(int cdChamado);
        void CadastrarPosicionamentoCliente(ddChamado chamado);
        void CadastrarAvaliacao(ddChamado chamado);
        List<Chamado> ListarChamadosAbertosAdm();
        List<Chamado> ListarChamadosAndamentoAdm();
        List<Chamado> ListarChamadosConcluidosAdm();
        List<Chamado> ListarChamadosAbertosTec();
        List<Chamado> ListarChamadosAndamentoTec();
        List<Chamado> ListarChamadosConcluidosTec();
        void EditarChamado(Chamado chamado);
    }
}
