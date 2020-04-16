using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.Modelo
{
    public class ddChamado
    {
        public ddChamado()
        {
            Produto = new ddProduto();
        }
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idProduto { get; set; }
        public int idFuncionario { get; set; }
        public DateTime dtAbertura { get; set; }

        [Required(ErrorMessage = "Insira uma descrição", AllowEmptyStrings = false)]
        public string descricao { get; set; }

        public DateTime dtAtendimento { get; set; }
        public DateTime dtSolucao { get; set; }
        public string solucao { get; set; }
        public string txStatus { get; set; }
        public string avaliacao { get; set; }
        public string posicionamentoFuncionario { get; set; }
        public string posicionamentoCliente { get; set; }

        public ddProduto Produto { get; set; }
    }
}
