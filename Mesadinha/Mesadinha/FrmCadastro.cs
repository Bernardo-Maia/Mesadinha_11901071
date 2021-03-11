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
    public partial class FormCadastro : Form
    {
        
        public FormCadastro()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql;
        Cadastro objCadastro = new Cadastro();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin cad = new FrmLogin();
            cad.ShowDialog();
           
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            
            if(TxtNome.Text == "" || TxtEmail.Text == "" || TxtSenha.Text == "" || TxtSenha2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para efetuar o cadastro", "ERRO");
                return;
            }
            else
            if (TxtSenha.Text != TxtSenha2.Text)
            {
                MessageBox.Show("As senhas não conferem", "ERRO");
                return;
            }
            else

            if (objCadastro.CadastrarUsuario(TxtNome.Text, TxtEmail.Text, TxtSenha.Text))
            {
                this.Visible = false;
                MessageBox.Show("Cadastrado com Sucesso!!!", "");
                FrmLogin menu = new FrmLogin();
                menu.ShowDialog();
                
            }
            

            this.Visible = false;
            FrmPrincipal cad = new FrmPrincipal();
            cad.ShowDialog();
            
        }
    }
}
