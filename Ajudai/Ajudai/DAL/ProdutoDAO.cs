using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    public class ProdutoDAO : intProdutoDAO
    {
        public String mensagem;
        AJUDA_IEntities1 produtoEntity = new AJUDA_IEntities1();
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();

        public void CadastrarProduto(Produto produto)
        {
            this.mensagem = "";
            produtoEntity.Produto.Add(produto);
            produtoEntity.SaveChanges();
            this.mensagem = "Cadastrado com sucesso";
        }

        public void EditarProduto(Produto produto)
        {
            this.mensagem = "";
            try
            {
                produtoEntity.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                produtoEntity.SaveChanges();
                this.mensagem = "Editado com sucesso";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirProduto(Produto produto)
        {
            this.mensagem = "";
            produto = produtoEntity.Produto.Find(produto.idProduto);
            produtoEntity.Produto.Remove(produto);
            produtoEntity.SaveChanges();
            this.mensagem = "Excluído com sucesso";
        }

        public Produto PesquisarProdutoPorId(Produto produto)
        {
            try
            {
                Produto p = produtoEntity.Produto.First(c => c.idProduto == produto.idProduto);
                return p;
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }

        public Produto PesquisarProdutoPorNome(Produto produto)
        {
            try
            {
                Produto p = produtoEntity.Produto.First(c => c.Nome == produto.Nome);
                return p;
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }

        public List<Produto> ListarProdutos()
        {
            try
            {
                return produtoEntity.Produto.ToList();
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }

        public List<ddProduto> ddListarProdutos()
        {
            SqlCommand cmd = new SqlCommand();
            List<ddProduto> listaProdutos = new List<ddProduto>();
            cmd.CommandText = @"select * from Produto";
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ddProduto produto = new ddProduto();
                    produto.id = Convert.ToInt32(dataReader["idProduto"].ToString());
                    produto.nome = dataReader["nome"].ToString();
                    produto.descricao = dataReader["descricao"].ToString();

                    listaProdutos.Add(produto);
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return listaProdutos;
        }
    }
}
