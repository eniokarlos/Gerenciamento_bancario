namespace WinFormsApp1
{
    public partial class UserCorrente : Form
    {
        String conta;
        String[] data;
        ContaCorrente p;
        DbConnect c = new DbConnect();
        public UserCorrente(String conta)
        {
            this.conta = conta;
            InitializeComponent();
        }
        private void UserCorrente_Load(object sender, EventArgs e)
        {
            c.connect();
            data = c.getFromCorrente(conta);
            p = new ContaCorrente(data[0], data[1], data[2], data[3], double.Parse(data[4]), double.Parse(data[5]));
            label4.Text = c.isFuncionario(p.CpfTitular);
            AccountLabel.Text = "Conta: " + p.Nconta;
            UserLabel.Text = "Nome: " + p.NomeTitular;
            CpfLabel.Text = "Cpf: " + p.CpfTitular;
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
            LimiteLabel.Text = "R$ " + String.Format("{0:N}", p.LimiteDisponivel);

            if (data[7] == "")
            {
                data[7] = "0";  
            }

            if (data[7] != "0")
            {
                p.ObterEmprestimo(double.Parse(data[7]), double.Parse(data[8]));
                descontar();
            }
        }

        private async void descontar()
        {
            while (p.Emprestimo != 0)
            {
                await Task.Delay(1000);
                p.PagarEmprestimo();
                SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
                c.setSaldoPoupanca(conta, p.Saldo.ToString().Replace(',', '.'));
            }
            if (p.Emprestimo == 0)
            {
                c.setEmprestimo("conta_corrente", data[0], data[6], "0", "0");
            }
        }

        private void SacarButton_Click_1(object sender, EventArgs e)
        {
            p.sacar(Double.Parse(textBox2.Text.Replace('.',',')));
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
            LimiteLabel.Text = "R$ " + String.Format("{0:N}", p.LimiteDisponivel);
            c.setSaldoCorrente(conta, p.Saldo.ToString().Replace(',', '.'), p.LimiteDisponivel.ToString().Replace(',', '.'));
            c.SaqueExtrato(conta, textBox2.Text.Replace(',', '.'));
        }

        private void DepositarButton_Click_1(object sender, EventArgs e)
        {
            p.depositar(Double.Parse(textBox1.Text.Replace('.',',')));
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
            LimiteLabel.Text = "R$ " + String.Format("{0:N}", p.LimiteDisponivel);
            c.setSaldoCorrente(conta, p.Saldo.ToString().Replace(',', '.'), p.LimiteDisponivel.ToString().Replace(',', '.'));
            c.depositoExtrato(conta, textBox1.Text.Replace(',', '.'));
        }

        private void ExtratoButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(c.getExtrato(conta));
        }


    }
}
