
namespace WinFormsApp1
{
    public partial class signInWindow : Form
    {
        private bool admin;
        DbConnect c = new DbConnect();
        public signInWindow(bool admin)
        {
            this.admin = admin;
            InitializeComponent();
            c.connect();
        }
        private void Corrente_CheckedChanged(object sender, EventArgs e)
        {
            if(Corrente.Checked == true)
            {
                poupanca.Checked = false;
            }
        }

        private void poupanca_CheckedChanged(object sender, EventArgs e)
        {
            if (poupanca.Checked == true)
            {
                Corrente.Checked = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                String aux = c.VerificarF(Accountbox.Text, PassBox.Text);
                if (aux != "")
                {
                    switch (aux)
                    {
                        case "diretor":
                            c.disconnect();
                            UserDiretor ud = new UserDiretor(Accountbox.Text);
                            ud.ShowDialog();
                            Close();
                            break;
                        case "gerente":
                            c.disconnect();
                            UserGerente g = new UserGerente(Accountbox.Text);
                            g.ShowDialog();
                            Close();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("conta não encontrada");
                }
            }
            
            else if (poupanca.Checked == true)
            {
                
                if (c.VerificarP(Accountbox.Text, PassBox.Text))
                {
                    c.disconnect();
                    UserPoupanca up = new UserPoupanca(Accountbox.Text);
                    up.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Conta não encontrada");
                }
            }
            else if(Corrente.Checked == true)
            {
                if (c.VerificarC(Accountbox.Text, PassBox.Text))
                {
                    c.disconnect();
                    UserCorrente uc = new UserCorrente(Accountbox.Text);
                    uc.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Conta não encontrada");
                }
            }
            else
            {
                MessageBox.Show("Conta não encontrada");
            }

        }
    }
}
