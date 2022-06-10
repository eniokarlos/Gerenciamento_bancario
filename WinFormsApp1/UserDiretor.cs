
namespace WinFormsApp1
{
    public partial class UserDiretor : Form
    {
        String nome;
        String[] data;
        Diretor diretor;
        DbConnect c = new DbConnect();
        public UserDiretor(string nome)
        {
            InitializeComponent();
            this.nome = nome;
            NomeLabel.Text = "Nome: " + nome;
            c.connect();
        }


        private void UserDiretor_Load(object sender, EventArgs e)
        {
            data = c.getFromFuncionario(nome);
            diretor = new Diretor(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[5].ToString());
            NomeLabel.Text = "Nome:" + diretor.Nome;
        }

        private void CorrenteButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CorrenteButton.Checked == true)
            {
                PoupancaButton.Checked = false;
            }
        }

        private void PoupancaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PoupancaButton.Checked == true)
            {
                CorrenteButton.Checked = false;
            }
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            FuncionarioCadastro f = new FuncionarioCadastro();
            f.ShowDialog();
        }

        private void Visualizarbutton_Click(object sender, EventArgs e)
        {
            Visualizar v = new Visualizar(1);
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visualizar v = new Visualizar(2);
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Preencha os campos");
            }
            else if (PoupancaButton.Checked == true && c.isClient("conta_poupanca",textBox1.Text))
            {
                String[] data = c.getFromPoupanca(textBox1.Text);
                ContaPoupanca conta = new ContaPoupanca(data[0], data[1], data[2], data[3], Double.Parse(data[4]));
                if (c.isFuncionario(conta.CpfTitular) == "")
                {
                    c.setEmprestimo("conta_poupanca", textBox1.Text, textBox2.Text.Replace(',', '.'), "0.03");
                    MessageBox.Show("emprestimo concedido");
                }
                else
                {
                    c.setEmprestimo("conta_poupanca", textBox1.Text, textBox2.Text.Replace(',', '.'), "0.01");
                    MessageBox.Show("emprestimo concedido");
                }
            }
            else if (CorrenteButton.Checked == true && c.isClient("conta_poupanca", textBox1.Text))
            {
                data = c.getFromPoupanca(textBox1.Text);
                ContaPoupanca conta = new ContaPoupanca(data[0], data[1], data[2], data[3], Double.Parse(data[4]));
                if (c.isFuncionario(conta.CpfTitular) == "")
                {
                    c.setEmprestimo("conta_corrente", textBox1.Text, textBox2.Text.Replace(',', '.'), "0.03");
                    MessageBox.Show("emprestimo concedido");
                }
                else
                {
                    c.setEmprestimo("conta_corrente", textBox1.Text, textBox2.Text.Replace(',', '.'), "0.01");
                    MessageBox.Show("emprestimo concedido");
                }
            }
            else
            {
                MessageBox.Show("Conta não encontrada");
            }
        }
    }
}
