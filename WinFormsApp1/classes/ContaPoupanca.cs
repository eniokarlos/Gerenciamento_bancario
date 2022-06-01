using System;

namespace WinFormsApp1
{
    public class ContaPoupanca : Conta
    {
        private static Double TAXA = 0.0001;
        public ContaPoupanca(String nConta, String senha, String nomeTitular, String cpfTitular, Double saldo)
            : base(nConta, senha, nomeTitular, cpfTitular)
        {
            this.Saldo = saldo;
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

        public Double calcularJuros()
        {
            Saldo = Saldo + (Saldo * (30 * TAXA));
            return Saldo;
        }
    }
}
