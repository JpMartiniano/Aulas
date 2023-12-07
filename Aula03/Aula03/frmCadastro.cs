namespace Aula03
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        DateTime DataHoje;
        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtCpf.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtObservacao.Text = "";
            txtID.Text = "";
            cboUF.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            txtNome.Focus();

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
            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo Nome, por favor!!");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }

            if (dtpDataNascimento.Value > DataHoje)
            {
                MessageBox.Show("Erro, Data Nascimento inválida, data deve ser menor que a de hoje!!");
                dtpDataNascimento.Value = DataHoje;
                dtpDataNascimento.Focus();
                return false;
            }

            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, selecione seu Genero, por favor!!");
                cboGenero.Focus();
                return false;
            }

            if (txtCpf.MaskFull == false)
            {
                MessageBox.Show("Erro, preencha o campo Cpf, por favor!!");
                txtCpf.Text = "";
                txtCpf.Focus();
                return false;
            }

            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo Logradouro, por favor!!");
                txtLogradouro.Text = "";
                txtLogradouro.Focus();
                return false;
            }

            if (txtNumero.Value <= 0)
            {
                MessageBox.Show("Erro, preencha o campo Número, por favor!!");
                txtNumero.Value = 0;
                txtNumero.Focus();
                return false;
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo Bairro, por favor!!");
                txtBairro.Text = "";
                txtBairro.Focus();
                return false;
            }

            if (txtCep.MaskFull == false)
            {
                MessageBox.Show("Erro, preencha o campo CEP, por favor!!");
                txtCep.Text = "";
                txtCep.Focus();
                return false;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Erro, preencha o campo Cidade, por favor!!");
                txtCidade.Text = "";
                txtCidade.Focus();
                return false;
            }

            if (cboUF.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, selecione sua UF, por favor!!");
                cboUF.Focus();
                return false;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, selecione sua Status, por favor!!");
                cboStatus.Focus();
                return false;
            }

            

            else if (cboEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, selecione sua Estado Civil, por favor!!");
                cboEstadoCivil.Focus();
                return false;
            }

            

            

           

            return true;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            DataHoje = DateTime.Now;
            txtDataCadastro.Text = DataHoje.ToString();
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            int numI;
            
            if (txtID.Text == "")
            {
                MessageBox.Show("Erro, para excluir cadastro, ID deve estar preenchido");
            }

            else if (!int.TryParse(txtID.Text, out numI))
            {
                MessageBox.Show("Erro, ID deve ser numérico");
                txtID.Text = "";
                txtID.Focus();
            }

            else
            {
                txtID.Text = "";
                MessageBox.Show("Dados excluídos com sucesso!!!");

            }

        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            int numI;

            if (txtID.Text == "")
            {
                MessageBox.Show("Erro, para alterar cadastro, ID deve estar preenchido");
            }

            else if (!int.TryParse(txtID.Text, out numI))
            {
                MessageBox.Show("Erro, ID deve ser numérico");
                txtID.Text = "";
                txtID.Focus();
            }

            else
            {
                MessageBox.Show("Dados alterados com sucesso!");
            }
            
        }

        
    }
}