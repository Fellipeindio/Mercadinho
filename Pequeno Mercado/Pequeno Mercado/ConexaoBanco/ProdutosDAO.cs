using NamespaceProdutos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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

        public void Excluir(int codigo)
        {
            DbConnection conexao = DAOUtils.ReceberConexao();
            DbCommand comando = DAOUtils.ReceberComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Estoque WHERE Codigo= @codigo";// @ representa um parametro
            comando.Parameters.Add(DAOUtils.ReceberParametro("@codigo", codigo));
            comando.ExecuteNonQuery();//nao traz nada do banco apenas altera algo
        }

        public void Inserir(ProdutoEstoque produto)
        {
            DbConnection conexao = DAOUtils.ReceberConexao();
            DbCommand comando = DAOUtils.ReceberComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Estoque (Nome,Marca,Preco,Quantidade) VALUES(@nome,@marca,@preco,@quantidade)";
            comando.Parameters.Add(DAOUtils.ReceberParametro("@nome",produto.Nome));
            comando.Parameters.Add(DAOUtils.ReceberParametro("@marca",produto.Marca));
            comando.Parameters.Add(DAOUtils.ReceberParametro("@preco",produto.Preco));
            comando.Parameters.Add(DAOUtils.ReceberParametro("@quantidade",produto.Quantidade));
            comando.ExecuteNonQuery();
        }

        public void Atualizar(ProdutoEstoque produto)
        {
            DbConnection conexao = DAOUtils.ReceberConexao();
            DbCommand comando = DAOUtils.ReceberComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Estoque SET Nome = @nome, Marca = @marca, Preco = @preco, Quantidade = @quantidade WHERE Codigo = @codigo";
            comando.Parameters.Add(DAOUtils.ReceberParametro("@nome", produto.Nome));
            comando.Parameters.Add(DAOUtils.ReceberParametro("@marca", produto.Marca));
            comando.Parameters.Add(DAOUtils.ReceberParametro("@preco", Convert.ToDouble(produto.Preco)));
            comando.Parameters.Add(DAOUtils.ReceberParametro("@quantidade", Convert.ToInt32( produto.Quantidade)));
            comando.Parameters.Add(DAOUtils.ReceberParametro("@codigo", produto.Codigo));
            comando.ExecuteNonQuery();
        }
    }
}
