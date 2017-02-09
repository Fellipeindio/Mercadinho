namespace Pequeno_Mercado
{
    partial class Estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEstoque = new System.Windows.Forms.Label();
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbQuant = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbxOpçoes = new System.Windows.Forms.GroupBox();
            this.cbxProdutos = new System.Windows.Forms.ComboBox();
            this.lbSeleciona = new System.Windows.Forms.Label();
            this.btnComprasProduto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.gbxOpçoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbEstoque.Location = new System.Drawing.Point(63, 9);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(198, 25);
            this.lbEstoque.TabIndex = 0;
            this.lbEstoque.Text = "Produtos no estoque:";
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.HorizontalScrollbar = true;
            this.lbxProdutos.Location = new System.Drawing.Point(30, 37);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(279, 56);
            this.lbxProdutos.TabIndex = 1;
            this.lbxProdutos.SelectedIndexChanged += new System.EventHandler(this.lbxProdutos_SelectedIndexChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(18, 19);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(222, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(60, 48);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(163, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNome.Location = new System.Drawing.Point(9, 227);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(127, 17);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome do Produto: ";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPreco.Location = new System.Drawing.Point(9, 282);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(127, 17);
            this.lbPreco.TabIndex = 7;
            this.lbPreco.Text = "Preço do Produto: ";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbQuantidade.Location = new System.Drawing.Point(9, 311);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(164, 17);
            this.lbQuantidade.TabIndex = 8;
            this.lbQuantidade.Text = "Quantidade do Produto: ";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(137, 227);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(113, 20);
            this.txbNome.TabIndex = 9;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(137, 281);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(97, 20);
            this.txbPreco.TabIndex = 10;
            // 
            // txbQuant
            // 
            this.txbQuant.Location = new System.Drawing.Point(175, 310);
            this.txbQuant.Name = "txbQuant";
            this.txbQuant.Size = new System.Drawing.Size(59, 20);
            this.txbQuant.TabIndex = 11;
            this.txbQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(121, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gbxOpçoes
            // 
            this.gbxOpçoes.Controls.Add(this.btnSalvar);
            this.gbxOpçoes.Controls.Add(this.btnAlterar);
            this.gbxOpçoes.Controls.Add(this.btnAdicionar);
            this.gbxOpçoes.Controls.Add(this.btnExcluir);
            this.gbxOpçoes.Controls.Add(this.btnCancelar);
            this.gbxOpçoes.Location = new System.Drawing.Point(12, 99);
            this.gbxOpçoes.Name = "gbxOpçoes";
            this.gbxOpçoes.Size = new System.Drawing.Size(313, 76);
            this.gbxOpçoes.TabIndex = 13;
            this.gbxOpçoes.TabStop = false;
            this.gbxOpçoes.Text = "Opções";
            // 
            // cbxProdutos
            // 
            this.cbxProdutos.FormattingEnabled = true;
            this.cbxProdutos.Location = new System.Drawing.Point(175, 194);
            this.cbxProdutos.Name = "cbxProdutos";
            this.cbxProdutos.Size = new System.Drawing.Size(107, 21);
            this.cbxProdutos.TabIndex = 13;
            this.cbxProdutos.SelectedIndexChanged += new System.EventHandler(this.cbxProdutos_SelectedIndexChanged);
            // 
            // lbSeleciona
            // 
            this.lbSeleciona.AutoSize = true;
            this.lbSeleciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSeleciona.Location = new System.Drawing.Point(29, 195);
            this.lbSeleciona.Name = "lbSeleciona";
            this.lbSeleciona.Size = new System.Drawing.Size(144, 17);
            this.lbSeleciona.TabIndex = 0;
            this.lbSeleciona.Text = "Selecione o Produto: ";
            // 
            // btnComprasProduto
            // 
            this.btnComprasProduto.Enabled = false;
            this.btnComprasProduto.Location = new System.Drawing.Point(250, 282);
            this.btnComprasProduto.Name = "btnComprasProduto";
            this.btnComprasProduto.Size = new System.Drawing.Size(75, 23);
            this.btnComprasProduto.TabIndex = 14;
            this.btnComprasProduto.Text = "Compras";
            this.btnComprasProduto.UseVisualStyleBackColor = true;
            this.btnComprasProduto.Click += new System.EventHandler(this.btnComprasProduto_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(250, 311);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMarca.Location = new System.Drawing.Point(9, 255);
            this.lbMarca.Name = "lblMarca";
            this.lbMarca.Size = new System.Drawing.Size(125, 17);
            this.lbMarca.TabIndex = 16;
            this.lbMarca.Text = "Marca do Produto:";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(137, 254);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(113, 20);
            this.txbMarca.TabIndex = 18;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 339);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnComprasProduto);
            this.Controls.Add(this.lbSeleciona);
            this.Controls.Add(this.cbxProdutos);
            this.Controls.Add(this.gbxOpçoes);
            this.Controls.Add(this.txbQuant);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbxProdutos);
            this.Controls.Add(this.lbEstoque);
            this.Name = "Estoque";
            this.Text = "Mercadinho";
            this.Shown += new System.EventHandler(this.Estoque_Shown);
            this.gbxOpçoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbQuant;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gbxOpçoes;
        private System.Windows.Forms.ComboBox cbxProdutos;
        private System.Windows.Forms.Label lbSeleciona;
        private System.Windows.Forms.Button btnComprasProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txbMarca;
    }
}

