namespace WinFormsApp1
{
    public partial class signUpWindow : Form
    {
        DbConnect c = new DbConnect();
        public signUpWindow()
        {
            InitializeComponent();
        }

        private void Corrente_CheckedChanged(object sender, EventArgs e)
        {
            if(Corrente.Checked == true) 
            {
                Poupanca.Checked = false;
            }
        }

        private void Poupanca_CheckedChanged(object sender, EventArgs e)
        {
            if(Poupanca.Checked == true)
            {
                Corrente.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(Corrente.Checked == true)
            {
                c.connect();
                c.insertCorrente(PasswordBox.Text, NameBox.Text, CpfBox.Text,0,2000, AgenciaBox.Text);
            }
            else
            {
                c.connect();
                c.insertPoupanca(PasswordBox.Text, NameBox.Text, CpfBox.Text, 0, AgenciaBox.Text);
            }
            MessageBox.Show("Conta criada com sucesso!");
            Close();
        }
    }
}
