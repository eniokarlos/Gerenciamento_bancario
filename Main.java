public class Main {
    public static void main(String args[]){
        contaCorrente c1 = new contaCorrente("2135", "enio", "336457668", true);
        Contapoupanca c2 = new Contapoupanca("2456", "carlos", "234565");
        
        c2.depositar(5000);
        c2.getSaldo();
    }
}
