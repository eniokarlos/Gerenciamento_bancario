
namespace WinFormsApp1
{
    public partial class Visualizar : Form
    {
        private int flag;
        private String agencia, cpf;
        private DbConnect c = new DbConnect();
        public Visualizar(int flag)
        {
            c.connect();
            InitializeComponent();
            this.flag = flag;
        }

        public Visualizar(int flag, String agencia, String cpf)
        {
            c.connect();
            InitializeComponent();
            this.flag = flag;
            this.agencia = agencia;
            this.cpf = cpf;
        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                dgv.DataSource = null;
                dgv.DataSource = c.showTable("funcionario");
            }
            else if(flag == 2)
            {
                dgv.DataSource = null;
                dgv.DataSource = c.showTableClients();
            }
            else if(flag == 3)
            {
                dgv.DataSource = null;
                dgv.DataSource = c.showTableClients(agencia, cpf);
            }
            
        }
    }
}
