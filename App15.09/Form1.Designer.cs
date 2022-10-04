namespace App15._09
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddLista = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonFecharVenda = new System.Windows.Forms.Button();
            this.textboxProdutos = new System.Windows.Forms.TextBox();
            this.textboxQuatidade = new System.Windows.Forms.TextBox();
            this.textboxPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.listQuantidade = new System.Windows.Forms.ListBox();
            this.listPreco = new System.Windows.Forms.ListBox();
            this.listTotal = new System.Windows.Forms.ListBox();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddLista
            // 
            this.buttonAddLista.BackColor = System.Drawing.Color.Silver;
            this.buttonAddLista.Location = new System.Drawing.Point(15, 121);
            this.buttonAddLista.Name = "buttonAddLista";
            this.buttonAddLista.Size = new System.Drawing.Size(197, 30);
            this.buttonAddLista.TabIndex = 0;
            this.buttonAddLista.Text = "Adicionar produto na lista";
            this.buttonAddLista.UseVisualStyleBackColor = false;
            this.buttonAddLista.Click += new System.EventHandler(this.buttonAddLista_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Silver;
            this.buttonCancelar.Location = new System.Drawing.Point(364, 121);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(142, 30);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar Venda";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Silver;
            this.buttonRemove.Location = new System.Drawing.Point(12, 424);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(494, 43);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remover um produto da lista de compras";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonFecharVenda
            // 
            this.buttonFecharVenda.Location = new System.Drawing.Point(12, 496);
            this.buttonFecharVenda.Name = "buttonFecharVenda";
            this.buttonFecharVenda.Size = new System.Drawing.Size(150, 23);
            this.buttonFecharVenda.TabIndex = 3;
            this.buttonFecharVenda.Text = "Fechar venda";
            this.buttonFecharVenda.UseVisualStyleBackColor = true;
            this.buttonFecharVenda.Click += new System.EventHandler(this.buttonFecharVenda_Click);
            // 
            // textboxProdutos
            // 
            this.textboxProdutos.Location = new System.Drawing.Point(13, 74);
            this.textboxProdutos.Name = "textboxProdutos";
            this.textboxProdutos.Size = new System.Drawing.Size(110, 22);
            this.textboxProdutos.TabIndex = 4;
            this.textboxProdutos.TextChanged += new System.EventHandler(this.textboxProdutos_TextChanged);
            // 
            // textboxQuatidade
            // 
            this.textboxQuatidade.Location = new System.Drawing.Point(138, 74);
            this.textboxQuatidade.Name = "textboxQuatidade";
            this.textboxQuatidade.Size = new System.Drawing.Size(111, 22);
            this.textboxQuatidade.TabIndex = 5;
            // 
            // textboxPreco
            // 
            this.textboxPreco.Location = new System.Drawing.Point(266, 74);
            this.textboxPreco.Name = "textboxPreco";
            this.textboxPreco.Size = new System.Drawing.Size(115, 22);
            this.textboxPreco.TabIndex = 6;
            this.textboxPreco.TextChanged += new System.EventHandler(this.textboxPreco_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produtos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quatidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sub total:";
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.ItemHeight = 16;
            this.listProdutos.Location = new System.Drawing.Point(13, 209);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(110, 180);
            this.listProdutos.TabIndex = 11;
            this.listProdutos.SelectedIndexChanged += new System.EventHandler(this.listProdutos_SelectedIndexChanged);
            // 
            // listQuantidade
            // 
            this.listQuantidade.FormattingEnabled = true;
            this.listQuantidade.ItemHeight = 16;
            this.listQuantidade.Location = new System.Drawing.Point(138, 209);
            this.listQuantidade.Name = "listQuantidade";
            this.listQuantidade.Size = new System.Drawing.Size(111, 180);
            this.listQuantidade.TabIndex = 12;
            this.listQuantidade.SelectedIndexChanged += new System.EventHandler(this.listQuantidade_SelectedIndexChanged);
            // 
            // listPreco
            // 
            this.listPreco.FormattingEnabled = true;
            this.listPreco.ItemHeight = 16;
            this.listPreco.Location = new System.Drawing.Point(266, 209);
            this.listPreco.Name = "listPreco";
            this.listPreco.Size = new System.Drawing.Size(115, 180);
            this.listPreco.TabIndex = 13;
            this.listPreco.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listTotal
            // 
            this.listTotal.FormattingEnabled = true;
            this.listTotal.ItemHeight = 16;
            this.listTotal.Location = new System.Drawing.Point(390, 209);
            this.listTotal.Name = "listTotal";
            this.listTotal.Size = new System.Drawing.Size(116, 180);
            this.listTotal.TabIndex = 14;
            this.listTotal.SelectedIndexChanged += new System.EventHandler(this.listTotal_SelectedIndexChanged);
            // 
            // textboxTotal
            // 
            this.textboxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textboxTotal.Location = new System.Drawing.Point(398, 74);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.Size = new System.Drawing.Size(108, 22);
            this.textboxTotal.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Produtos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Preço unitário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sub total ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total a pagar:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox5.Location = new System.Drawing.Point(406, 487);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(597, 565);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxTotal);
            this.Controls.Add(this.listTotal);
            this.Controls.Add(this.listPreco);
            this.Controls.Add(this.listQuantidade);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxPreco);
            this.Controls.Add(this.textboxQuatidade);
            this.Controls.Add(this.textboxProdutos);
            this.Controls.Add(this.buttonFecharVenda);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAddLista);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa de Supermecado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddLista;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonFecharVenda;
        private System.Windows.Forms.TextBox textboxProdutos;
        private System.Windows.Forms.TextBox textboxQuatidade;
        private System.Windows.Forms.TextBox textboxPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.ListBox listQuantidade;
        private System.Windows.Forms.ListBox listPreco;
        private System.Windows.Forms.ListBox listTotal;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
    }
}

