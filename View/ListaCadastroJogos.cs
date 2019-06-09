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
            Repositorio repositorio = new Repositorio();
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
    }
}
