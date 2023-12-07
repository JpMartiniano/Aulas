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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {

            if (ValidarDados())
            {
                MessageBox.Show("Dados cadastrados com sucesso!!!", "Cadastro");
            }
        }

        private bool ValidarDados()
        {
            if (txtNomeCat.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo Nome Categoria, por favor!!");
                txtNomeCat.Text = "";
                txtNomeCat.Focus();
                return false;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, selecione o status, por favor!!");
                cboStatus.Focus();
                return false;
            }

            return true;
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            int numI;

            if (txtId.Text == "")
            {
                MessageBox.Show("Erro, para alterar cadastro, ID deve estar preenchido");
            }

            else if (!int.TryParse(txtId.Text, out numI))
            {
                MessageBox.Show("Erro, ID deve ser numérico");
                txtId.Text = "";
                txtId.Focus();
            }

            else
            {
                MessageBox.Show("Dados alterados com sucesso!");
            }
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            int numI;

            if (txtId.Text == "")
            {
                MessageBox.Show("Erro, para excluir cadastro, ID deve estar preenchido");
            }

            else if (!int.TryParse(txtId.Text, out numI))
            {
                MessageBox.Show("Erro, ID deve ser numérico");
                txtId.Text = "";
                txtId.Focus();
            }

            else
            {
                txtId.Text = "";
                MessageBox.Show("Dados excluídos com sucesso!!!");

            }
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDescricao.Text = "";
            txtNomeCat.Text = "";
            cboStatus.SelectedIndex = -1;
        }
    }
}
