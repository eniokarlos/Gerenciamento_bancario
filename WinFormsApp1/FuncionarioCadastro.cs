

namespace WinFormsApp1
{
    public partial class FuncionarioCadastro : Form
    {
        private String cargo;
        DbConnect c = new DbConnect();
        public FuncionarioCadastro()
        {
            InitializeComponent();
            c.connect();
        }

        private void GerenteButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GerenteButton.Checked)
            {
                cargo = GerenteButton.Text;
                CaixaButton.Checked = false;
                SecretarioButton.Checked = false;
            }
        }

        private void CaixaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CaixaButton.Checked)
            {
                cargo = CaixaButton.Text;
                GerenteButton.Checked = false;
                SecretarioButton.Checked = false;
            }
        }

        private void SecretarioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SecretarioButton.Checked)
            {
                cargo = SecretarioButton.Text;
                GerenteButton.Checked = false;
                CaixaButton.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cargo == "gerente" && c.VerificarF(AgenciaBox.Text))
            {
                MessageBox.Show("Só pode haver uma gerente por agencia");
            }
            else
            {
                c.insertFuncionario(NameBox.Text, PasswordBox.Text, cargo, AgenciaBox.Text, CpfBox.Text);
                MessageBox.Show("Conta Cadastrada");
            }    
        }
    }
}
