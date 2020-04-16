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
    public partial class frmPesquisarProduto : Form
    {
        public frmPesquisarProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisarId_Click(object sender, EventArgs e)
        {
            List<String> dadosProduto = new List<String>();
            dadosProduto.Add(txbId.Text);
            dadosProduto.Add("");
            dadosProduto.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.Produto produto = controle.PesquisarProdutoPorId(dadosProduto);
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("Insira o ID que deseja pesquisar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (produto != null)
            {
                txbNome.Text = produto.Nome;
                txbDescricao.Text = produto.Descricao;
            }
            else
            {
                MessageBox.Show("Produto não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbId.Clear();
                txbNome.Clear();
                txbDescricao.Clear();
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbNome.Clear();
            txbDescricao.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbNome.Text, txbDescricao.Text };
            List<String> dadosProduto = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarProduto(dadosProduto);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbId.Clear();
            txbNome.Clear();
            txbDescricao.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbNome.Text, txbDescricao.Text };
            List<String> dadosProduto = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();

            DialogResult result = MessageBox.Show("Deseja realmente excluir?",
               "Alerta de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controle.ExcluirProduto(dadosProduto);
                MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            List<String> dadosProduto = new List<String>();
            dadosProduto.Add("");
            dadosProduto.Add(txbNome.Text);
            dadosProduto.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.Produto produto = controle.PesquisarProdutoPorNome(dadosProduto);
            if (string.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show("Insira o Nome que deseja pesquisar", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (produto != null)
            {
                txbId.Text = Convert.ToString(produto.idProduto);                
                txbDescricao.Text = produto.Descricao;
            }
            else
            {
                MessageBox.Show("Produto não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbId.Clear();
                txbNome.Clear();
                txbDescricao.Clear();
            }
        }        

        private void btnTodos_Click(object sender, EventArgs e)
        {
            frmListaProdutos listaProdutos = new frmListaProdutos();            
            listaProdutos.ShowDialog();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
