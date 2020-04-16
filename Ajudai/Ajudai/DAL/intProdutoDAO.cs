using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    interface intProdutoDAO
    {
        void CadastrarProduto(Produto produto);
        Produto PesquisarProdutoPorId(Produto produto);
        void EditarProduto(Produto produto);
        void ExcluirProduto(Produto produto);
        Produto PesquisarProdutoPorNome(Produto produto);
        List<Produto> ListarProdutos();
    }
}
