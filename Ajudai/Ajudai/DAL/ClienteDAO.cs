using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    public class ClienteDAO : intClienteDAO
    {
        public String mensagem;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();        

        public void CadastrarCliente(ddCliente cliente)
        {
            this.mensagem = "";
            var hash = new Criptografia(SHA512.Create());
            hash.GerarHash(cliente.senha);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Cliente  
                                  (ClienteLogin, Senha, Nome, Email, Telefone, Celular, CEP, Endereço, Cidade, UF)
                                 values (@usuario, @senha, @nome, @email, @telefone, @celular, @cep, @endereco, @cidade, @estado)";
            cmd.Parameters.AddWithValue("@usuario", cliente.login);
            cmd.Parameters.AddWithValue("@senha", hash.GerarHash(cliente.senha));
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.uf);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
                this.mensagem = "Nome de Usuário Indisponível";

            }
        }

        public bool Acessar(ddCliente cliente)
        {
            var hash = new Criptografia(SHA512.Create());
            string hashTxtSenha = hash.GerarHash(cliente.senha);
            cliente.senha = hash.GerarHash(cliente.senha);

            bool retorno = false;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select count(*) as qtd from cliente where ClienteLogin = @usuario and Senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", cliente.login);
            cmd.Parameters.AddWithValue("@senha", hashTxtSenha);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    if (cliente.senha == hashTxtSenha)
                    {
                        if (Convert.ToInt32(dataReader["qtd"].ToString()) > 0)
                        {
                            retorno = true;
                        }
                    }                    
                }
                conexaoBD.Desconectar();
                dataReader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return retorno;
        }

        public List<ddChamado> ListarChamadosDoCliente(ddCliente dadosTela)
        {
            SqlCommand cmd = new SqlCommand();
            List<ddChamado> listaChamados = new List<ddChamado>();
            cmd.CommandText = @"select c.*, p.Nome nomeProduto from Chamado c, Produto p
                             where p.idProduto = c.idProduto
                             and c.idCliente = @idCliente order by idChamado desc";

            cmd.Parameters.AddWithValue("@idCliente", dadosTela.id);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ddChamado chamado = new ddChamado();
                    chamado.id = Convert.ToInt32(dataReader["idChamado"].ToString());
                    chamado.idCliente = Convert.ToInt32(dataReader["idCliente"].ToString());
                    chamado.idProduto = Convert.ToInt32(dataReader["idProduto"].ToString());
                    chamado.idFuncionario = Convert.ToInt32(dataReader["idFuncionario"].ToString());
                    if (!String.IsNullOrEmpty(dataReader["PosicionamentoFuncionario"].ToString()))
                        chamado.posicionamentoFuncionario = dataReader["PosicionamentoFuncionario"].ToString();
                    if (!String.IsNullOrEmpty(dataReader["PosicionamentoCliente"].ToString()))
                        chamado.posicionamentoCliente = dataReader["PosicionamentoCliente"].ToString();
                    chamado.dtAbertura = Convert.ToDateTime(dataReader["dtAbertura"].ToString());
                    chamado.txStatus = dataReader["Status"].ToString();
                    chamado.Produto.nome = dataReader["nomeProduto"].ToString();
                    if (!String.IsNullOrEmpty(dataReader["PosicionamentoCliente"].ToString()))
                        chamado.posicionamentoCliente = dataReader["PosicionamentoCliente"].ToString();

                    listaChamados.Add(chamado);
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }

            return listaChamados;
        }

        public ddCliente PesquisarClientePorLogin(ddCliente cliente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Cliente
                            where ClienteLogin = @login";

            cmd.Parameters.AddWithValue("@login", cliente.login);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    cliente.id = Convert.ToInt32(dataReader["idCliente"].ToString());
                    cliente.login = dataReader["ClienteLogin"].ToString();
                    cliente.nome = dataReader["Nome"].ToString();
                    cliente.email = dataReader["Email"].ToString();
                    cliente.telefone = dataReader["Telefone"].ToString();
                    cliente.celular = dataReader["Celular"].ToString();
                    cliente.cep = dataReader["CEP"].ToString();
                    cliente.endereco = dataReader["Endereço"].ToString();
                    cliente.cidade = dataReader["Cidade"].ToString();
                    cliente.uf = dataReader["UF"].ToString();
                }
                else
                {
                    cliente.id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return cliente;
        }
    }
}
