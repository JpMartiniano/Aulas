using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btoOk_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtSenha.Text == "123")
            {
                MessageBox.Show("Seja bem-vindo!!!");
                this.Close();
            }

            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Erro, Senha deve ser preenchida");
                txtSenha.Focus();
            }
            else if (txtUser.Text == "")
            {
                MessageBox.Show("Erro, usuário deve ser preenchida");
                txtUser.Focus();
            }

            else
            {
                MessageBox.Show("Usuário ou senha inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
