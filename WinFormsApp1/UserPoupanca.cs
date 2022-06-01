
namespace WinFormsApp1
{
    public partial class UserPoupanca : Form
    {
        String conta;
        ContaPoupanca p;
        DbConnect c = new DbConnect();
        public UserPoupanca(String conta)
        {
            this.conta = conta;
            InitializeComponent();
        }

        private void UserPoupanca_Load(object sender, EventArgs e)
        {
            c.connect();
            String[] data = c.getFromPoupanca(conta);
            c.connect();
            p = new ContaPoupanca(data[0], data[1], data[2], data[3], Double.Parse(data[4]));
            AccountLabel.Text = "Conta: "+p.Nconta;
            UserLabel.Text = "Nome: "+p.NomeTitular;
            CpfLabel.Text = "Cpf: " + p.CpfTitular;
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
        }

        private void SacarButton_Click(object sender, EventArgs e)
        {
            p.sacar(Double.Parse(textBox2.Text));
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
            c.setSaldoPoupanca(conta, p.Saldo.ToString().Replace(',','.'));
            c.SaqueExtrato(conta, textBox2.Text.Replace(',', '.'));
        }

        private void DepositarButton_Click(object sender, EventArgs e)
        {
            p.depositar(Double.Parse(textBox1.Text));
            SaldoLabel.Text = "R$ "+String.Format("{0:N}", p.Saldo);
            c.setSaldoPoupanca(conta, p.Saldo.ToString().Replace(',', '.'));
            c.depositoExtrato(conta, textBox1.Text.Replace(',', '.'));
        }

        private void TaxaButton_Click(object sender, EventArgs e)
        {
            p.calcularJuros();
            SaldoLabel.Text = "R$ " + String.Format("{0:N}", p.Saldo);
            c.setSaldoPoupanca(conta, p.Saldo.ToString().Replace(',', '.'));
        }

        private void ExtratoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.getExtrato(conta));
        }
    }
}
