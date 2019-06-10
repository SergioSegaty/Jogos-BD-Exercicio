namespace View
{
    partial class CadastroLojaJogos
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
            this.btnJogos = new System.Windows.Forms.Button();
            this.btnConsoles = new System.Windows.Forms.Button();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogos
            // 
            this.btnJogos.Location = new System.Drawing.Point(12, 12);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(129, 47);
            this.btnJogos.TabIndex = 0;
            this.btnJogos.Text = "Lista Jogos";
            this.btnJogos.UseVisualStyleBackColor = true;
            this.btnJogos.Click += new System.EventHandler(this.btnJogos_Click);
            // 
            // btnConsoles
            // 
            this.btnConsoles.Location = new System.Drawing.Point(12, 75);
            this.btnConsoles.Name = "btnConsoles";
            this.btnConsoles.Size = new System.Drawing.Size(129, 47);
            this.btnConsoles.TabIndex = 0;
            this.btnConsoles.Text = "Lista Consoles";
            this.btnConsoles.UseVisualStyleBackColor = true;
            this.btnConsoles.Click += new System.EventHandler(this.btnConsoles_Click);
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Location = new System.Drawing.Point(12, 138);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(129, 47);
            this.btnColaboradores.TabIndex = 0;
            this.btnColaboradores.Text = "Lista Colaboradores";
            this.btnColaboradores.UseVisualStyleBackColor = true;
            // 
            // CadastroLojaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 199);
            this.Controls.Add(this.btnColaboradores);
            this.Controls.Add(this.btnConsoles);
            this.Controls.Add(this.btnJogos);
            this.Name = "CadastroLojaJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroLojaJogos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.Button btnConsoles;
        private System.Windows.Forms.Button btnColaboradores;
    }
}