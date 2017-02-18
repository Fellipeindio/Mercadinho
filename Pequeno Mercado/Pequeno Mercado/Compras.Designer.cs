namespace Pequeno_Mercado
{
    partial class Compras
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
            this.lbCompras = new System.Windows.Forms.Label();
            this.lbProdutoCompra = new System.Windows.Forms.Label();
            this.lbQuantidadeCompra = new System.Windows.Forms.Label();
            this.cbxProdutosCompra = new System.Windows.Forms.ComboBox();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnCancelacomprar = new System.Windows.Forms.Button();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.lbLista = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.lbQuantdadeComprada = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbQuantidadeComprada = new System.Windows.Forms.TextBox();
            this.btnCompraProduto = new System.Windows.Forms.Button();
            this.btnOkCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCompras
            // 
            this.lbCompras.AutoSize = true;
            this.lbCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbCompras.Location = new System.Drawing.Point(25, 9);
            this.lbCompras.Name = "lbCompras";
            this.lbCompras.Size = new System.Drawing.Size(239, 29);
            this.lbCompras.TabIndex = 0;
            this.lbCompras.Text = "Compras do Cliente: ";
            // 
            // lbProdutoCompra
            // 
            this.lbProdutoCompra.AutoSize = true;
            this.lbProdutoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbProdutoCompra.Location = new System.Drawing.Point(12, 76);
            this.lbProdutoCompra.Name = "lbProdutoCompra";
            this.lbProdutoCompra.Size = new System.Drawing.Size(148, 20);
            this.lbProdutoCompra.TabIndex = 1;
            this.lbProdutoCompra.Text = "Produto comprado: ";
            // 
            // lbQuantidadeCompra
            // 
            this.lbQuantidadeCompra.AutoSize = true;
            this.lbQuantidadeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbQuantidadeCompra.Location = new System.Drawing.Point(12, 102);
            this.lbQuantidadeCompra.Name = "lbQuantidadeCompra";
            this.lbQuantidadeCompra.Size = new System.Drawing.Size(190, 20);
            this.lbQuantidadeCompra.TabIndex = 2;
            this.lbQuantidadeCompra.Text = "Quantidade em Estoque: ";
            // 
            // cbxProdutosCompra
            // 
            this.cbxProdutosCompra.Enabled = false;
            this.cbxProdutosCompra.FormattingEnabled = true;
            this.cbxProdutosCompra.Location = new System.Drawing.Point(164, 78);
            this.cbxProdutosCompra.Name = "cbxProdutosCompra";
            this.cbxProdutosCompra.Size = new System.Drawing.Size(90, 21);
            this.cbxProdutosCompra.TabIndex = 3;
            this.cbxProdutosCompra.SelectedIndexChanged += new System.EventHandler(this.cbxProdutosCompra_SelectedIndexChanged);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Enabled = false;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFinalizarCompra.Location = new System.Drawing.Point(12, 312);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(113, 23);
            this.btnFinalizarCompra.TabIndex = 5;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnCancelacomprar
            // 
            this.btnCancelacomprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancelacomprar.Location = new System.Drawing.Point(140, 312);
            this.btnCancelacomprar.Name = "btnCancelacomprar";
            this.btnCancelacomprar.Size = new System.Drawing.Size(132, 23);
            this.btnCancelacomprar.TabIndex = 6;
            this.btnCancelacomprar.Text = "Cancelar Compra ";
            this.btnCancelacomprar.UseVisualStyleBackColor = true;
            this.btnCancelacomprar.Click += new System.EventHandler(this.btnCancelacomprar_Click);
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.HorizontalScrollbar = true;
            this.lbxLista.Location = new System.Drawing.Point(69, 191);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(203, 82);
            this.lbxLista.TabIndex = 7;
            // 
            // lbLista
            // 
            this.lbLista.AutoSize = true;
            this.lbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLista.Location = new System.Drawing.Point(12, 224);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(51, 20);
            this.lbLista.TabIndex = 9;
            this.lbLista.Text = "Lista: ";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Enabled = false;
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbQuantidade.Location = new System.Drawing.Point(198, 102);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(56, 26);
            this.txbQuantidade.TabIndex = 10;
            this.txbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbValor.Location = new System.Drawing.Point(12, 283);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(157, 20);
            this.lbValor.TabIndex = 13;
            this.lbValor.Text = "Valor da Compra: R$";
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Enabled = false;
            this.txbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbValorTotal.Location = new System.Drawing.Point(164, 283);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(103, 26);
            this.txbValorTotal.TabIndex = 14;
            this.txbValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbQuantdadeComprada
            // 
            this.lbQuantdadeComprada.AutoSize = true;
            this.lbQuantdadeComprada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbQuantdadeComprada.Location = new System.Drawing.Point(12, 128);
            this.lbQuantdadeComprada.Name = "lbQuantdadeComprada";
            this.lbQuantdadeComprada.Size = new System.Drawing.Size(186, 20);
            this.lbQuantdadeComprada.TabIndex = 11;
            this.lbQuantdadeComprada.Text = "Quantidade Compradas: ";
            // 
            // txbCliente
            // 
            this.txbCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCliente.Location = new System.Drawing.Point(16, 53);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(195, 20);
            this.txbCliente.TabIndex = 16;
            this.txbCliente.Text = "Insira o Nome do Cliente";
            this.txbCliente.Click += new System.EventHandler(this.txbCliente_Click);
            this.txbCliente.TextChanged += new System.EventHandler(this.txbCliente_TextChanged);
            // 
            // txbQuantidadeComprada
            // 
            this.txbQuantidadeComprada.Location = new System.Drawing.Point(204, 131);
            this.txbQuantidadeComprada.Name = "txbQuantidadeComprada";
            this.txbQuantidadeComprada.Size = new System.Drawing.Size(50, 20);
            this.txbQuantidadeComprada.TabIndex = 17;
            // 
            // btnCompraProduto
            // 
            this.btnCompraProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCompraProduto.Location = new System.Drawing.Point(83, 162);
            this.btnCompraProduto.Name = "btnCompraProduto";
            this.btnCompraProduto.Size = new System.Drawing.Size(128, 23);
            this.btnCompraProduto.TabIndex = 18;
            this.btnCompraProduto.Text = "Comprar Produto";
            this.btnCompraProduto.UseVisualStyleBackColor = true;
            this.btnCompraProduto.Click += new System.EventHandler(this.btnCompraProduto_Click);
            // 
            // btnOkCliente
            // 
            this.btnOkCliente.Location = new System.Drawing.Point(217, 51);
            this.btnOkCliente.Name = "btnOkCliente";
            this.btnOkCliente.Size = new System.Drawing.Size(37, 23);
            this.btnOkCliente.TabIndex = 19;
            this.btnOkCliente.Text = "Ok!";
            this.btnOkCliente.UseVisualStyleBackColor = true;
            this.btnOkCliente.Click += new System.EventHandler(this.btnOkCliente_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.btnOkCliente);
            this.Controls.Add(this.btnCompraProduto);
            this.Controls.Add(this.txbQuantidadeComprada);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.txbValorTotal);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbQuantdadeComprada);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.btnCancelacomprar);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.cbxProdutosCompra);
            this.Controls.Add(this.lbQuantidadeCompra);
            this.Controls.Add(this.lbProdutoCompra);
            this.Controls.Add(this.lbCompras);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.Shown += new System.EventHandler(this.Compras_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCompras;
        private System.Windows.Forms.Label lbProdutoCompra;
        private System.Windows.Forms.Label lbQuantidadeCompra;
        private System.Windows.Forms.ComboBox cbxProdutosCompra;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnCancelacomprar;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.Label lbQuantdadeComprada;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.TextBox txbQuantidadeComprada;
        private System.Windows.Forms.Button btnCompraProduto;
        private System.Windows.Forms.Button btnOkCliente;
    }
}