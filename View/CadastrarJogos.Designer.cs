namespace View
{
    partial class CadastrarJogos
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.dtpDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(9, 75);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(12, 91);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(9, 137);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(63, 13);
            this.lblEstoque.TabIndex = 8;
            this.lblEstoque.Text = "Em estoque";
            this.lblEstoque.Click += new System.EventHandler(this.lblEstoque_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(12, 153);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtEstoque.TabIndex = 9;
            this.txtEstoque.TextChanged += new System.EventHandler(this.txtEstoque_TextChanged);
            // 
            // dtpDataLancamento
            // 
            this.dtpDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamento.Location = new System.Drawing.Point(12, 218);
            this.dtpDataLancamento.Name = "dtpDataLancamento";
            this.dtpDataLancamento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataLancamento.TabIndex = 11;
            this.dtpDataLancamento.ValueChanged += new System.EventHandler(this.dtpDataLancamento_ValueChanged);
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(12, 202);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(107, 13);
            this.lblDataLancamento.TabIndex = 10;
            this.lblDataLancamento.Text = "Data de Lançamento";
            this.lblDataLancamento.Click += new System.EventHandler(this.lblDataLancamento_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Kids",
            "Terror",
            "Rpg",
            "Estratégia",
            "Casual",
            "Simulação"});
            this.cbGenero.Location = new System.Drawing.Point(168, 27);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 3;
            this.cbGenero.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // cbClassificacao
            // 
            this.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificacao.FormattingEnabled = true;
            this.cbClassificacao.Items.AddRange(new object[] {
            "Livre",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.cbClassificacao.Location = new System.Drawing.Point(168, 91);
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(121, 21);
            this.cbClassificacao.TabIndex = 7;
            this.cbClassificacao.SelectedIndexChanged += new System.EventHandler(this.cbClassificacao_SelectedIndexChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(165, 12);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Genero";
            this.lblGenero.Click += new System.EventHandler(this.lblGenero_Click);
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(165, 75);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(69, 13);
            this.lblClassificacao.TabIndex = 6;
            this.lblClassificacao.Text = "Classificação";
            this.lblClassificacao.Click += new System.EventHandler(this.lblClassificacao_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(181, 189);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 49);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadastrarJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 260);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbClassificacao);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.dtpDataLancamento);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblDataLancamento);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastrarJogos";
            this.Text = "Cadastrar Jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.DateTimePicker dtpDataLancamento;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

