using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.DAL;

namespace Ajudai.Modelo
{
    public class Validacao
    {
        public String mensagem = "";
        public String usuario;
        public String produto;
        public int id;
        
        public void ValidarCadastro(List<String> dadosFuncionario)
        {                       
            if (dadosFuncionario[1].Length < 3 || dadosFuncionario[1].Length > 15)
                mensagem = "Nome de usuário inválido. Deve conter entre 3 e 15 caracteres. \n";
            if (dadosFuncionario[2].Length < 4 || dadosFuncionario[2].Length > 15)
                mensagem += "Senha inválida. Deve conter entre 4 e 15 caracteres. \n";            
            if (dadosFuncionario[3] != dadosFuncionario[2])
                mensagem += "Senhas não correspondem. \n";
            if (string.IsNullOrEmpty(dadosFuncionario[4]))
                mensagem += "Insira um nome completo. \n";
            if (dadosFuncionario[4].Length > 100)
                mensagem += "Nome deve conter até 100 caracteres. \n";
            if (string.IsNullOrEmpty(dadosFuncionario[5]))
                mensagem += "Insira um e-mail. \n";
            if (dadosFuncionario[5].Length > 100)
                mensagem += "E-mail deve conter até 100 caracteres. \n";
            if (dadosFuncionario[6].Length > 20)
                mensagem += "Telefone inválido. \n";
            if (dadosFuncionario[7].Length > 20)
                mensagem += "Celular inválido. \n";
            if (string.IsNullOrEmpty(dadosFuncionario[8]))
                mensagem += "Selecione o nível de acesso.";
            if (dadosFuncionario[9].Length > 50)
                mensagem += "Nome de exibição deve conter até 50 caracteres. \n";           
        }

        public void ValidarEdicao(List<String> dadosFuncionario)
        {
            if (dadosFuncionario[1].Length < 3 || dadosFuncionario[1].Length > 15)
                mensagem = "Nome de usuário inválido. Deve conter entre 3 e 15 caracteres. \n";            
            if (string.IsNullOrEmpty(dadosFuncionario[2]))
                mensagem = "Insira um nome completo. \n";
            if (dadosFuncionario[2].Length > 100)
                mensagem += "Nome deve conter até 100 caracteres. \n";
            if (string.IsNullOrEmpty(dadosFuncionario[3]))
                mensagem += "Insira um e-mail. \n";
            if (dadosFuncionario[3].Length > 100)
                mensagem += "E-mail deve conter até 100 caracteres. \n";
            if (dadosFuncionario[4].Length > 20)
                mensagem += "Telefone inválido. \n";
            if (dadosFuncionario[5].Length > 20)
                mensagem += "Celular inválido. \n";
            if (string.IsNullOrEmpty(dadosFuncionario[6]))
                mensagem += "Selecione o nível de acesso.";
            if (dadosFuncionario[7].Length > 50)
                mensagem += "Nome de exibição deve conter até 50 caracteres. \n";

            try
            {
                id = Convert.ToInt32(dadosFuncionario[0]);
            }
            catch (FormatException)
            {
                mensagem += "ID inválido";
            }
        }

        public void ValidarLogin(List<String> dadosLogin)
        {            
            if (string.IsNullOrEmpty(dadosLogin[1]))
                mensagem = "Insira o nome de usuário. \n";
            if (string.IsNullOrEmpty(dadosLogin[2]))
                mensagem += "Insira a senha. \n";
            if (string.IsNullOrEmpty(dadosLogin[3]))
                mensagem += "Selecione o nível de acesso. \n";           
        }

        public void ValidarPesquisaPorId(List<String> dadosFuncionario)
        {
            try
            {
                id = Convert.ToInt32(dadosFuncionario[0]);
            }
            catch (FormatException)
            {
                mensagem += "ID inválido";
            }
        }

        public void ValidarPesquisaPorNomeUsuario(List<String> dadosFuncionario)
        {
            if (string.IsNullOrEmpty(dadosFuncionario[1]))
                mensagem = "Insira o Nome de Usuário. \n";            
        }

        public void ValidarPesquisaPorNome(List<String> dadosFuncionario)
        {
            if (string.IsNullOrEmpty(dadosFuncionario[3]))
                mensagem = "Insira o Nome. \n";
        }

        public void ValidarCadastroProduto(List<String> dadosProduto)
        {
            if (string.IsNullOrEmpty(dadosProduto[1]))
                mensagem = "Insira o nome do produto \n";
            if (dadosProduto[1].Length > 50)
                mensagem += "Nome deve contar até 50 caracteres \n";
            if (string.IsNullOrEmpty(dadosProduto[2]))
                mensagem += "Insira a descrição do produto \n";
            if (dadosProduto[2].Length > 100)
                mensagem += "Descrição deve contar até 50 caracteres \n";
        }
        
        public void ValidarEdicaoProduto(List<String> dadosProduto)
        {
            if (string.IsNullOrEmpty(dadosProduto[1]))
                mensagem = "Insira o nome do produto \n";
            if (dadosProduto[1].Length > 50)
                mensagem += "Nome deve contar até 50 caracteres \n";
            if (string.IsNullOrEmpty(dadosProduto[2]))
                mensagem += "Insira a descrição do produto \n";
            if (dadosProduto[2].Length > 100)
                mensagem += "Descrição deve contar até 50 caracteres \n";

            try
            {
                id = Convert.ToInt32(dadosProduto[0]);
            }
            catch (FormatException)
            {
                mensagem += "ID inválido";
            }
        }

        public void ValidarPesquisaProdutoPorId(List<String> dadosProduto)
        {
            this.mensagem = "";
            try
            {
                this.id = Convert.ToInt32(dadosProduto[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }
        }

        public void ValidarExclusaoProduto(List<String> dadosProduto)
        {
            if (string.IsNullOrEmpty(dadosProduto[1]))
                mensagem = "Pesquise um produto cadastrado para excluir \n";            
            if (string.IsNullOrEmpty(dadosProduto[2]))
                mensagem = "Pesquise um produto cadastrado para excluir \n";           

            try
            {
                id = Convert.ToInt32(dadosProduto[0]);
            }
            catch (FormatException)
            {
                mensagem += "Pesquise um produto cadastrado para excluir";
            }
        }

        public void ValidarPesquisaProdutoPorNome(List<String> dadosProduto)
        {
            if (string.IsNullOrEmpty(dadosProduto[1]))
                mensagem = "Insira o nome do produto \n";
        }

        public void ValidarEdicaoChamado(List<String> dadosChamado)
        {
            if (string.IsNullOrEmpty(dadosChamado[9]))
                mensagem = "Insira seu posicionamento ao chamado \n";
            if (string.IsNullOrEmpty(dadosChamado[5]))
                mensagem += "Selecione o tipo do problema \n";
            if (string.IsNullOrEmpty(dadosChamado[8]))
                mensagem += "Selecione o status do chamado \n";
            if (dadosChamado[8] == "Concluído" && string.IsNullOrEmpty(dadosChamado[11]))
                mensagem += "Insira a solução para o chamado";
        }
    }
}
