using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace Pequeno_Mercado.ConexaoBanco
{
    public class DAOUtils
    {
        public static DbConnection ReceberConexao()
        {
            string server = ConfigurationManager.AppSettings["server"].ToString();
            string database = ConfigurationManager.AppSettings["database"].ToString();
            string user = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            string connectionString = @"Server =" + server + ";Database =" + database + ";User Id =" + user + ";Password = " + password + ";";
            DbConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }

        public static DbCommand ReceberComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader ReceberDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }

        public static DbParameter ReceberParametro(string name, object valor)
        {
            DbParameter parametro = null;
            parametro = new SqlParameter(name,valor);
            return parametro;
        }
    }
}
