using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
   public class RepositorioJogos
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Seek3r_Home.mdf;Integrated Security=True;Connect Timeout=30";

        public void InserirRegistro(Jogo jogo)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO jogos 
            (nome, genero, classificacao, preco, data_lancamento, qtd_estoque)

            VALUES
            (@NOME, @GENERO, @CLASSIFICACAO, @PRECO, @DATA_LANCAMENTO, @QTD_ESTOQUE)";

            comando.Parameters.AddWithValue("@NOME", jogo.Nome);
            comando.Parameters.AddWithValue("@GENERO", jogo.Genero);
            comando.Parameters.AddWithValue("@CLASSIFICACAO", jogo.Classificacao);
            comando.Parameters.AddWithValue("@PRECO", jogo.Preco);
            comando.Parameters.AddWithValue("@DATA_LANCAMENTO", jogo.DataLancamento);
            comando.Parameters.AddWithValue("@QTD_ESTOQUE", jogo.qtdEstoque);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public List<Jogo> ObterTodos()
        {
            List<Jogo> listaJogos = new List<Jogo>();
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            DataTable tabela = new DataTable();
            comando.CommandText = @"SELECT * FROM jogos";
            tabela.Load(comando.ExecuteReader());
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                Jogo jogo = new Jogo();
                DataRow row = tabela.Rows[i];

                jogo.ID = Convert.ToInt32(row["id"]);
                jogo.Nome = row["nome"].ToString();
                jogo.Preco = Convert.ToDecimal(row["preco"]);
                jogo.Genero = row["genero"].ToString();
                jogo.qtdEstoque = Convert.ToInt32(row["qtd_estoque"]);
                jogo.DataLancamento = Convert.ToDateTime(row["data_lancamento"]);
                jogo.Classificacao = row["classificacao"].ToString();

                listaJogos.Add(jogo);
            }

            conexao.Close();
            return listaJogos;
        }


        public Jogo ObterPeloId(int id)
        {
            Jogo jogo = new Jogo();
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM jogos
            WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            if (tabela.Rows.Count == 1)
            {
                DataRow row = tabela.Rows[0];
                jogo.ID = Convert.ToInt32(row["id"]);
                jogo.Nome = row["nome"].ToString();
                jogo.Preco = Convert.ToDecimal(row["preco"]);
                jogo.Genero = row["genero"].ToString();
                jogo.qtdEstoque = Convert.ToInt32(row["qtd_estoque"]);
                jogo.DataLancamento = Convert.ToDateTime(row["data_lancamento"]);
                jogo.Classificacao = row["classificacao"].ToString();

                return jogo;
            }

            conexao.Close();
            return null;
        }

        public void AlterarRegistroPeloJogo(Jogo jogo)
        {
            
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE jogos SET
            nome = @NOME,
            preco = @PRECO,
            data_lancamento = @DATA_LANCAMENTO,
            genero = @GENERO,
            qtd_estoque = @QTD_ESTOQUE,
            classificacao = @CLASSIFICACAO

            WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", jogo.Nome);
            comando.Parameters.AddWithValue("@PRECO", jogo.Preco);
            comando.Parameters.AddWithValue("@DATA_LANCAMENTO", jogo.DataLancamento);
            comando.Parameters.AddWithValue("@GENERO", jogo.Genero);
            comando.Parameters.AddWithValue("@QTD_ESTOQUE", jogo.qtdEstoque);
            comando.Parameters.AddWithValue("@CLASSIFICACAO", jogo.Classificacao);
            comando.Parameters.AddWithValue("@ID", jogo.ID);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

    }
}
