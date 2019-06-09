namespace View
{
    partial class AlterarCadastroJogos
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.dtpDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(180, 213);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 49);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "Alterar Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.cbClassificacao.Location = new System.Drawing.Point(167, 115);
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(121, 21);
            this.cbClassificacao.TabIndex = 20;
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
            this.cbGenero.Location = new System.Drawing.Point(167, 51);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 16;
            // 
            // dtpDataLancamento
            // 
            this.dtpDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLancamento.Location = new System.Drawing.Point(11, 242);
            this.dtpDataLancamento.Name = "dtpDataLancamento";
            this.dtpDataLancamento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataLancamento.TabIndex = 24;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(11, 177);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtEstoque.TabIndex = 22;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(8, 161);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(63, 13);
            this.lblEstoque.TabIndex = 21;
            this.lblEstoque.Text = "Em estoque";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(11, 115);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 18;
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(11, 226);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(107, 13);
            this.lblDataLancamento.TabIndex = 23;
            this.lblDataLancamento.Text = "Data de Lançamento";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(164, 99);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(69, 13);
            this.lblClassificacao.TabIndex = 19;
            this.lblClassificacao.Text = "Classificação";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(8, 99);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 17;
            this.lblPreco.Text = "Preço";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(164, 36);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 15;
            this.lblGenero.Text = "Genero";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 14;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, -17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // AletrarCadastroJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 285);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNome);
            this.Name = "AletrarCadastroJogo";
            this.Text = "AletrarCadastroJogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.DateTimePicker dtpDataLancamento;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
    }
}