using Model;
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
    public partial class ListaCadastroJogos : Form
    {
        public ListaCadastroJogos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarJogos novaLista = new CadastrarJogos();
            novaLista.ShowDialog();
        }

        private void ListaCadastroJogos_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            RepositorioJogos repositorio = new RepositorioJogos();
            List<Jogo> listaJogos = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listaJogos.Count; i++)
            {
                Jogo jogo = listaJogos[i];
                string jaLancou = "Sim";
                if (jogo.DataLancamento > DateTime.Now)
                {
                    jaLancou = "Não";
                }
                string precoTexto = $"R$ {jogo.Preco}";



                dataGridView1.Rows.Add(new object[]
                {
                    jogo.ID, jogo.Nome, precoTexto, jogo.Classificacao, jogo.Genero, jaLancou

                });
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            RepositorioJogos repositorio = new RepositorioJogos();
            Jogo jogo = repositorio.ObterPeloId(id);

            AlterarCadastroJogos alterarCadastroJogos = new AlterarCadastroJogos(jogo);
            alterarCadastroJogos.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para deletar");
            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("Deseja mesmo Deletar?", "AVISO",
                            MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RepositorioJogos repositorio = new RepositorioJogos();
                    repositorio.DeletarPeloId(id);
                    AtualizarTabela();

                }
            }
        }
    }
}
