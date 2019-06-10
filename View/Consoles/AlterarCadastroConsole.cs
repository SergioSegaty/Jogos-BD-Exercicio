using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;

namespace View.Consoles
{
    public partial class AlterarCadastroConsole : Form
    {
        public AlterarCadastroConsole(VideoGame videoGame)
        {
            InitializeComponent();
            cbTipo.Text = videoGame.Tipo;
            cbVersao.Text = videoGame.Versao;
            txtEstoque.Text = videoGame.QtdEstoque.ToString();
            txtPreco.Text = videoGame.Preco.ToString();
            lblID.Text = videoGame.ID.ToString();
        }
    
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            VideoGame videoGame = new VideoGame();

            if (cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Marca");
                cbTipo.DroppedDown = true;
                return;
            }
            videoGame.Tipo = cbTipo.Text;
            videoGame.Versao = cbVersao.Text;
            try
            {
                videoGame.Preco = Convert.ToDecimal(txtPreco.Text);
                if (videoGame.Preco < 0)
                {
                    MessageBox.Show("Somente preço maior que 0");
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
            try
            {
                videoGame.QtdEstoque = Convert.ToInt32(txtEstoque.Text);
                if (videoGame.QtdEstoque < 0)
                {
                    MessageBox.Show("Quantidade precisa ser maior que 0");
                    txtEstoque.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números");
                txtEstoque.Focus();
                return;
            }

            videoGame.ID = Convert.ToInt32(lblID.Text);

            RepositorioConsoles repositorio = new RepositorioConsoles();
            repositorio.AtualizarPeloObjeto(videoGame);
            MessageBox.Show("Cadastro alterado com sucesso");
            Close();
        }

        void AtualizarCBVersao()
        {

            if (cbTipo.Text.ToLower() == "playstation")
            {
                cbVersao.Items.Clear();

                cbVersao.Items.Add("PlayStation 4 Pro");
                cbVersao.Items.Add("PlayStation 4");
                cbVersao.Items.Add("PlayStation 3");
                cbVersao.SelectedIndex = 0;
            }
            else if (cbTipo.Text.ToLower() == "nintendo")
            {
                cbVersao.Items.Clear();
                cbVersao.Items.Add("Switch");
                cbVersao.Items.Add("2DS");
                cbVersao.Items.Add("3DS");
                cbVersao.SelectedIndex = 0;
            }
            else if (cbTipo.Text.ToLower() == "xbox")
            {
                cbVersao.Items.Clear();
                cbVersao.Items.Add("xBox One Pro");
                cbVersao.Items.Add("xBox One");
                cbVersao.Items.Add("xBox 360");
                cbVersao.SelectedIndex = 0;
            }
        }

        private void cbTipo_Leave(object sender, EventArgs e)
        {
            AtualizarCBVersao();
        }
    }
}
