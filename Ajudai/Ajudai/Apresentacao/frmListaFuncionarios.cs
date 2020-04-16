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
    public partial class frmListaFuncionarios : Form
    {
        public frmListaFuncionarios()
        {
            InitializeComponent();
            ExibirFuncionarios();
        }        

        private void ExibirFuncionarios()
        {
            Modelo.Controle controle = new Modelo.Controle();
            dgvFuncionarios.DataSource = controle.ListarFuncionarios();
            dgvFuncionarios.Columns["Senha"].Visible = false;
            dgvFuncionarios.Columns["Chamado"].Visible = false;
            dgvFuncionarios.Columns["idFuncionario"].HeaderText = "Id";
            dgvFuncionarios.Columns["FuncionarioLogin"].HeaderText = "Login";
            dgvFuncionarios.Columns["NivelAcesso"].HeaderText = "Nível de Acesso";
            dgvFuncionarios.Columns["NomeExibicao"].HeaderText = "Nome de Exibição";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFuncionarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
