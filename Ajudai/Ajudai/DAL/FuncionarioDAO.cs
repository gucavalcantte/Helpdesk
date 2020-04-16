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
    public class FuncionarioDAO : intFuncionarioDAO
    {
        public bool acessoAdm = false;
        public bool acessoTec = false;
        public String mensagem;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();
        AJUDA_IEntities1 funcionarioEntity = new AJUDA_IEntities1();

        public void CadastrarFuncionario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            var hash = new Criptografia(SHA512.Create());
            hash.GerarHash(funcionario.Senha);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Funcionario  
                                  (FuncionarioLogin, Senha, Nome, Email, Telefone, Celular, NivelAcesso, NomeExibicao)
                                 values (@usuario, @senha, @nome, @email, @telefone, @celular, @nivelAcesso, @nomeExibicao)";
            cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
            cmd.Parameters.AddWithValue("@senha", hash.GerarHash(funcionario.Senha));
            cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@nivelAcesso", funcionario.NivelAcesso);
            cmd.Parameters.AddWithValue("@nomeExibicao", funcionario.NomeExibicao);

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

        public bool Acessar(ddFuncionario funcionario)
        {
            var hash = new Criptografia(SHA512.Create());
            string hashTxtSenha = hash.GerarHash(funcionario.Senha);
            string nivelT = "T";
            string nivelA = "A";
            funcionario.Senha = hash.GerarHash(funcionario.Senha);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select idFuncionario, FuncionarioLogin, Senha, Nome, NivelAcesso, NomeExibicao from funcionario where FuncionarioLogin = @usuario and Senha = @senha and NivelAcesso = @nivel";
            cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
            cmd.Parameters.AddWithValue("@senha", hashTxtSenha);
            cmd.Parameters.AddWithValue("@nivel", funcionario.NivelAcesso);                       

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        SessaoSistema.UsuarioId = Convert.ToInt32(dataReader["idFuncionario"]);
                        SessaoSistema.NomeExibicao = Convert.ToString(dataReader["NomeExibicao"]);
                        SessaoSistema.NomeUsuario = Convert.ToString(dataReader["FuncionarioLogin"]);
                    }                    
                    if (funcionario.Senha == hashTxtSenha)
                    {
                        if (funcionario.NivelAcesso == nivelA)
                        {
                            return acessoAdm = true;
                        }
                        if (funcionario.NivelAcesso == nivelT)
                        {
                            return acessoTec = true;
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
            return false;
        }

        public void EditarFuncionario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Funcionario set FuncionarioLogin = @usuario, Nome = @nome, 
                            Email = @email, Telefone = @telefone, Celular = @celular, 
                            NivelAcesso = @nivelAcesso, NomeExibicao = @nomeExibicao 
                            where idFuncionario = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.Id);
            cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
            cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@nivelAcesso", funcionario.NivelAcesso);
            cmd.Parameters.AddWithValue("@nomeExibicao", funcionario.NomeExibicao);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Editado com Sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Nome de Usuário Indisponível";
            }
        }

        public void ExcluirFuncionario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from funcionario where idFuncionario = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.Id);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Usuário excluído com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public ddFuncionario PesquisarFuncionarioPorId(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Funcionario
                            where idFuncionario = @id";
            cmd.Parameters.AddWithValue("@id", funcionario.Id);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    funcionario.Usuario = dataReader["FuncionarioLogin"].ToString();
                    funcionario.Nome = dataReader["Nome"].ToString();
                    funcionario.Email = dataReader["Email"].ToString();
                    funcionario.Telefone = dataReader["Telefone"].ToString();
                    funcionario.Celular = dataReader["Celular"].ToString();
                    funcionario.NivelAcesso = dataReader["NivelAcesso"].ToString();
                    funcionario.NomeExibicao = dataReader["NomeExibicao"].ToString();
                }
                else
                {
                    funcionario.Id = 0;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return funcionario;
        }

        public ddFuncionario PesquisarFuncionarioPorNomeUsuario(ddFuncionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Funcionario
                            where FuncionarioLogin = @usuario";
            cmd.Parameters.AddWithValue("@usuario", funcionario.Usuario);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    funcionario.Id = Convert.ToInt32(dataReader["idFuncionario"].ToString());
                    funcionario.Usuario = dataReader["FuncionarioLogin"].ToString();
                    funcionario.Nome = dataReader["Nome"].ToString();
                    funcionario.Email = dataReader["Email"].ToString();
                    funcionario.Telefone = dataReader["Telefone"].ToString();
                    funcionario.Celular = dataReader["Celular"].ToString();
                    funcionario.NivelAcesso = dataReader["NivelAcesso"].ToString();
                    funcionario.NomeExibicao = dataReader["NomeExibicao"].ToString();
                }
                else
                {
                    funcionario.Usuario = null;
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return funcionario;
        }

        public List<Funcionario> ListarFuncionarios()
        {
            try
            {
                return funcionarioEntity.Funcionario.ToList();
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }
    }
}
