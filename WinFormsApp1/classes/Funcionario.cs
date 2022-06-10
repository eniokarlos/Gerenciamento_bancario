
namespace WinFormsApp1
{
    public class Funcionario
    {
        private String nome;
        private String senha;
        private String id;
        private String cpf;
        private Double saldo = 0;
        private Double emprestimo = 0;
        private Double TaxaEmprestimo = 0;

        public Funcionario(String id, String nome, String senha, String cpf)
        {
            this.nome = nome;
            this.senha = senha;
            this.id = id;
            this.cpf = cpf;
        }
       
        public String Nome { get { return nome; } set { nome = value; } }
        public String Senha { get { return senha; } set { senha = value; } }
        public String Id { get { return id; } set { id = value; } }
        public String Cpf { get { return cpf; } set { cpf = value; } }
        public Double Saldo { get { return saldo; } set { saldo = value; } }
        public Double Emprestimo { get { return emprestimo; } set { emprestimo = value; } }
        public Double EmprestimoTaxa { get { return EmprestimoTaxa; } set { EmprestimoTaxa = value; } }
    }
    public interface IEmprestimo
    {
        public void ObterEmprestimo(Double valor, Double taxa);
        public void PagarEmprestimo();
    }
}
