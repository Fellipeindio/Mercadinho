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
        List<ProdutoEstoque> listaProdutos = new List<ProdutoEstoque>();

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
            CarregarProdutosDGV();
        }

        // Alteradores de estado
        private void AlterarAdicionarExcluir(bool estado)
        {
            btnAdicionar.Enabled = estado;
            btnExcluir.Enabled = estado;
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
            ProdutoEstoque produto = new ProdutoEstoque();
            DataTable dataTable = produtoDAO.ReceberProdutos();
            dgvProdutos.DataSource = dataTable;
            dgvProdutos.Refresh();
            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                produto.Codigo = (int)linha.Cells[0].Value;
                produto.Nome = linha.Cells[1].Value.ToString();
                produto.Marca = linha.Cells[2].Value.ToString();
                produto.Preco = linha.Cells[3].Value.ToString();
                produto.Quantidade = linha.Cells[4].Value.ToString();
                listaProdutos.Add(produto);
            }
            if (listaProdutos.Count == 0)
            {
                AlterarExcluirAlterar(false);
                btnComprasProduto.Enabled = false;
            }
            else
            {
                AlterarExcluirAlterar(true);
                btnComprasProduto.Enabled = true;
                InserirProduto();
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
            btnAdicionar.Enabled = false;
            AlterarExcluirAlterar(false);
            LimparCampos();
            acao = EnumAcao.ADICIONAR;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza???", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgvProdutos.CurrentRow.Cells[0].Value;
                ProdutosDAO produtoDAO = new ProdutosDAO();
                produtoDAO.Excluir(id);
                CarregarProdutosDGV();
                LimparCampos();
            }
            btnAdicionar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FaltaDados(txbNome.Text, txbPreco.Text, txbQuant.Text, txbMarca.Text))
            {
                ProdutosDAO produtoDAO = new ProdutosDAO();
                ProdutoEstoque produto = new ProdutoEstoque
                {
                    Nome = txbNome.Text.ToUpper(),
                    Marca = txbMarca.Text.ToUpper(),
                    Preco = txbPreco.Text,
                    Quantidade = txbQuant.Text
                };
                foreach (ProdutoEstoque item in listaProdutos)
                {
                    if (item.Nome == txbNome.Text.ToUpper() && item.Marca == txbMarca.Text.ToUpper() && item.Preco == txbPreco.Text.ToUpper())
                    {
                        ProdutoEstoque produtoExistente = produto;
                        int quantProdIgual = Convert.ToInt32(produtoExistente.Quantidade) + Convert.ToInt32(produto.Quantidade);
                        produto.Quantidade = Convert.ToString(quantProdIgual);
                        acao = EnumAcao.ALTERAR;
                        break;
                    }
                }
                if (acao == EnumAcao.ADICIONAR)
                {

                    produtoDAO.Inserir(produto);
                }
                if (acao == EnumAcao.ALTERAR)
                {
                    produto.Codigo = (int)dgvProdutos.CurrentRow.Cells[0].Value;
                    produtoDAO.Atualizar(produto);
                }
                CarregarProdutosDGV();
                AlterarSalvarCancelar(false);
                AlterarNomePrecoQuant(false);
                AlterarExcluirAlterar(true);
                AlterarAdicionarExcluir(true);
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
            AlterarAdicionarExcluir(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarNomePrecoQuant(true);
            AlterarSalvarCancelar(true);
            AlterarAdicionarExcluir(false);
            acao = EnumAcao.ALTERAR;
        }

        private void lbNome_Click(object sender, EventArgs e)
        {
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

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InserirProduto();
        }

        private void InserirProduto()
        {
            txbNome.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txbMarca.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            txbPreco.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
            txbQuant.Text = dgvProdutos.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
