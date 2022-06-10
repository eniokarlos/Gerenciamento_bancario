
namespace WinFormsApp1
{
    public partial class UserGerente : Form
    {
        private String nome;
        private DbConnect c = new DbConnect();
        private Gerente gerente;
        public UserGerente(string nome)
        {
            InitializeComponent();
            this.nome = nome;
            NomeLabel.Text = "Nome: " + nome;
            c.connect();
        }
        private void UserGerente_Load(object sender, EventArgs e)
        {
            String[] data = c.getFromFuncionario(nome);
            gerente = new Gerente(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[5].ToString(), data[3].ToString());
            NomeLabel.Text = "Nome: " + gerente.Nome;
            AgenciaLabel.Text = "Agencia: " + gerente.Agencia;
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
            signUpWindow janela2 = new signUpWindow();
            janela2.ShowDialog();
        }
        private void Visualizarbutton_Click(object sender, EventArgs e)
        {
            Visualizar v = new Visualizar(3, gerente.Agencia, gerente.Cpf);
            v.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(PoupancaButton.Checked == true)
            {
                if (c.VerificarP(gerente.Id, gerente.Senha))
                {
                    UserPoupanca up = new UserPoupanca(gerente.Id);
                    up.ShowDialog();
                }
            }          
            if(CorrenteButton.Checked == true)
            {
                if (c.VerificarC(gerente.Id, gerente.Senha))
                {
                    UserCorrente uc = new UserCorrente(gerente.Id);
                    uc.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == gerente.Id)
            {
                MessageBox.Show("selecione outra conta");
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Preencha os campos");
                }
                else if (PoupancaButton.Checked == true)
                {
                    c.setEmprestimo("conta_poupanca", textBox1.Text, gerente.Agencia, textBox2.Text.Replace(',', '.'), "0.03");
                    MessageBox.Show("emprestimo concedido");
                }
                else if (CorrenteButton.Checked == true)
                {
                    c.setEmprestimo("conta_corrente", textBox1.Text, gerente.Agencia, textBox2.Text.Replace(',', '.'), "0.03");
                    MessageBox.Show("emprestimo concedido");
                }
                else
                {
                    MessageBox.Show("Selecione corrente/poupanca");
                }
            }       
        }
    }
}
