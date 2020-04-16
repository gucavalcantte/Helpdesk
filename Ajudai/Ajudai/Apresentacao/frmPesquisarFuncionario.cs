using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajudai.Apresentacao
{
    public partial class frmPesquisarFuncionario : Form
    {
        public frmPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, txbNomeExibicao.Text };
            List<String> dadosFuncionario = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.ddFuncionario funcionario = controle.PesquisarFuncionarioPorId(dadosFuncionario);
            txbUsuario.Text = funcionario.Usuario;
            txbNome.Text = funcionario.Nome;
            txbEmail.Text = funcionario.Email;
            mskTelefone.Text = funcionario.Telefone;
            mskCelular.Text = funcionario.Celular;
            txbNomeExibicao.Text = funcionario.NomeExibicao;
            if (funcionario.NivelAcesso == "A")
                rdbAdministrador.Checked = true;
            if (funcionario.NivelAcesso == "T")
                rdbTecnico.Checked = true;
            if (funcionario.Id == 0)
                MessageBox.Show("Dados não encontrados, verifique.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, txbNomeExibicao.Text };
            List<String> dadosFuncionairio = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
                "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirFuncionario(dadosFuncionairio);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String nivelAcesso = "";
            if (rdbAdministrador.Checked)
            {
                nivelAcesso = "A";
            }

            if (rdbTecnico.Checked)
            {
                nivelAcesso = "T";
            }

            String[] dados = { txbId.Text, txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, nivelAcesso, txbNomeExibicao.Text };
            List<String> dadosFuncionairio = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarFuncionario(dadosFuncionairio);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNomeDeUsuário_Click(object sender, EventArgs e)
        {
            String[] dados = { "0", txbUsuario.Text, txbNome.Text, txbEmail.Text, mskTelefone.Text,
                                    mskCelular.Text, txbNomeExibicao.Text };
            List<String> dadosFuncionario = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.ddFuncionario funcionario = controle.PesquisarFuncionarioPorNomeUsuario(dadosFuncionario);
            txbId.Text = funcionario.Id.ToString();
            txbUsuario.Text = funcionario.Usuario;
            txbNome.Text = funcionario.Nome;
            txbEmail.Text = funcionario.Email;
            mskTelefone.Text = funcionario.Telefone;
            mskCelular.Text = funcionario.Celular;
            txbNomeExibicao.Text = funcionario.NomeExibicao;
            if (funcionario.NivelAcesso == "A")
                rdbAdministrador.Checked = true;
            if (funcionario.NivelAcesso == "T")
                rdbTecnico.Checked = true;
            if (funcionario.Usuario == null)
                MessageBox.Show("Usuário não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbUsuario.Clear();
            txbNome.Clear();
            txbEmail.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            txbNomeExibicao.Clear();
            rdbAdministrador.Checked = false;
            rdbTecnico.Checked = false;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            frmListaFuncionarios listaFuncionarios = new frmListaFuncionarios();
            listaFuncionarios.ShowDialog();
        }
    }
}
