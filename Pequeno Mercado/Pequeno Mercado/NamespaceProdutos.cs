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
        public string Marca { get; set; }
    }

    public class ProdutoComprado : Produto
    {
        public string QuantidadeComprada { get; set; }

        public ProdutoComprado(string nome = "", string quantComprada = "", string marca = "")
        {
            Nome = nome;
            QuantidadeComprada = quantComprada;
            Marca = marca;
        }


        public override string ToString()
        {
            return string.Format("Nome: {0} - Marca: {1} - Preço: R${2} - Quantidade Comprada: {3} ", this.Nome,this.Marca, this.Preco, this.QuantidadeComprada);
        }

    }

    public class ProdutoEstoque : Produto
    {
        public string Quantidade { get; set; }

        public ProdutoEstoque(string nome = "", string preco = "", string quantidade = "", string marca = "")
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Marca = marca;
        }


        public override string ToString()
        {
            return string.Format("Nome: {0} - Marca: {1} - Preço: R${2} - Quantidade: {3} ", this.Nome,this.Marca, this.Preco, this.Quantidade);
        }
    }

}
