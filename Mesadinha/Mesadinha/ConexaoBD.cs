using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Adicionar bibliotecas
using System.Data;
using MySql.Data.MySqlClient;
namespace Mesadinha
{
    class ConexaoBD
    {
        // Conexão com o banco
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            try
            {
                conexao = new MySqlConnection("Persist Security info = false;server=localhost;database=mesadinha;user=root;pwd=;");
                conexao.Open();
            }
            catch
            {
                throw;
            }
        }
        // Modificar dados (insert, delete, update)
        public void AlterarDados(string sql)
        {
            try
            {
                ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

        }
        //Selecinar dados
        public DataTable ConsultarDado(string sql)
        {
            try
            {
                ConectarBD();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
