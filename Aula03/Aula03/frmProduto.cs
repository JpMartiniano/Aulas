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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {

        }

        private bool VisualizarDados()
        {
            if (txtNomeProd.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo Nome, por favor!!");
                txtNomeProd.Text = "";
                txtNomeProd.Focus();
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
    }
}
