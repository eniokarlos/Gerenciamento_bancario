namespace WinFormsApp1
{
    public partial class janela : Form
    {
        public janela()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUpWindow janela2 = new signUpWindow();
            janela2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signInWindow janela3 = new signInWindow();
            janela3.ShowDialog();
        }
    }
}