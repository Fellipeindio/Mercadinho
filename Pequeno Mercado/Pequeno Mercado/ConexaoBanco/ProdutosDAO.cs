using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pequeno_Mercado.ConexaoBanco
{
    public class ProdutosDAO
    {
        public DataTable ReceberProdutos()
        {
            DbConnection conexao = DAOUtils.ReceberConexao();
            DbCommand comando = DAOUtils.ReceberComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Estoque";
            DbDataReader reader = DAOUtils.ReceberDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
    }
}
