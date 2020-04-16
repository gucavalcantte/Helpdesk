using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.Modelo
{
    public class ddFuncionario
    {
        private int id;
        private String usuario;
        private String senha;
        private String confirmar;
        private String nome;
        private String email;
        private String telefone;
        private String celular;
        private String nivelAcesso;
        private String nomeExibicao;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Confirmar { get => confirmar; set => confirmar = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }
        public string NomeExibicao { get => nomeExibicao; set => nomeExibicao = value; }
    }
}
