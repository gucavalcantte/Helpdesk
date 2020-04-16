using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.Modelo
{
    public class Controle
    {
        public bool acessoAdmin;
        public bool acessoTecn;
        public bool acesso = true;
        public String mensagem;

        public void CadastrarFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarCadastro(dadosFuncionario);

            if (validacao.mensagem.Equals(""))
            {
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.Usuario = dadosFuncionario[1];
                funcionario.Senha = dadosFuncionario[2];
                funcionario.Confirmar = dadosFuncionario[3];
                funcionario.Nome = dadosFuncionario[4];
                funcionario.Email = dadosFuncionario[5];
                funcionario.Telefone = dadosFuncionario[6];
                funcionario.Celular = dadosFuncionario[7];
                funcionario.NivelAcesso = dadosFuncionario[8];
                funcionario.NomeExibicao = dadosFuncionario[9];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionarioDAO.CadastrarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;               
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        internal bool Acessar(List<String> dadosLogin)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarLogin(dadosLogin);

            if (validacao.mensagem.Equals(""))
            {
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.Usuario = dadosLogin[1];
                funcionario.Senha = dadosLogin[2];
                funcionario.NivelAcesso = dadosLogin[3];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                acessoAdmin = funcionarioDAO.Acessar(funcionario);
                this.acessoAdmin = funcionarioDAO.acessoAdm;
                this.acessoTecn = funcionarioDAO.acessoTec;

                if (acessoAdmin == true)
                {
                    acessoTecn = false;
                    acesso = acessoAdmin;
                }
                else
                if (acessoTecn == true)
                {
                    acessoAdmin = false;
                    acesso = acessoTecn;
                }                
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return acesso;
        }

        public ddFuncionario PesquisarFuncionarioPorId(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            ddFuncionario funcionario = new ddFuncionario();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorId(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                funcionario.Id = validacao.id;
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionario = funcionarioDAO.PesquisarFuncionarioPorId(funcionario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return funcionario;
        }

        public ddFuncionario PesquisarFuncionarioPorNomeUsuario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            ddFuncionario funcionario = new ddFuncionario();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorNomeUsuario(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                funcionario.Usuario = dadosFuncionario[1];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionario = funcionarioDAO.PesquisarFuncionarioPorNomeUsuario(funcionario);                
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return funcionario;
        }

        public void EditarFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarEdicao(dadosFuncionario);

            if (validacao.mensagem.Equals(""))
            {
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.Id = validacao.id;
                funcionario.Usuario = dadosFuncionario[1];                
                funcionario.Nome = dadosFuncionario[2];
                funcionario.Email = dadosFuncionario[3];
                funcionario.Telefone = dadosFuncionario[4];
                funcionario.Celular = dadosFuncionario[5];
                funcionario.NivelAcesso = dadosFuncionario[6];
                funcionario.NomeExibicao = dadosFuncionario[7];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionarioDAO.EditarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirFuncionario(List<String> dadosFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaPorId(dadosFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                ddFuncionario funcionario = new ddFuncionario();
                funcionario.Id = validacao.id;
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                if (funcionarioDAO.PesquisarFuncionarioPorId(funcionario).Usuario != null)
                {
                    funcionarioDAO.ExcluirFuncionario(funcionario);
                    this.mensagem = funcionarioDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este usuário";
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }        

        public List<Funcionario> ListarFuncionarios()
        {            
            DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
            List<Funcionario> lista = new List<Funcionario>();
            lista = funcionarioDAO.ListarFuncionarios();
            return lista;            
        }

        public void CadastrarProduto(List<String> dadosProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarCadastroProduto(dadosProduto);
            if (validacao.mensagem.Equals(""))
            {
                Produto produto = new Produto();
                produto.Nome = dadosProduto[1];
                produto.Descricao = dadosProduto[2];
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                produtoDAO.CadastrarProduto(produto);
                this.mensagem = produtoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public Produto PesquisarProdutoPorId(List<String> dadosProduto)
        {
            this.mensagem = "";
            Produto produto = new Produto();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaProdutoPorId(dadosProduto);
            if (validacao.mensagem.Equals(""))
            {
                produto.idProduto = validacao.id;
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                produto = produtoDAO.PesquisarProdutoPorId(produto);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return produto;
        }

        public void EditarProduto(List<String> dadosProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarEdicaoProduto(dadosProduto);
            if (validacao.mensagem.Equals(""))
            {
                Produto produto = new Produto();
                produto.idProduto = validacao.id;
                produto.Nome = dadosProduto[1];
                produto.Descricao = dadosProduto[2];
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                produtoDAO.EditarProduto(produto);
                this.mensagem = produtoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirProduto(List<String> dadosProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaProdutoPorId(dadosProduto);
            if (validacao.mensagem.Equals(""))
            {
                Produto produto = new Produto();
                produto.idProduto = validacao.id;
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                if (produtoDAO.PesquisarProdutoPorId(produto).Nome != null)
                {
                    produtoDAO.ExcluirProduto(produto);
                    this.mensagem = produtoDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Produto não encontrado";
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public Produto PesquisarProdutoPorNome(List<String> dadosProduto)
        {
            this.mensagem = "";
            Produto produto = new Produto();
            Validacao validacao = new Validacao();
            validacao.ValidarPesquisaProdutoPorNome(dadosProduto);
            if (validacao.mensagem.Equals(""))
            {                
                produto.Nome = dadosProduto[1];
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                produto = produtoDAO.PesquisarProdutoPorNome(produto);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return produto;
        }

        public List<Produto> ListarProdutos()
        {           
            DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
            List<Produto> lista = new List<Produto>();
            lista = produtoDAO.ListarProdutos();
            return lista;
        }

        public List<Chamado> ListarChamadosAbertosAdm()
        {            
            DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();            
            atbEstaticos.listaChamadosEstatico = chamadoDAO.ListarChamadosAbertosAdm();
            return atbEstaticos.listaChamadosEstatico;
        }

        public List<Chamado> ListarChamadosAndamentoAdm()
        {
            DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();
            atbEstaticos.listaChamadosEstatico = chamadoDAO.ListarChamadosAndamentoAdm();            
            return atbEstaticos.listaChamadosEstatico;
        }

        public List<Chamado> ListarChamadosConcluidosAdm()
        {
            DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();
            atbEstaticos.listaChamadosEstatico = chamadoDAO.ListarChamadosConcluidosAdm();
            return atbEstaticos.listaChamadosEstatico;
        }

        public List<Chamado> ListarChamadosAbertosTec()
        {
            DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();
            atbEstaticos.listaChamadosEstatico = chamadoDAO.ListarChamadosAbertosTec();
            return atbEstaticos.listaChamadosEstatico;
        }

        public List<Chamado> ListarChamadosAndamentoTec()
        {
            DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();
            atbEstaticos.listaChamadosEstatico = chamadoDAO.ListarChamadosAndamentoTec();
            return atbEstaticos.listaChamadosEstatico;
        }

        public List<Chamado> ListarChamadosConcluidosTec()
        {
            DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();
            atbEstaticos.listaChamadosEstatico = chamadoDAO.ListarChamadosConcluidosTec();
            return atbEstaticos.listaChamadosEstatico;
        }

        public void EditarChamado(List<String> dadosChamado)
        {
            this.mensagem = "";            
            Validacao validacao = new Validacao();
            validacao.ValidarEdicaoChamado(dadosChamado);
            if (validacao.mensagem.Equals(""))
            {
                Chamado chamado = new Chamado();
                chamado.idChamado = Convert.ToInt32(dadosChamado[0]);
                chamado.idCliente = Convert.ToInt32(dadosChamado[1]);
                chamado.idProduto = Convert.ToInt32(dadosChamado[2]);
                chamado.idFuncionario = Convert.ToInt32(dadosChamado[3]);
                chamado.dtAbertura = Convert.ToDateTime(dadosChamado[4]);
                chamado.Tipo = dadosChamado[5];
                chamado.Descricao = dadosChamado[6];
                chamado.Prioridade = dadosChamado[7];
                chamado.Status = dadosChamado[8];
                chamado.PosicionamentoFuncionario = dadosChamado[9];
                chamado.dtAtendimento = dadosChamado[10];
                if (chamado.Status.Equals("Aberto"))
                {
                    chamado.dtAtendimento = "";
                }
                if (chamado.Status.Equals("Em atendimento") 
                    && !chamado.PosicionamentoFuncionario.Equals(""))
                {
                    chamado.dtAtendimento = Convert.ToString(DateTime.Now);
                }                                          
                chamado.Solucao = dadosChamado[11];
                chamado.dtSolucao = dadosChamado[12];
                if (chamado.Status.Equals("Concluído") && !chamado.Solucao.Equals(""))
                {
                    chamado.dtSolucao = Convert.ToString(DateTime.Now);
                }
                chamado.Avaliacao = dadosChamado[13];
                chamado.PosicionamentoCliente = dadosChamado[14];
                DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();
                chamadoDAO.EditarChamado(chamado);
                this.mensagem = chamadoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
        
    }
}
