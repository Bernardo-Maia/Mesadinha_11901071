using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Mesadinha
{
    class Cadastro
    {
        public bool CadastrarUsuario(string usuario, string email, string senha)
        {
            
            ConexaoBD bd = new ConexaoBD();
            string sql = string.Format("insert into login values (null,'{0}','{1}','{2}')", usuario, senha, email);
            bd.AlterarDados(sql);
            return true;

        }
    }
}
