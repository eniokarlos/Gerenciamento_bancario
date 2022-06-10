
namespace WinFormsApp1
{
    public class Gerente : Funcionario
    {
        private String agencia;
        public Gerente(String id_gerente, String nome, String senha, String agencia,String cpf)
            : base(id_gerente, nome, senha, cpf)
        {
            this.agencia = agencia;
        }

        public void concederEmprestimo(Conta c, Double valor)
        { 
            c.Saldo += valor;
            c.Emprestimo = valor;         
        }
        public String Agencia { get { return agencia; } set { agencia = value; } }
    }
}
