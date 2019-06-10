using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repositorio
{
    public class RepositorioConsoles
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Seek3r_Home.mdf;Integrated Security=True;Connect Timeout=30";


        public List<VideoGame> ObterTodos()
        {
            List<VideoGame> listaConsole = new List<VideoGame>();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM consoles";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                VideoGame videoGame = new VideoGame();
                DataRow row = tabela.Rows[i];

                videoGame.Tipo = row["tipo"].ToString();
                videoGame.Versao = row["versao"].ToString();
                videoGame.Preco = Convert.ToDecimal(row["preco"]);
                videoGame.QtdEstoque = Convert.ToInt32(row["qtd_estoque"]);
                videoGame.ID = Convert.ToInt32(row["id"]);

                listaConsole.Add(videoGame);
            }

            return listaConsole;
        }

        public void InserirRegistro(VideoGame videoGame)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO consoles
            (tipo, versao, preco, qtd_estoque)
            VALUES
            (@TIPO, @VERSAO, @PRECO, @QTD_ESTOQUE)";

            comando.Parameters.AddWithValue("@TIPO", videoGame.Tipo);
            comando.Parameters.AddWithValue("@VERSAO", videoGame.Versao);
            comando.Parameters.AddWithValue("@PRECO", videoGame.Preco);
            comando.Parameters.AddWithValue("@QTD_ESTOQUE", videoGame.QtdEstoque);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public VideoGame ObterPeloId(int id)
        {
            VideoGame videoGame = new VideoGame();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM consoles WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            if (tabela.Rows.Count == 1)
            {

                DataRow row = tabela.Rows[0];
                videoGame.Tipo = row["tipo"].ToString();
                videoGame.Versao = row["versao"].ToString();
                videoGame.Preco = Convert.ToDecimal(row["preco"]);
                videoGame.QtdEstoque = Convert.ToInt32(row["qtd_estoque"]);
                videoGame.ID = Convert.ToInt32(row["id"]);

                return videoGame;

            }
            return null;
        }

        public void AtualizarPeloObjeto(VideoGame videoGame)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE consoles SET
            tipo = @TIPO,
            versao = @VERSAO,
            preco = @PRECO,
            qtd_estoque = @QTD_ESTOQUE

            WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", videoGame.ID);
            comando.Parameters.AddWithValue("@TIPO", videoGame.Tipo);
            comando.Parameters.AddWithValue("@VERSAO", videoGame.Versao);
            comando.Parameters.AddWithValue("@PRECO", videoGame.Preco);
            comando.Parameters.AddWithValue("@QTD_ESTOQUE", videoGame.QtdEstoque);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void DeletarPeloID(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@ID", id);
            comando.CommandText = @"DELETE FROM consoles WHERE id = @ID";
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
