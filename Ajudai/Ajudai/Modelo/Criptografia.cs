using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Ajudai.DAL;

namespace Ajudai.Modelo
{
    public class Criptografia
    {
        private HashAlgorithm _algoritmo;

        public Criptografia()
        {
        }

        public Criptografia(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        public string GerarHash(string senha)
        {
            var valorCodificado = Encoding.UTF8.GetBytes(senha);
            var senhaCifrada = _algoritmo.ComputeHash(valorCodificado);

            var sb = new StringBuilder();
            foreach (var caractere in senhaCifrada)
            {
                sb.Append(caractere.ToString("X2"));
            }
            return sb.ToString();
        }        
    }
}

