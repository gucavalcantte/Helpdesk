using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.Modelo
{
    public static class SessaoSistema
    {
        private static Int32 _usuarioId;
        private static String _nomeUsuario;
        private static String _nomeExibicao;

        public static int UsuarioId { get => _usuarioId; set => _usuarioId = value; }
        public static string NomeUsuario { get => _nomeUsuario; set => _nomeUsuario = value; }
        public static string NomeExibicao { get => _nomeExibicao; set => _nomeExibicao = value; }
    }
}
