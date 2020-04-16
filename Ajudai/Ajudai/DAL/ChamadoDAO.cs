using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    public class ChamadoDAO : intChamadoDAO
    {
        public String mensagem;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();
        AJUDA_IEntities1 chamadoEntity = new AJUDA_IEntities1();

        public void CadastrarChamado(ddChamado chamado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Chamado  
                                  (idCliente,idProduto,idFuncionario,dtAbertura, Tipo,
                            Descricao,Prioridade, dtAtendimento,PosicionamentoFuncionario,
                            Status, dtSolucao, Solucao, Avaliacao, PosicionamentoCliente)   
                                 values (@cliente, @produto, @funcionario, @data_abertura, @tipo, 
                            @descricao, @prioridade, @dtAtendimento, @posicionamentoFuncionario,
                            @status, @dtSolucao, @solucao, @avaliacao, @posicionamentoCliente)";
            cmd.Parameters.AddWithValue("@cliente", chamado.idCliente);
            cmd.Parameters.AddWithValue("@produto", chamado.idProduto);
            cmd.Parameters.AddWithValue("@funcionario", chamado.idFuncionario);
            cmd.Parameters.AddWithValue("@data_abertura", System.DateTime.Now);
            cmd.Parameters.AddWithValue("@tipo", " ");
            cmd.Parameters.AddWithValue("@descricao", chamado.descricao);
            cmd.Parameters.AddWithValue("@prioridade", " ");
            cmd.Parameters.AddWithValue("@dtAtendimento", " ");
            cmd.Parameters.AddWithValue("@posicionamentoFuncionario", " ");
            cmd.Parameters.AddWithValue("@status", chamado.txStatus);
            cmd.Parameters.AddWithValue("@dtSolucao", " ");
            cmd.Parameters.AddWithValue("@solucao", " ");
            cmd.Parameters.AddWithValue("@avaliacao", " ");
            cmd.Parameters.AddWithValue("@posicionamentoCliente", " ");

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public ddChamado PesquisarChamadoPorId(int cdChamado)
        {
            ddChamado chamado = new ddChamado();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select c.*, p.Nome NomeProduto, p.Descricao DescricaoProduto from Chamado c, Produto p
                            where c.idProduto = p.idProduto 
                            and c.idChamado = @id";
            cmd.Parameters.AddWithValue("@id", cdChamado);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    chamado.id = Convert.ToInt32(dataReader["idChamado"]);
                    chamado.idCliente = Convert.ToInt32(dataReader["idCliente"]);
                    chamado.idProduto = Convert.ToInt32(dataReader["idProduto"]);
                    chamado.idFuncionario = Convert.ToInt32(dataReader["idFuncionario"]);                    
                    chamado.dtAbertura = Convert.ToDateTime(dataReader["dtAbertura"]);                                            
                    chamado.descricao = dataReader["Descricao"].ToString();
                    if (!String.IsNullOrEmpty(dataReader["PosicionamentoFuncionario"].ToString()))
                        chamado.posicionamentoFuncionario = dataReader["PosicionamentoFuncionario"].ToString();
                    if (!String.IsNullOrEmpty(dataReader["PosicionamentoCliente"].ToString()))
                        chamado.posicionamentoCliente = dataReader["PosicionamentoCliente"].ToString();
                    chamado.txStatus = dataReader["Status"].ToString();
                    chamado.Produto.nome = dataReader["NomeProduto"].ToString();
                    chamado.Produto.descricao = dataReader["DescricaoProduto"].ToString();
                    chamado.solucao = dataReader["Solucao"].ToString();
                    chamado.avaliacao = dataReader["Avaliacao"].ToString();
                }
                else
                {
                    chamado.id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return chamado;
        }

        public void CadastrarPosicionamentoCliente(ddChamado chamado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Chamado set PosicionamentoCliente = @posicionamento_cliente where idChamado = @id";
            cmd.Parameters.AddWithValue("@posicionamento_cliente", chamado.posicionamentoCliente);
            cmd.Parameters.AddWithValue("@id", chamado.id);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void CadastrarAvaliacao(ddChamado chamado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Chamado set Avaliacao = @avaliacao where idChamado = @id";
            cmd.Parameters.AddWithValue("@avaliacao", chamado.avaliacao);
            cmd.Parameters.AddWithValue("@id", chamado.id);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarChamado(Chamado chamado)
        {
            this.mensagem = "";
            try
            {
                chamadoEntity.Entry(chamado).State = System.Data.Entity.EntityState.Modified;
                chamadoEntity.SaveChanges();
                this.mensagem = "Editado com sucesso";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public List<Chamado> ListarChamadosAbertosAdm()
        {
            List<Chamado> listaChamadosAbertos = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Aberto")
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosAbertos.Add(p);
            }
            return listaChamadosAbertos;
        }

        public List<Chamado> ListarChamadosAbertosTec()
        {
            List<Chamado> listaChamadosAbertos = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Aberto"
                               && p.idFuncionario == SessaoSistema.UsuarioId)
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosAbertos.Add(p);
            }
            return listaChamadosAbertos;
        }

        public List<Chamado> ListarChamadosAndamentoAdm()
        {
            List<Chamado> listaChamadosAndamento = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Em atendimento")
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosAndamento.Add(p);
            }
            return listaChamadosAndamento;
        }

        public List<Chamado> ListarChamadosAndamentoTec()
        {
            List<Chamado> listaChamadosAndamento = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Em atendimento" 
                               && p.idFuncionario == SessaoSistema.UsuarioId)
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosAndamento.Add(p);
            }
            return listaChamadosAndamento;
        }

        public List<Chamado> ListarChamadosConcluidosAdm()
        {
            List<Chamado> listaChamadosConcluidos = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Concluído")
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosConcluidos.Add(p);
            }
            return listaChamadosConcluidos;
        }

        public List<Chamado> ListarChamadosConcluidosTec()
        {
            List<Chamado> listaChamadosConcluidos = new List<Chamado>();
            IQueryable lista = from p in chamadoEntity.Chamado.Where
                               (p => p.Status == "Concluído"
                               && p.idFuncionario == SessaoSistema.UsuarioId)
                               select p;
            foreach (Chamado p in lista)
            {
                listaChamadosConcluidos.Add(p);
            }
            return listaChamadosConcluidos;
        }
    }
}
