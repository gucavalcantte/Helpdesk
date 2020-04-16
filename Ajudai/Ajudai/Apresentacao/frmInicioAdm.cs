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
    public partial class frmInicioAdm : Form
    {
        public frmInicioAdm()
        {
            InitializeComponent();
            ExibirChamadosAbertosAdm();
            ExibirChamadosAndamentoAdm();
            ExibirChamadosConcluidosAdm();
            ExibirNome();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadastroUsuario = new frmCadastroFuncionario();
            cadastroUsuario.ShowDialog();
        }

        private void tsmLogoffAdm_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }

        private void tsmFecharAdm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionario pesquisar = new frmPesquisarFuncionario();
            pesquisar.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProduto = new frmCadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPesquisarProduto pesquisarProduto = new frmPesquisarProduto();
            pesquisarProduto.ShowDialog();
        }

        private void pesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }        

        private void ExibirNome()
        {
            lblLogin.Text = Modelo.SessaoSistema.NomeExibicao;
        }

        private void ExibirChamadosAbertosAdm()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvChamadosAbertos.DataSource = controle.ListarChamadosAbertosAdm();
            dgvChamadosAbertos.Columns["Cliente"].Visible = false;
            dgvChamadosAbertos.Columns["Produto"].Visible = false;
            dgvChamadosAbertos.Columns["Funcionario"].Visible = false;
            dgvChamadosAbertos.Columns["idChamado"].HeaderText = "ID do Chamado";
            dgvChamadosAbertos.Columns["idFuncionario"].HeaderText = "ID do Funcionário";
            dgvChamadosAbertos.Columns["idProduto"].HeaderText = "ID do Produto";
            dgvChamadosAbertos.Columns["idCliente"].HeaderText = "ID do Cliente";
            dgvChamadosAbertos.Columns["dtAbertura"].HeaderText = "Data de Abertura";
            dgvChamadosAbertos.Columns["Descricao"].HeaderText = "Descrição";
            dgvChamadosAbertos.Columns["dtAtendimento"].HeaderText = "Data de Início do Atendimento";
            dgvChamadosAbertos.Columns["PosicionamentoFuncionario"].HeaderText = "Resposta/  Comentários do Funcionário";
            dgvChamadosAbertos.Columns["dtSolucao"].HeaderText = "Data de Solução";
            dgvChamadosAbertos.Columns["Solucao"].HeaderText = "Solução";
            dgvChamadosAbertos.Columns["Avaliacao"].HeaderText = "Avaliação";
            dgvChamadosAbertos.Columns["PosicionamentoCliente"].HeaderText = "Comentários do Cliente";
        }

        private void ExibirChamadosAndamentoAdm()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvChamadosAndamento.DataSource = controle.ListarChamadosAndamentoAdm();
            dgvChamadosAndamento.Columns["Cliente"].Visible = false;
            dgvChamadosAndamento.Columns["Produto"].Visible = false;
            dgvChamadosAndamento.Columns["Funcionario"].Visible = false;
            dgvChamadosAndamento.Columns["idChamado"].HeaderText = "ID do Chamado";
            dgvChamadosAndamento.Columns["idFuncionario"].HeaderText = "ID do Funcionário";
            dgvChamadosAndamento.Columns["idProduto"].HeaderText = "ID do Produto";
            dgvChamadosAndamento.Columns["idCliente"].HeaderText = "ID do Cliente";
            dgvChamadosAndamento.Columns["dtAbertura"].HeaderText = "Data de Abertura";
            dgvChamadosAndamento.Columns["Descricao"].HeaderText = "Descrição";
            dgvChamadosAndamento.Columns["dtAtendimento"].HeaderText = "Data de Início do Atendimento";
            dgvChamadosAndamento.Columns["PosicionamentoFuncionario"].HeaderText = "Resposta/  Comentários do Funcionário";
            dgvChamadosAndamento.Columns["dtSolucao"].HeaderText = "Data de Solução";
            dgvChamadosAndamento.Columns["Solucao"].HeaderText = "Solução";
            dgvChamadosAndamento.Columns["Avaliacao"].HeaderText = "Avaliação";
            dgvChamadosAndamento.Columns["PosicionamentoCliente"].HeaderText = "Comentários do Cliente";
        }

        private void ExibirChamadosConcluidosAdm()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvChamadosConcluidos.DataSource = controle.ListarChamadosConcluidosAdm();
            dgvChamadosConcluidos.Columns["Cliente"].Visible = false;
            dgvChamadosConcluidos.Columns["Produto"].Visible = false;
            dgvChamadosConcluidos.Columns["Funcionario"].Visible = false;
            dgvChamadosConcluidos.Columns["idChamado"].HeaderText = "ID do Chamado";
            dgvChamadosConcluidos.Columns["idFuncionario"].HeaderText = "ID do Funcionário";
            dgvChamadosConcluidos.Columns["idProduto"].HeaderText = "ID do Produto";
            dgvChamadosConcluidos.Columns["idCliente"].HeaderText = "ID do Cliente";
            dgvChamadosConcluidos.Columns["dtAbertura"].HeaderText = "Data de Abertura";
            dgvChamadosConcluidos.Columns["Descricao"].HeaderText = "Descrição";
            dgvChamadosConcluidos.Columns["dtAtendimento"].HeaderText = "Data de Início do Atendimento";
            dgvChamadosConcluidos.Columns["PosicionamentoFuncionario"].HeaderText = "Resposta/  Comentários do Funcionário";
            dgvChamadosConcluidos.Columns["dtSolucao"].HeaderText = "Data de Solução";
            dgvChamadosConcluidos.Columns["Solucao"].HeaderText = "Solução";
            dgvChamadosConcluidos.Columns["Avaliacao"].HeaderText = "Avaliação";
            dgvChamadosConcluidos.Columns["PosicionamentoCliente"].HeaderText = "Comentários do Cliente";
        }              

        private void dgvChamadosAbertos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetalheChamado detalhes = new frmDetalheChamado();
            detalhes.txbIdChamado.Text = this.dgvChamadosAbertos.CurrentRow.Cells[0].Value.ToString();
            detalhes.txbIdCliente.Text = this.dgvChamadosAbertos.CurrentRow.Cells[1].Value.ToString();
            detalhes.txbIdProduto.Text = this.dgvChamadosAbertos.CurrentRow.Cells[2].Value.ToString();
            detalhes.txbIdFuncionario.Text = this.dgvChamadosAbertos.CurrentRow.Cells[3].Value.ToString();
            detalhes.lblDataAbertura.Text = this.dgvChamadosAbertos.CurrentRow.Cells[4].Value.ToString();
            detalhes.cmbTipo.Text = this.dgvChamadosAbertos.CurrentRow.Cells[5].Value.ToString();
            detalhes.rtbDescricao.Text = this.dgvChamadosAbertos.CurrentRow.Cells[6].Value.ToString();
            detalhes.txbPrioridade.Text = this.dgvChamadosAbertos.CurrentRow.Cells[7].Value.ToString();
            detalhes.lblDataAtendimento.Text = this.dgvChamadosAbertos.CurrentRow.Cells[8].Value.ToString();
            detalhes.rtbResposta.Text = this.dgvChamadosAbertos.CurrentRow.Cells[9].Value.ToString();
            detalhes.cmbStatus.Text = this.dgvChamadosAbertos.CurrentRow.Cells[10].Value.ToString();
            detalhes.lblDataSolucao.Text = this.dgvChamadosAbertos.CurrentRow.Cells[11].Value.ToString();
            detalhes.rtbSolucao.Text = this.dgvChamadosAbertos.CurrentRow.Cells[12].Value.ToString();
            detalhes.txbAvaliacao.Text = this.dgvChamadosAbertos.CurrentRow.Cells[13].Value.ToString();
            detalhes.rtbComentarios.Text = this.dgvChamadosAbertos.CurrentRow.Cells[14].Value.ToString();
            detalhes.ShowDialog();
        }

        private void dgvChamadosAndamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetalheChamado detalhes = new frmDetalheChamado();
            detalhes.txbIdChamado.Text = this.dgvChamadosAndamento.CurrentRow.Cells[0].Value.ToString();
            detalhes.txbIdCliente.Text = this.dgvChamadosAndamento.CurrentRow.Cells[1].Value.ToString();
            detalhes.txbIdProduto.Text = this.dgvChamadosAndamento.CurrentRow.Cells[2].Value.ToString();
            detalhes.txbIdFuncionario.Text = this.dgvChamadosAndamento.CurrentRow.Cells[3].Value.ToString();
            detalhes.lblDataAbertura.Text = this.dgvChamadosAndamento.CurrentRow.Cells[4].Value.ToString();
            detalhes.cmbTipo.Text = this.dgvChamadosAndamento.CurrentRow.Cells[5].Value.ToString();
            detalhes.rtbDescricao.Text = this.dgvChamadosAndamento.CurrentRow.Cells[6].Value.ToString();
            detalhes.txbPrioridade.Text = this.dgvChamadosAndamento.CurrentRow.Cells[7].Value.ToString();
            detalhes.lblDataAtendimento.Text = this.dgvChamadosAndamento.CurrentRow.Cells[8].Value.ToString();
            detalhes.rtbResposta.Text = this.dgvChamadosAndamento.CurrentRow.Cells[9].Value.ToString();
            detalhes.cmbStatus.Text = this.dgvChamadosAndamento.CurrentRow.Cells[10].Value.ToString();
            detalhes.lblDataSolucao.Text = this.dgvChamadosAndamento.CurrentRow.Cells[11].Value.ToString();
            detalhes.rtbSolucao.Text = this.dgvChamadosAndamento.CurrentRow.Cells[12].Value.ToString();
            detalhes.txbAvaliacao.Text = this.dgvChamadosAndamento.CurrentRow.Cells[13].Value.ToString();
            detalhes.rtbComentarios.Text = this.dgvChamadosAndamento.CurrentRow.Cells[14].Value.ToString();
            detalhes.ShowDialog();
        }

        private void dgvChamadosConcluidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetalheChamado detalhes = new frmDetalheChamado();
            detalhes.txbIdChamado.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[0].Value.ToString();
            detalhes.txbIdCliente.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[1].Value.ToString();
            detalhes.txbIdProduto.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[2].Value.ToString();
            detalhes.txbIdFuncionario.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[3].Value.ToString();
            detalhes.lblDataAbertura.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[4].Value.ToString();
            detalhes.cmbTipo.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[5].Value.ToString();
            detalhes.rtbDescricao.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[6].Value.ToString();
            detalhes.txbPrioridade.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[7].Value.ToString();
            detalhes.lblDataAtendimento.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[8].Value.ToString();
            detalhes.rtbResposta.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[9].Value.ToString();
            detalhes.cmbStatus.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[10].Value.ToString();
            detalhes.lblDataSolucao.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[11].Value.ToString();
            detalhes.rtbSolucao.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[12].Value.ToString();
            detalhes.txbAvaliacao.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[13].Value.ToString();
            detalhes.rtbComentarios.Text = this.dgvChamadosConcluidos.CurrentRow.Cells[14].Value.ToString();
            detalhes.ShowDialog();
        }

        private void btnAtualizarAbertos_Click(object sender, EventArgs e)
        {
            ExibirChamadosAbertosAdm();
        }

        private void btnAtualizarAndamento_Click(object sender, EventArgs e)
        {
            ExibirChamadosAndamentoAdm();
        }

        private void btnAtualizarConcluidos_Click(object sender, EventArgs e)
        {
            ExibirChamadosConcluidosAdm();
        }

        private void dgvChamadosAbertos_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvChamadosAbertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
