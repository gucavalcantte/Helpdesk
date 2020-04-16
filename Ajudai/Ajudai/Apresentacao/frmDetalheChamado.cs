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
    public partial class frmDetalheChamado : Form
    {
        public frmDetalheChamado()
        {
            InitializeComponent();
            ExibirFuncionarios();
        }

        private void ExibirFuncionarios()
        {
            try
            {
                Modelo.Controle controle = new Modelo.Controle();
                cmbFuncionarios.DataSource = controle.ListarFuncionarios();
                cmbFuncionarios.ValueMember = "idFuncionario";
                cmbFuncionarios.DisplayMember = "NomeExibicao";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idFuncionario = Convert.ToInt32(cmbFuncionarios.SelectedValue);
            String[] dados = { txbIdChamado.Text, txbIdCliente.Text, txbIdProduto.Text,
                Convert.ToString(idFuncionario), lblDataAbertura.Text, cmbTipo.Text,
                rtbDescricao.Text, nudPrioridade.Value.ToString(), cmbStatus.Text, rtbResposta.Text, lblDataAtendimento.Text,
                rtbSolucao.Text, lblDataSolucao.Text, txbAvaliacao.Text, rtbComentarios.Text };
            List<String> dadosChamado = new List<String>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarChamado(dadosChamado);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
