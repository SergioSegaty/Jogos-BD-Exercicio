using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace View
{
    public partial class CadastrarJogos : Form
    {
        public CadastrarJogos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();

            if (txtNome.Text.Length < 2)
            {
                MessageBox.Show("Por favor, registre o nome do jogo");
                txtNome.Focus();
                return;
            }
            jogo.Nome = txtNome.Text;

            if (cbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um genero");
                cbGenero.DroppedDown = true;
                return;
            }
            jogo.Genero = cbGenero.Text;

            try
            {
                jogo.Preco = Convert.ToDecimal(txtPreco.Text);
                if (jogo.Preco < 0)
                {
                    MessageBox.Show("Somente números numeros iguais ou maior que 0");
                    txtPreco.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números");
                txtPreco.Focus();
                return;
            }

            if (cbClassificacao.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma classificação");
                cbClassificacao.DroppedDown = true;
                return;
            }
            jogo.Classificacao = cbClassificacao.Text;

            try
            {
                jogo.qtdEstoque = Convert.ToInt32(txtEstoque.Text);
                if (jogo.qtdEstoque < 0)
                {
                    MessageBox.Show("A quantidade precisa ser maior que 0");
                    txtEstoque.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números!");
                txtEstoque.Focus();
                return;
            }

            jogo.DataLancamento = dtpDataLancamento.Value;

            Repositorio repositorio = new Repositorio();
            repositorio.InserirRegistro(jogo);


        }
    }
}
