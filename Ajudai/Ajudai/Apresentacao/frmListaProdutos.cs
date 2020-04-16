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
    public partial class frmListaProdutos : Form
    {
        public frmListaProdutos()
        {
            InitializeComponent();
            ExibirProdutos();
        }

        private void ExibirProdutos()
        {            
            Modelo.Controle controle = new Modelo.Controle();
            dgvProdutos.DataSource = controle.ListarProdutos();
            dgvProdutos.Columns["Chamado"].Visible = false;
            dgvProdutos.Columns["idProduto"].HeaderText = "Id";
            dgvProdutos.Columns["Descricao"].HeaderText = "Descrição";
        }        

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPesquisarProduto produto = new frmPesquisarProduto();
            produto.txbId.Text = this.dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            produto.txbNome.Text = this.dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            produto.txbDescricao.Text = this.dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            produto.ShowDialog();
        }
    }
}
