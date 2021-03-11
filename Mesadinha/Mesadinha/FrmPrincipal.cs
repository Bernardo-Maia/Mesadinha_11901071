using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesadinha
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        Login objLogin = new Login();
        ConexaoBD bd = new ConexaoBD();
        string sql;
        

        
        public void Limpar()

        {
            TxtId.Clear();
            TxtNome.Clear();
            TxtValor.Clear();
            CmbTipo.SelectedIndex = -1;
        }
        public void Listar()
        {
            string id = objLogin.UsuarioLogadoId();
            sql = string.Format("select nome, valor, tipo, idcategoria as id from despesas where login_idlogin = '{0}'", id);
            DtgLista.DataSource = bd.ConsultarDado(sql);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string id = objLogin.UsuarioLogadoId();
            LblSuaid.Text = "Sua Id: " + id;
            Listar();
            LblInicio.Text = "Bem vindo " + objLogin.UsuarioLogado();
            

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            string id = objLogin.UsuarioLogadoId();
            sql = string.Format("insert into despesas values(null, '{0}','{1}','{2}',{3})", TxtNome.Text, TxtValor.Text, CmbTipo.Text, id);
            bd.AlterarDados(sql);
            MessageBox.Show("Cadastrado com sucesso!", "", MessageBoxButtons.OK);
            Limpar();
            Listar();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            
            sql = string.Format("Delete from despesas where idcategoria = '{0}'", TxtId.Text);
            bd.AlterarDados(sql);
            MessageBox.Show("Despesa / Entrada excluida com sucesso!", "", MessageBoxButtons.OK);
            Limpar();
            Listar();
        }
        private void frmPrincipal_load(object sender, EventArgs e)
        {
            LblInicio.Text = "Bem vindo " + objLogin.UsuarioLogado() + "!";
        }
    }
}
