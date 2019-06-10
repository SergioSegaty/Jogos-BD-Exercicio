using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.Consoles;

namespace View
{
    public partial class CadastroLojaJogos : Form
    {
        public CadastroLojaJogos()
        {
            InitializeComponent();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            ListaCadastroJogos listaCadastroJogos = new ListaCadastroJogos();
            listaCadastroJogos.ShowDialog();
        }

        private void btnConsoles_Click(object sender, EventArgs e)
        {
            ListaConsole listaConsole = new ListaConsole();
            listaConsole.ShowDialog();
        }
    }
}
