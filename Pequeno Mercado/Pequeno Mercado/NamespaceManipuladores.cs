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
                foreach (KeyValuePair<string, ProdutoComprado> elemento in dicProduto)
                {
                    ProdutoComprado produto = elemento.Value;
                    linha = string.Format("Produto: {0} - Marca: {1} - Preço: R${2} - Quant. Comprada: {2}", produto.Nome,produto.Marca ,produto.Preco, produto.QuantidadeComprada);
                    sw.WriteLine(linha); // escreve no arquivo texto
                }
                linha = "";
                sw.WriteLine(linha);
                sw.WriteLine(linha);
                sw.Flush();

            }
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class ManipuladorDeArquivosEstoque
    {
        private static string EnderecoAquivo = AppDomain.CurrentDomain.BaseDirectory + "ProdutosdaLoja.txt";



        public static List<ProdutoEstoque> LerArquivo()
        {
            List<ProdutoEstoque> listaProduto = new List<ProdutoEstoque>();
            List<ProdutoEstoque> listaOrdenada = new List<ProdutoEstoque>();
            if (File.Exists(@EnderecoAquivo))
            {
                using (StreamReader sr = File.OpenText(EnderecoAquivo)) // Ler arquivo e ja fecha o ponteiro
                {
                    while (sr.Peek() >= 0) // Se nao tiver mais nenhuma linnha vai retorna -1
                    {
                        string linha = sr.ReadLine();
                        string[] linhaComSplit = linha.Split('-');
                        if (linhaComSplit.Count() == 4)
                        {
                            ProdutoEstoque produto = new ProdutoEstoque();
                            produto.Nome = linhaComSplit[0].ToUpper();
                            produto.Marca = linhaComSplit[1].ToUpper();
                            produto.Preco = linhaComSplit[2];
                            produto.Quantidade = linhaComSplit[3];
                            listaProduto.Add(produto);
                            
                        }
                    }
                }
            }
            var ordenadoNome = listaProduto.OrderBy(p => p.Nome).ThenBy(p => p.Marca);
            foreach (ProdutoEstoque item in ordenadoNome)
            {
                listaOrdenada.Add(item);
            }
            return listaOrdenada;
        }

        public static void EscreverAquivo(List<ProdutoEstoque> listaProduto)
        {

            using (StreamWriter sw = new StreamWriter(@EnderecoAquivo, false))
            {
                foreach (ProdutoEstoque produto in listaProduto)
                {
                    decimal valorProduto = 0.0m;
                    valorProduto += Convert.ToDecimal(produto.Preco);
                    string linha = string.Format("{0}-{1}-{2}-{3}", produto.Nome, produto.Marca, valorProduto, produto.Quantidade);
                    sw.WriteLine(linha); // escreve no arquivo texto
                    valorProduto = 0.0m;
                }
                sw.Flush();

            }
        }
    }
}
