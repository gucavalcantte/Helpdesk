using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.DAL
{
    public class Conexao
    {
        SqlConnection conexaoBD;

        public Conexao()
        {
            conexaoBD = new SqlConnection();
            conexaoBD.ConnectionString = @"Data Source=LAPTOP-1SD4M6UV\SQLEXPRESS;
                             Initial Catalog=Ajudai;Integrated Security=True";            
        }

        public SqlConnection Conectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Closed)
                conexaoBD.Open();
            return conexaoBD;
        }

        public void Desconectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Open)
                conexaoBD.Close();
        }
    }
}
