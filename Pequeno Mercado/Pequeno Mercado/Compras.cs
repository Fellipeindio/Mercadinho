using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NamespaceProdutos;
using NamespaceManipuladores;
using NamespaceUsuarios;
using Pequeno_Mercado.ConexaoBanco;

namespace Pequeno_Mercado
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        int indice;
        decimal valorTotal = 0.0m;
        int[] quantProdutos;
        ProdutoEstoque produtoSelecionado;
        List<ProdutoEstoque> listaProdutos = new List<ProdutoEstoque>();

        private void Compras_Shown(object sender, EventArgs e)
        {
            CarregarProdutosComboBox();
            AlterarBtnCompraTxbQuantCompra(false);

        }

        // Alteração de Estados

        private void AlterarBtnCompraTxbQuantCompra(bool estado)
        {
            btnCompraProduto.Enabled = estado;
            txbQuantidadeComprada.Enabled = estado;
        }

        // Validações

        private void VerificaQuantidade(string quantidade, ProdutoEstoque estoque, int indice)
        {
            quantProdutos[indice] -= Convert.ToInt32(quantidade);
            if (Convert.ToInt32(quantidade) < 0)
            {
                throw new ArgumentException();
            }

            // Comprando mais do q tem o estoque
            if (Convert.ToInt32(quantidade) > Convert.ToInt32(estoque.Quantidade) || quantProdutos[indice] < 0)
            {
                quantProdutos[indice] += Convert.ToInt32(quantidade);
                throw new QuantidadeinsuficienteException();
            }

        }

        public bool FaltaDadosCompra(string cliente, string quantComprada)
        {
            if (quantComprada != "" && cliente != "" && cliente != "Insira o Nome do Cliente")
            {
                return true;
            }
            return false;
        }

        // Ações não envolvendo botões

        private void CarregarProdutosComboBox()
        {
            ProdutosDAO produtoDAO = new ProdutosDAO();
            cbxProdutosCompra.Items.Clear();
            listaProdutos = produtoDAO.RetornaLista();
            // lista auxiliar do estoque 
            quantProdutos = new int[listaProdutos.Count]; int i = 0;
            string nomeMarca;
            foreach (ProdutoEstoque elemento in listaProdutos)
            {
                quantProdutos[i] = Convert.ToInt32(elemento.Quantidade);
                i++;
                nomeMarca = elemento.Nome + "/" + elemento.Marca;
                cbxProdutosCompra.Items.Add(nomeMarca);
            }
        }

        private void LimparCamposCompra()
        {
            txbQuantidadeComprada.Text = "";
            txbQuantidade.Text = "";
        }

        // Ações envolvendo botões ou textos

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbxProdutosCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProdutosCompra.SelectedIndex >= 0)
            {
                indice = cbxProdutosCompra.SelectedIndex;
                produtoSelecionado = listaProdutos[indice];
                txbQuantidade.Text = quantProdutos[indice].ToString();
            }
            AlterarBtnCompraTxbQuantCompra(true);
        }

        private void txbCliente_Click(object sender, EventArgs e)
        {
            txbCliente.Text = "";
        }

        private void btnCompraProduto_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (FaltaDadosCompra(txbCliente.Text, txbQuantidadeComprada.Text))
            {
                ProdutoComprado produto = new ProdutoComprado();
                try
                {
                    // Exception
                    VerificaQuantidade(txbQuantidadeComprada.Text, produtoSelecionado, indice);
                    // Fim Exception
                    foreach (ProdutoComprado produtoDaLista in lbxLista.Items)
                    {
                        if (produtoSelecionado.Nome.ToUpper() == produtoDaLista.Nome.ToUpper() && produtoSelecionado.Marca == produtoDaLista.Marca)
                        {
                            existe = true;
                            produto = produtoDaLista;
                            int indiceExistente = lbxLista.Items.IndexOf(produtoDaLista);
                            int acrescimoQuant = Convert.ToInt32(txbQuantidadeComprada.Text) + Convert.ToInt32(produtoDaLista.QuantidadeComprada);
                            produto.QuantidadeComprada = Convert.ToString(acrescimoQuant);
                            lbxLista.Items.RemoveAt(indiceExistente);
                            lbxLista.Items.Insert(indiceExistente, produto);
                            break;
                        }
                    }
                    if (!existe)
                    {
                        produto.Nome = produtoSelecionado.Nome;
                        produto.Marca = produtoSelecionado.Marca;
                        produto.Preco = produtoSelecionado.Preco;
                        produto.QuantidadeComprada = txbQuantidadeComprada.Text;
                        lbxLista.Items.Add(produto);
                    }
                    valorTotal += Convert.ToDecimal(produtoSelecionado.Preco) * Convert.ToInt32(txbQuantidadeComprada.Text);
                    txbValorTotal.Text = Convert.ToString(valorTotal);
                    btnFinalizarCompra.Enabled = true;
                }
                catch (QuantidadeinsuficienteException ex)
                {
                    MessageBox.Show("Não tem quantidade suficiente em nosso estoque!", "Quantidade insuficiente");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Nao é possivel comprar quantidade negativa", "Quantidade inválida");
                }

                LimparCamposCompra();
                cbxProdutosCompra.Text = "";
                btnCompraProduto.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não é possível comprar produto com dados insuficientes!!", "Erro ao Comprar");
            }
        }

        private void btnCancelacomprar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza???", "Cancelando compra", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza???", "Encerrar compra", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cliente cliente = new Cliente
                {
                    NomeComprador = txbCliente.Text,
                    ValorCompra = txbValorTotal.Text
                };
                Dictionary<string, ProdutoComprado> compraLista = new Dictionary<string, ProdutoComprado>();
                foreach (ProdutoComprado produtoCompra in lbxLista.Items)
                {
                    compraLista.Add(produtoCompra.Nome, produtoCompra);
                }
                ManipuladorDeArquivosCompra.EscreverAquivoCompra(compraLista, cliente);
                //Retirar quantidade comprada
                foreach (ProdutoComprado produtoCompra in lbxLista.Items)
                {
                    foreach (ProdutoEstoque produtoEstoque in listaProdutos)
                    {
                        if (produtoCompra.Nome == produtoEstoque.Nome && produtoCompra.Marca == produtoEstoque.Marca)
                        {
                            int sobraEstoque = Convert.ToInt32(produtoEstoque.Quantidade) - Convert.ToInt32(produtoCompra.QuantidadeComprada);
                            produtoEstoque.Quantidade = Convert.ToString(sobraEstoque);
                            ProdutosDAO produtoDAO = new ProdutosDAO();
                            produtoDAO.Atualizar(produtoEstoque);
                            break;
                        }
                    }
                }
                MessageBox.Show("Compra Efetuada!!! Encerrando janela!");
                Close();
            }
        }
        private void Compras_Load(object sender, EventArgs e)
        {
        }
        private void btnOkCliente_Click(object sender, EventArgs e)
        {
            if (txbCliente.Text != "" && txbCliente.Text != "Insira o Nome do Cliente")
            {
                cbxProdutosCompra.Enabled = true;
                txbCliente.Enabled = false;
            }
            else
            {
                MessageBox.Show("Insira o nome do cliente, por favor!", "Falta de dados!");
            }
        }

        private void txbCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
