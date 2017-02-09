using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NamespaceProdutos;
using NamespaceManipuladores;

namespace Pequeno_Mercado
{
    public partial class Estoque : Form
    {
        private EnumAcao acao;
        int indice = 0;
        ProdutoEstoque produtoSelecionado;

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
            CarregarProdutos();
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
        }

        private void AlterarNomePrecoQuant(bool estado)
        {
            txbNome.Enabled = estado;
            txbPreco.Enabled = estado;
            txbQuant.Enabled = estado;
        }

        // Validações

        public bool FaltaDados(string nome, string preco, string quantidade)
        {
            if (nome != "" || preco != "" || quantidade != "")
            {
                return true;
            }
            return false;
        }

        // Ações não envolvendo botões

        private void CarregarProdutos()
        {
            lbxProdutos.Items.Clear();
            cbxProdutos.Items.Clear();
            Dictionary<string, ProdutoEstoque> dicProdutos = ManipuladorDeArquivosEstoque.LerArquivo();
            foreach (KeyValuePair<string,ProdutoEstoque> elemento in dicProdutos)
            {
                cbxProdutos.Items.Add(elemento.Key);
                lbxProdutos.Items.Add(elemento.Value);
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
            int indiceExcluido = indice;
            if (MessageBox.Show("Tem Certeza???", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dictionary<string, ProdutoEstoque> dicProduto = new Dictionary<string, ProdutoEstoque>();
                dicProduto.Remove(produtoSelecionado.Nome);
                ManipuladorDeArquivosEstoque.EscreverAquivo(dicProduto);
                CarregarProdutos();
                LimparCampos();
            }
            btnAdicionar.Enabled = true;
            AlterarExcluirAlterar(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (FaltaDados(txbNome.Text, txbPreco.Text, txbQuant.Text))
            {
                ProdutoEstoque produto = new ProdutoEstoque
                {
                    Nome = txbNome.Text.ToUpper(),
                    Preco = txbPreco.Text,
                    Quantidade = txbQuant.Text
                };
                Dictionary<string, ProdutoEstoque> dicProduto = ManipuladorDeArquivosEstoque.LerArquivo();
                if (dicProduto.ContainsKey(produto.Nome))
                {
                    existe = true;
                    ProdutoEstoque produtoExistente = dicProduto[produto.Nome];
                    dicProduto.Remove(produto.Nome);
                    int quantProdIgual = Convert.ToInt32(produtoExistente.Quantidade) + Convert.ToInt32(produto.Quantidade);
                    produtoExistente.Quantidade = Convert.ToString(quantProdIgual);
                    dicProduto.Add(produtoExistente.Nome, produtoExistente);
                }
                if (acao == EnumAcao.ADICIONAR && !existe)
                {
                    dicProduto.Add(produto.Nome, produto);
                }
                if (acao == EnumAcao.ALTERAR)
                {
                    dicProduto.Remove(produtoSelecionado.Nome);
                    dicProduto.Add(produto.Nome, produto);
                }
                ManipuladorDeArquivosEstoque.EscreverAquivo(dicProduto);
                CarregarProdutos();
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
                Dictionary<string, ProdutoEstoque> lista = ManipuladorDeArquivosEstoque.LerArquivo();
                produtoSelecionado = lista[(string)cbxProdutos.SelectedItem];
                txbNome.Text = produtoSelecionado.Nome;
                txbPreco.Text = produtoSelecionado.Preco;
                txbQuant.Text = produtoSelecionado.Quantidade;
            }
            CarregarProdutos();
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
