﻿using Model;
using Repositorio;
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

            Repositorio.Repositorio repositorio = new Repositorio.Repositorio();
            repositorio.InserirRegistro(jogo);


        }

        private void cbClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDataLancamento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEstoque_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDataLancamento_Click(object sender, EventArgs e)
        {

        }

        private void lblClassificacao_Click(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
