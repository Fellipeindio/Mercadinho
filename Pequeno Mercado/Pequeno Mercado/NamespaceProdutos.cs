using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceProdutos
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public string Preco { get; set; }
    }

    public class ProdutoComprado : Produto
    {
        public string QuantidadeComprada { get; set; }

        public ProdutoComprado(string nome = "", string quantComprada = "", string cliente = "")
        {
            Nome = nome;
            QuantidadeComprada = quantComprada;
        }


        public override string ToString()
        {
            return string.Format("Nome: {0} - Preço: R${1} - Quantidade Comprada: {2} ", this.Nome, this.Preco, this.QuantidadeComprada);
        }

    }

    public class ProdutoEstoque : Produto
    {
        public string Quantidade { get; set; }

        public ProdutoEstoque(string nome = "", string preco = "", string quantidade = "")
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public override string ToString()
        {
            return string.Format("Nome: {0} - Preço: R${1} - Quantidade: {2} ", this.Nome, this.Preco, this.Quantidade);
        }
    }

}
