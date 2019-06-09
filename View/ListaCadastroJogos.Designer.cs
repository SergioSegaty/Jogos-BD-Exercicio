namespace View
{
    partial class ListaCadastroJogos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLancou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnPreco,
            this.ColumnClassificacao,
            this.ColumnGenero,
            this.ColumnLancou});
            this.dataGridView1.Location = new System.Drawing.Point(5, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(638, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(5, 37);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 45);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Salmon;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(554, 37);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(89, 45);
            this.btnDeletar.TabIndex = 1;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 55;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 140;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // ColumnClassificacao
            // 
            this.ColumnClassificacao.HeaderText = "Classificação Etária";
            this.ColumnClassificacao.Name = "ColumnClassificacao";
            this.ColumnClassificacao.ReadOnly = true;
            // 
            // ColumnGenero
            // 
            this.ColumnGenero.HeaderText = "Genero";
            this.ColumnGenero.Name = "ColumnGenero";
            this.ColumnGenero.ReadOnly = true;
            // 
            // ColumnLancou
            // 
            this.ColumnLancou.HeaderText = "Já Lançou?";
            this.ColumnLancou.Name = "ColumnLancou";
            this.ColumnLancou.ReadOnly = true;
            // 
            // ListaCadastroJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 336);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaCadastroJogos";
            this.Text = "ListaCadastroJogos";
            this.Activated += new System.EventHandler(this.ListaCadastroJogos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLancou;
    }
}