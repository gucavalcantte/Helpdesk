using Ajudai.Modelo;
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
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<String> dadosProduto = new List<String>();
            dadosProduto.Add("0");
            dadosProduto.Add(txbNome.Text);
            dadosProduto.Add(txbDescricao.Text);

            Controle controle = new Controle();
            controle.CadastrarProduto(dadosProduto);
            MessageBox.Show(controle.mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
