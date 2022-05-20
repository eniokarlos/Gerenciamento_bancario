public class contaCorrente extends Conta{
    
    private boolean chequeEspecial;
    private static final double LIMITE = 2000;
    private double limiteDisponivel = 2000;

    public contaCorrente(String nConta, String nomeTitular, String cpfTitular, boolean chequeEspecial){
        super(nConta, nomeTitular, cpfTitular);
        this.chequeEspecial = chequeEspecial;
    }

    public double depositar(double valorDeposito){
        if(limiteDisponivel < LIMITE){
            double limiteUsado = LIMITE - limiteDisponivel;
            if(valorDeposito >= limiteUsado){
                setSaldo(valorDeposito - limiteUsado);
                limiteDisponivel = limiteDisponivel + valorDeposito - getSaldo();
                System.out.print("Saldo disponível: R$ ");
                return getSaldo();
            }
            else{
                System.out.println();
                limiteDisponivel = limiteDisponivel + valorDeposito;
                limiteUsado = LIMITE - limiteDisponivel;
                valorDeposito = 0;
                System.out.println("Voce ainda tem dividas do cheque especial. O valor depositado será descontado");
                System.out.println("Limite especial disponivel: R$"+limiteDisponivel);
                System.out.println("Limite especial usado: R$"+limiteUsado);
                System.out.print("Saldo disponível: R$ ");
                return getSaldo();
            }
        }
        setSaldo(getSaldo() + valorDeposito);
        System.out.print("Saldo disponível: R$ ");
        return getSaldo();
    }

    public double sacar(double valorSaque){
        if(chequeEspecial && getSaldo() <= valorSaque){
            if(limiteDisponivel >= valorSaque){
                limiteDisponivel = limiteDisponivel - (valorSaque - getSaldo());
                setSaldo(0);
                System.out.println("Fundos insuficientes. Usando cheque especial!");
                System.out.println("Limite especial usado: R$ " + (LIMITE - limiteDisponivel));
                System.out.println("Limite especial disponível: R$ " + limiteDisponivel);
                System.out.print("Saldo disponível: R$ ");
                return getSaldo();
                
            }
            else{
                System.out.println("Limite Indisponivel");
            }
        }
        setSaldo(getSaldo() - valorSaque);
        System.out.print("Saldo disponível: R$ ");
        return getSaldo();
    }
}
