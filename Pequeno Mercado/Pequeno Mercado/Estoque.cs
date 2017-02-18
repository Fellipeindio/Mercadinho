using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NamespaceProdutos;
using NamespaceManipuladores;
using Pequeno_Mercado.ConexaoBanco;
using System.Data;

namespace Pequeno_Mercado
{
    public partial class Estoque : Form
    {
        private EnumAcao acao;
        int indice = 0;
        ProdutoEstoque produtoSelecionado;
        List<ProdutoEstoque> listaProdutos;

        public Estoque()
        {
            InitializeComponent();
        }

        private void lbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void Estoque_Shown(object sender, EventArgs e)
        {
            AlterarNomePrecoQuant(false);
            AlterarSalvarCancelar(false);
            AlterarSelecinaProduto(true);
            CarregarProdutosDGV();
        }

        // Alteradores de estado

        private void AlterarSelecinaProduto(bool estado)
        {
            cbxProdutos.Enabled = estado;
            lbSeleciona.Enabled = estado;
        }

        private void AlterarExcluirAlterar(bool estado)
        {
            btnExcluir.Enabled = estado;
            btnAlterar.Enabled = estado;
        }
        private void AlterarSalvarCancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
            lbQuantidade.Enabled = estado;
            lbNome.Enabled = estado;
            lbPreco.Enabled = estado;
            lbMarca.Enabled = estado;
        }

        private void AlterarNomePrecoQuant(bool estado)
        {
            txbNome.Enabled = estado;
            txbPreco.Enabled = estado;
            txbQuant.Enabled = estado;
            txbMarca.Enabled = estado;
        }

        // Validações

        public bool FaltaDados(string nome, string preco, string quantidade, string marca)
        {
            if (nome != "" || preco != "" || quantidade != "" || marca != "")
            {
                return true;
            }
            return false;
        }

        // Ações não envolvendo botões

        private void CarregarProdutosDGV()
        {
            ProdutosDAO produtoDAO = new ProdutosDAO();
            DataTable dataTable = produtoDAO.ReceberProdutos();
            dgvProdutos.DataSource = dataTable;
            dgvProdutos.Refresh();

            cbxProdutos.Items.Clear();
            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {

                string nome = linha.Cells[1].Value.ToString();
                string marca = linha.Cells[2].Value.ToString();
                string nomeEMarca;
                nomeEMarca = nome + "/" + marca;
                cbxProdutos.Items.Add(nomeEMarca);
            }
            if (cbxProdutos.Items.Count > 0)
            {
                btnComprasProduto.Enabled = true;
            }
            else
            {
                btnComprasProduto.Enabled = false;
            }
        }

        private void LimparCampos()
        {
            txbNome.Text = "";
            txbPreco.Text = "";
            txbQuant.Text = "";
            txbMarca.Text = "";
        }

        //Ações envolvendo botôes

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            AlterarNomePrecoQuant(true);
            AlterarSalvarCancelar(true);
            AlterarSelecinaProduto(false);
            btnAdicionar.Enabled = false;
            acao = EnumAcao.ADICIONAR;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza???", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaProdutos.RemoveAt(indice);
                ManipuladorDeArquivosEstoque.EscreverAquivo(listaProdutos);
                CarregarProdutosDGV();
                LimparCampos();
            }
            btnAdicionar.Enabled = true;
            AlterarExcluirAlterar(false);
            AlterarSelecinaProduto(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (FaltaDados(txbNome.Text, txbPreco.Text, txbQuant.Text, txbMarca.Text))
            {
                ProdutoEstoque produto = new ProdutoEstoque
                {
                    Nome = txbNome.Text.ToUpper(),
                    Marca = txbMarca.Text.ToUpper(),
                    Preco = txbPreco.Text,
                    Quantidade = txbQuant.Text

                };
                foreach (ProdutoEstoque item in listaProdutos)
                {
                    if (item.Nome == txbNome.Text && item.Marca == txbMarca.Text && item.Preco == txbPreco.Text)
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe)
                {
                    ProdutoEstoque produtoExistente = produto;
                    listaProdutos.RemoveAt(indice);
                    int quantProdIgual = Convert.ToInt32(produtoExistente.Quantidade) + Convert.ToInt32(produto.Quantidade);
                    produtoExistente.Quantidade = Convert.ToString(quantProdIgual);
                    listaProdutos.Add(produtoExistente);
                }
                if (acao == EnumAcao.ADICIONAR && !existe)
                {
                    listaProdutos.Add(produto);
                }
                if (acao == EnumAcao.ALTERAR && !existe)
                {
                    listaProdutos.RemoveAt(indice);
                    listaProdutos.Add(produto);
                }
                ManipuladorDeArquivosEstoque.EscreverAquivo(listaProdutos);
                CarregarProdutosDGV();
                AlterarSalvarCancelar(false);
                AlterarNomePrecoQuant(false);
                AlterarSelecinaProduto(true);
                btnAdicionar.Enabled = true;
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Não é possível regitrar produtos com dados insuficientes!!", "Erro ao Salvar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AlterarSalvarCancelar(false);
            AlterarNomePrecoQuant(false);
            AlterarSelecinaProduto(true);
            btnAdicionar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarNomePrecoQuant(true);
            AlterarExcluirAlterar(false);
            AlterarSalvarCancelar(true);
            acao = EnumAcao.ALTERAR;
        }

        private void lbNome_Click(object sender, EventArgs e)
        {
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProdutos.SelectedIndex >= 0)
            {
                indice = cbxProdutos.SelectedIndex;
                produtoSelecionado = listaProdutos[indice];
                txbNome.Text = produtoSelecionado.Nome;
                txbMarca.Text = produtoSelecionado.Marca;
                txbPreco.Text = produtoSelecionado.Preco;
                txbQuant.Text = produtoSelecionado.Quantidade;
            }
            CarregarProdutosDGV();
            AlterarSelecinaProduto(false);
            AlterarExcluirAlterar(true);
            btnAdicionar.Enabled = false;

        }

        private void btnComprasProduto_Click(object sender, EventArgs e)
        {
            Compras comprasClienteFormulario = new Compras();
            comprasClienteFormulario.ShowDialog(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
