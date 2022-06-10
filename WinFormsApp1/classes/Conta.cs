using System;

namespace WinFormsApp1
{
    public abstract class Conta 
    {
        private String nConta;
        private String senha;
        private String nomeTitular;
        private String cpfTitular;
        private Double saldo = 0;
        private Double emprestimoTaxa = 0;
        private Double emprestimo = 0;

        public Conta(String nConta, String senha, String nomeTitular, String cpfTitular)
        {
            this.nConta = nConta;
            this.nomeTitular = nomeTitular;
            this.cpfTitular = cpfTitular;
            this.senha = senha;
        }

        public abstract Double depositar(double valorDeposito);

        public abstract Double sacar(double valorSaque);

        public String Nconta { get { return nConta; } set { nConta = value; } }
        public String NomeTitular { get { return nomeTitular; } set { nomeTitular = value; } }
        public String CpfTitular { get { return cpfTitular; } set { cpfTitular = value; } }
        public Double Saldo { get { return saldo; } set { saldo = value; } }
        public String Senha { get { return senha; } set { senha = value; } }
        public Double Emprestimo { get { return emprestimo; } set { emprestimo = value; } }
        public Double EmprestimoTaxa { get { return emprestimoTaxa; } set { emprestimoTaxa = value; } }
    }
}
