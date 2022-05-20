import java.util.Calendar;
public class Contapoupanca extends Conta{
    private Calendar data;
    private static final double TAXA = 0.2;

    public Contapoupanca (String nConta, String nomeTitular, String cpfTitular){
        super(nConta, nomeTitular, cpfTitular);
        this.data = Calendar.getInstance();
    }

    public double sacar(double valorSaque) {
        if(valorSaque < getSaldo()){
            System.out.println("Saldo indisponível");
            return getSaldo();
        }
        setSaldo(getSaldo() - valorSaque);
        return getSaldo();
    }

    public double depositar(double valorDeposito){
        setSaldo(getSaldo() + valorDeposito);
        return getSaldo();
    }

}
