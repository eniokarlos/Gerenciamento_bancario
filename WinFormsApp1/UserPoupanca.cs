namespace WinFormsApp1
{
    public partial class UserPoupanca : Form
    {
        String conta;
        String[] data;
        ContaPoupanca p;
        DbConnect c = new DbConnect();
        bool flag = true;
        public UserPoupanca(String conta)
        {
            this.conta = conta;
            InitializeComponent();
        }

        private void UserPoupanca_Load(object sender, EventArgs e)
        {
            c.connect();
            data = c.getFromPoupanca(conta);
            p = new ContaPoupanca(data[0], data[1], data[2], data[3], Double.Parse(data[4]));
            label3.Text = c.isFuncionario(p.CpfTitular);
            AccountLabel.Text = "Conta: "+p.Nconta;
            UserLabel.Text = "Nome: "+p.NomeTitular;
            CpfLabel.Text = "Cpf: " + p.CpfTitular;
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
            atualizarSaldo();

            if (data[6] == "")
            {
                data[6] = "0";
            }

            if (data[6] != "0")
            {
                p.ObterEmprestimo(double.Parse(data[6]), double.Parse(data[7]));
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
            if(p.Emprestimo == 0)
            {
                c.setEmprestimo("conta_poupanca", data[0], data[5],"0","0");
            }
        }

        private async void atualizarSaldo()
        {
            while (flag)
            {
                await Task.Delay(30000);
                p.calcularJuros();
                SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
                c.setSaldoPoupanca(conta, p.Saldo.ToString().Replace(',', '.'));           
            }
        }
        private void SacarButton_Click(object sender, EventArgs e)
        {
            p.sacar(Double.Parse(textBox2.Text.Replace('.',',')));
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
            c.setSaldoPoupanca(conta, p.Saldo.ToString().Replace(',','.'));
            c.SaqueExtrato(conta, textBox2.Text.Replace(',', '.'));
        }

        private void DepositarButton_Click(object sender, EventArgs e)
        {
            p.depositar(Double.Parse(textBox1.Text.Replace('.',',')));
            SaldoLabel.Text = "R$ "+String.Format("{0:N}", p.Saldo);
            c.setSaldoPoupanca(conta, p.Saldo.ToString().Replace(',', '.'));
            c.depositoExtrato(conta, textBox1.Text.Replace(',', '.'));
        }

        private void ExtratoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.getExtrato(conta));
        }

        private void UserPoupanca_FormClosing(object sender, FormClosingEventArgs e)
        {
            flag = false;
        }
    }
}
