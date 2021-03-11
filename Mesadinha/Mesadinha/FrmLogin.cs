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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        string sql;
        Login objlogin = new Login();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormCadastro cad = new FormCadastro();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "" || TxtSenha.Text == "")
            {
                MessageBox.Show("Prencha todos os campos", "ERRO");
                return;
            }
            if (objlogin.ValidarUsuario(TxtEmail.Text, TxtSenha.Text))
            {
                this.Visible = false;
                FrmPrincipal menu = new FrmPrincipal();
                menu.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos...", "Erro login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
