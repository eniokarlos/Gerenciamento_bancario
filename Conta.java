public abstract class Conta{
    private String nConta;
    private String nomeTitular;
    private String cpfTitular;
    private double saldo = 0;

    Conta(String nConta, String nomeTitular, String cpfTitular){
        this.nConta = nConta;
        this.nomeTitular = nomeTitular;
        this.cpfTitular = cpfTitular;  
    }

    public abstract double depositar(double valorDeposito);

    public abstract double sacar(double valorSaque);

    public void setnConta(String nConta) {
        this.nConta = nConta;
    }

    public String getnConta() {
        return nConta;
    }

    public void setCpfTitular(String cpfTitular) {
        this.cpfTitular = cpfTitular;
    }

    public String getCpfTitular() {
        return cpfTitular;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setNomeTitular(String nomeTitular) {
        this.nomeTitular = nomeTitular;
    }

    public String getNomeTitular() {
        return nomeTitular;
    }


}