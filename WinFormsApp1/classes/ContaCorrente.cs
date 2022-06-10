using System;

namespace WinFormsApp1
{
    public class ContaCorrente : Conta, IEmprestimo
    {
        private double LIMITE = 2000;
        private double limiteDisponivel;
        private double valorPago = 0;

        public ContaCorrente(String nConta, String senha, String nomeTitular, String cpfTitular, Double saldo, double limiteDisponivel)
        : base(nConta, senha, nomeTitular, cpfTitular)
        {
            this.Saldo = saldo;
            this.limiteDisponivel = limiteDisponivel;
        }


        public override double depositar(double valorDeposito)
        {
            if (limiteDisponivel < LIMITE)
            {
                double limiteUsado = LIMITE - limiteDisponivel;
                if (valorDeposito >= limiteUsado)
                {
                    Saldo = (valorDeposito - limiteUsado);
                    limiteDisponivel = limiteDisponivel + valorDeposito - Saldo;
                    Console.WriteLine("Saldo disponível: R$ ");
                    return Saldo;
                }
                else
                {
                    limiteDisponivel = limiteDisponivel + valorDeposito;
                    limiteUsado = LIMITE - limiteDisponivel;
                    valorDeposito = 0;
                    return Saldo;
                }
            }
            Saldo = Saldo + valorDeposito;
            return Saldo;
        }

        public override double sacar(double valorSaque)
        {
            if (Saldo <= valorSaque)
            {
                if (valorSaque <= (limiteDisponivel + Saldo))
                {
                    limiteDisponivel = limiteDisponivel - (valorSaque - Saldo);
                    Saldo = 0;
                    return Saldo;
                }
                else
                {
                    MessageBox.Show("limite indisponivel");
                    return limiteDisponivel;
                }
            }
            Saldo = Saldo - valorSaque;
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
            if (Saldo > 0 && Emprestimo != 0 && Saldo - (aux) > 0)
            {
                if (valorPago < (Emprestimo + (Emprestimo * EmprestimoTaxa * 10)))
                {
                    Saldo -= aux;
                    valorPago += aux;
                    Emprestimo -= aux;
                }
                else if (valorPago >= Emprestimo)
                {
                    Emprestimo = 0;
                    EmprestimoTaxa = 0;
                    valorPago = 0;
                }
            }
        }
        public Double LimiteDisponivel { get { return limiteDisponivel; } set { limiteDisponivel = value; } }
    }
}
