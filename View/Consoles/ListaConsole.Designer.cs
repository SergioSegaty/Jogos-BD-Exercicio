namespace View.Consoles
{
    partial class ListaConsole
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVersao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Salmon;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(413, 7);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(89, 45);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(6, 8);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 45);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnTipo,
            this.ColumnVersao,
            this.ColumnPreco,
            this.ColumnQtd});
            this.dataGridView1.Location = new System.Drawing.Point(6, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(496, 192);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Código";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 50;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Marca";
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            // 
            // ColumnVersao
            // 
            this.ColumnVersao.HeaderText = "Versão";
            this.ColumnVersao.Name = "ColumnVersao";
            this.ColumnVersao.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // ColumnQtd
            // 
            this.ColumnQtd.HeaderText = "Quantidade Estoque";
            this.ColumnQtd.Name = "ColumnQtd";
            this.ColumnQtd.ReadOnly = true;
            // 
            // ListaConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 258);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "ListaConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque Consoles";
            this.Activated += new System.EventHandler(this.ListaConsole_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVersao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtd;
    }
}