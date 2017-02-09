using NamespaceUsuarios;
using NamespaceProdutos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NamespaceManipuladores
{
    public class ManipuladorDeArquivosCompra
    {
        private static string EnderecoAquivoCompra = AppDomain.CurrentDomain.BaseDirectory + "ClienteProdutos.txt";

        public static void EscreverAquivoCompra(Dictionary<string, ProdutoComprado> dicProduto, Cliente comprador)
        {

            using (StreamWriter sw = new StreamWriter(@EnderecoAquivoCompra, true))
            {
                string linha;
                linha = string.Format("Nome do Cliente: {0}, Valor da Compra: {1}", comprador.NomeComprador, comprador.ValorCompra);
                sw.WriteLine(linha);
                foreach (KeyValuePair<string,ProdutoComprado> elemento in dicProduto)
                {
                    ProdutoComprado produto = elemento.Value;
                    linha = string.Format("Produto: {0} - Preço: {1} - Quant. Comprada: {2}", produto.Nome, produto.Preco, produto.QuantidadeComprada);
                    sw.WriteLine(linha); // escreve no arquivo texto
                }
                linha = "";
                sw.WriteLine(linha);
                sw.Flush();

            }
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class ManipuladorDeArquivosEstoque
    {
        private static string EnderecoAquivo = AppDomain.CurrentDomain.BaseDirectory + "ProdutosdaLoja.txt";



        public static Dictionary<string,ProdutoEstoque> LerArquivo()
        {
            Dictionary<string, ProdutoEstoque> dicProduto = new Dictionary<string, ProdutoEstoque>();
            if (File.Exists(@EnderecoAquivo))
            {
                using (StreamReader sr = File.OpenText(EnderecoAquivo)) // Ler arquivo e ja fecha o ponteiro
                {
                    while (sr.Peek() >= 0) // Se nao tiver mais nenhuma linnha vai retorna -1
                    {
                        string linha = sr.ReadLine();
                        string[] linhaComSplit = linha.Split('-');
                        if (linhaComSplit.Count() == 3)
                        {
                            ProdutoEstoque produto = new ProdutoEstoque();
                            produto.Nome = linhaComSplit[0];
                            produto.Preco = linhaComSplit[1];
                            produto.Quantidade = linhaComSplit[2];
                            dicProduto.Add(produto.Nome,produto);
                        }
                    }
                }
            }

            return dicProduto;
        }

        public static void EscreverAquivo(Dictionary<string,ProdutoEstoque> dicProduto)
        {

            using (StreamWriter sw = new StreamWriter(@EnderecoAquivo, false))
            {
                foreach (KeyValuePair<string,ProdutoEstoque> elemento in dicProduto)
                {
                    ProdutoEstoque produto = elemento.Value;
                    decimal valorProduto = 0.0m;
                    valorProduto += Convert.ToDecimal(produto.Preco);
                    string linha = string.Format("{0}-{1}-{2}", produto.Nome, valorProduto, produto.Quantidade);
                    sw.WriteLine(linha); // escreve no arquivo texto
                    valorProduto = 0.0m;
                }
                sw.Flush();

            }
        }
    }
}
