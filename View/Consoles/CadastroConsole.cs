using System;
using Model;
using Repositorio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Consoles
{
    public partial class CadastroConsole : Form
    {
        public CadastroConsole()
        {
            InitializeComponent();
        }

        private void CadastroConsole_Activated(object sender, EventArgs e)
        {
            if (cbTipo.Text == "")
            {
                cbVersao.Items.Add("Selecione Um Tipo");
                cbVersao.SelectedIndex = 0;
            }
        }

        private void cbTipo_Leave(object sender, EventArgs e)
        {
            AtualizarCBVersao();
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
            RepositorioConsoles repositorio = new RepositorioConsoles();
            repositorio.InserirRegistro(videoGame);
            MessageBox.Show("Registro feito com sucesso");
            Close();

        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }

        private void lblEstoque_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbVersao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
