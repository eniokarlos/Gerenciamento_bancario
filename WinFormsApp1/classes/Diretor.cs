
namespace WinFormsApp1
{
    public class Diretor : Funcionario
    {
        public Diretor(String id_diretor, String nome, String senha, String cpf)
            : base(id_diretor, nome, senha, cpf)
        {}

        public void concederEmprestimo(Funcionario f, Double valor)
        {
            f.Saldo += valor;
            f.Emprestimo = valor;
        }
        public void descontar(Funcionario f)
        {
            f.Saldo -= f.Emprestimo * 0.01;
        }
    }
}
