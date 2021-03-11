using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Mesadinha
{
    class Login
    {
        private static string nome;
        private static string id;
        public bool ValidarUsuario(string email, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql = string.Format("select * from login where email = '{0}' and senha = '{1}'", email, senha);
            DataTable dt = new DataTable();
            dt = bd.ConsultarDado(sql);
            if (dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["usuario"].ToString();
                id = dt.Rows[0]["idlogin"].ToString();
                return true;
            }
            else
            {
                return false;
            }

        }
        public string UsuarioLogado()
        {
            return nome; 
        }
        public string UsuarioLogadoId()
        {
            return id;
        }
    }
}
