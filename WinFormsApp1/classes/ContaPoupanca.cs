

namespace WinFormsApp1
{
    public class ContaPoupanca : Conta, IEmprestimo
    {
        private Double taxaMensal;
        private Double valorPago = 0;
        public ContaPoupanca(String nConta, String senha, String nomeTitular, String cpfTitular, Double saldo)
            : base(nConta, senha, nomeTitular, cpfTitular)
        {
            this.Saldo = saldo;
            this.taxaMensal = 0.001;
        }

        public override Double sacar(Double valorSaque)
        {
            if (valorSaque > Saldo)
            {
                MessageBox.Show("Saldo Indisponivel");
                return Saldo;
            }
            Saldo = Saldo - valorSaque;
            return Saldo;
        }

        public override Double depositar(Double valorDeposito)
        {
            Saldo = Saldo + valorDeposito;
            return Saldo;
        }

        public void ObterEmprestimo(Double valor, Double taxa)
        {
            Emprestimo += valor;
            EmprestimoTaxa += taxa;
            Saldo += valor;
        }

        public void PagarEmprestimo()
        {
            double aux = Emprestimo * EmprestimoTaxa;
            if(Saldo > 0 && Emprestimo != 0 && Saldo - aux > 0)
            {
                if(valorPago < (Emprestimo + (Emprestimo * EmprestimoTaxa*10)))
                {
                    Saldo -= aux;
                    valorPago += aux;
                    Emprestimo -= aux;
                }
                else if(valorPago >= Emprestimo)
                {
                    Emprestimo = 0;
                    EmprestimoTaxa = 0;
                    valorPago = 0;
                }
            }
        }

        public void calcularJuros()
        {
            Saldo += (Saldo * taxaMensal);
        }
    }
}
