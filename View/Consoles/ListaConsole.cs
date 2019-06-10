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

namespace View.Consoles
{
    public partial class ListaConsole : Form
    {
        public ListaConsole()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroConsole cadastro = new CadastroConsole();
            cadastro.ShowDialog();
        }

        private void ListaConsole_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            RepositorioConsoles repositorio = new RepositorioConsoles();

            List<VideoGame> videoGames = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < videoGames.Count; i++)
            {
                VideoGame videoGame = videoGames[i];

                string precoTexto = $"R$ {videoGame.Preco}";
                dataGridView1.Rows.Add(new object[]
                {
                    videoGame.ID, videoGame.Tipo, videoGame.Versao, precoTexto, videoGame.QtdEstoque
                });
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RepositorioConsoles repositorio = new RepositorioConsoles();
            VideoGame videoGame = repositorio.ObterPeloId(id);

            AlterarCadastroConsole alterarCadastro = new AlterarCadastroConsole(videoGame);
            alterarCadastro.ShowDialog();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
                return;
            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("Quer mesmo deletar?", "AVISO",
                            MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RepositorioConsoles repositorio = new RepositorioConsoles();
                    repositorio.DeletarPeloID(id);
                    AtualizarTabela();
                }
            }
        }
    }
}
