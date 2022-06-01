
namespace WinFormsApp1
{
    public partial class signInWindow : Form
    {
        DbConnect c = new DbConnect();
        public signInWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c.connect();
            if (c.VerificarP(Accountbox.Text, PassBox.Text))
            {
                c.disconnect();
                UserPoupanca up = new UserPoupanca(Accountbox.Text);
                up.ShowDialog();
                Close();
            }
            else if (c.VerificarC(Accountbox.Text, PassBox.Text))
            {
                c.disconnect();
                UserCorrente uc = new UserCorrente(Accountbox.Text);
                uc.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("conta nao encontrada");
            }
        }
    }
}
