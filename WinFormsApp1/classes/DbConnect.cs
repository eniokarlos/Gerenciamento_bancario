using Npgsql;
using System.Data;
namespace WinFormsApp1
{
    public class DbConnect
    { 
        private NpgsqlConnection conn;
        private String sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        private String connectionPath = @"Server=localhost;Port=5432;User Id=postgres;Password=tardis;DataBase=postgres";

        public bool connect()
        {
            try
            {
                conn = new NpgsqlConnection(connectionPath);
                conn.Open();
                return true;
            }
            catch (NpgsqlException e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public void disconnect()
        {
            conn.Close();
        }


        public bool isClient(String tabela, String conta)
        {
            sql = String.Format("select * from {0} where numconta = '{1}'",tabela, conta);
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == conta)
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }

        public DataTable showTable(String nome)
        {
            sql = String.Format("Select * from {0};", nome);
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public DataTable showTableClients()
        {
            sql = "select c.cpf,c.nome,c.numconta, c.saldo, c.agencia,c.emprestimo, f.nome as gerente from conta_poupanca as c join funcionario as f " +
            "on c.agencia = f.agencia " +
            "where f.cargo = 'gerente' " +
            "union select c.cpf, c.nome, c.numconta, c.saldo, c.agencia,c.emprestimo, f.nome as gerente from conta_corrente as c " +
            "join funcionario as f on c.agencia = f.agencia where f.cargo = 'gerente';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        public DataTable showTableClients(String agencia, String cpf)
        {
            sql = String.Format("select numconta,senha,nome,cpf from conta_corrente where agencia = '{0}' and cpf <> '{1}' union " +
            "select numconta,senha,nome,cpf from conta_poupanca where agencia = '{0}' and cpf <> '{1}'", agencia, cpf);
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }

        //Tabela Conta Corrente
        public void insertCorrente(String senha, String nome, String cpf, int saldo, double limite, String agencia)
        {
            sql = String.Format("insert into conta_corrente (senha,nome,cpf,saldo,limite,agencia) values('{0}','{1}','{2}',{3},{4},'{5}');",senha, nome, cpf, saldo, limite, agencia);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void setSaldoCorrente(String conta, String saldo, String limite)
        {
            sql = String.Format("UPDATE conta_corrente SET saldo = {0}, limite = {2} WHERE numconta = {1};", saldo, conta, limite);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public bool VerificarC(String conta, String senha)
        {
            sql = "select * from conta_corrente where numconta =" + conta + ";";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == conta && reader[1].ToString() == senha)
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }
        public String[] getFromCorrente(String conta)
        {
            sql = "select * from conta_corrente where numconta =" + conta + ";";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            String data = "";
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data += reader[i].ToString() + ";";
                }
            }
            reader.Close();
            return data.Split(";");
        }

        //-----------------------


        // Tabela Conta Poupança 
        public void insertPoupanca(String senha, String nome, String cpf, double saldo, String agencia)
        {
            sql = String.Format("insert into conta_poupanca (senha,nome,cpf,saldo,agencia) values('{0}','{1}','{2}',{3},'{4}');",senha, nome, cpf, saldo,agencia);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void setSaldoPoupanca(String conta, String saldo)
        {
            sql = String.Format("UPDATE conta_poupanca SET saldo = {0} WHERE numconta = {1};", saldo,conta);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public bool VerificarP(String conta, String senha)
        {
            sql = "select * from conta_poupanca where numconta ='" + conta + "';";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == conta && reader[1].ToString() == senha)
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }
        public String[] getFromPoupanca(String conta)
        {
            sql = "select * from conta_poupanca where numconta =" + conta + ";";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            String data = "";
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data += reader[i].ToString() + ";";
                }
            }
            reader.Close();
            return data.Split(";");
        }

        //-----------------------


        // Tabela Funcionario
        public void insertFuncionario(String nome, String senha, String cargo, String agencia, String cpf)
        {
            sql = String.Format("insert into funcionario (nome,senha,cpf,cargo,agencia) values('{0}','{1}','{2}','{3}','{4}');",nome, senha, cpf, cargo, agencia);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public String VerificarF(String conta, String senha)
        {
            sql = "select * from funcionario where id_funcionario =" + conta + ";";
            cmd = new NpgsqlCommand(sql, conn);
            String data = "";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == conta && reader[2].ToString() == senha)
                {
                    data = reader[4].ToString();
                }
            }
            reader.Close();
            return data;
        }

        public bool VerificarF(String agencia)
        {
            sql = String.Format("select * from funcionario where agencia = '{0}'",agencia);
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[4].ToString() == "gerente")
                {
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }

        public String isFuncionario(String cpf)
        {
            sql = "select * from funcionario";
            cmd = new NpgsqlCommand(sql, conn);
            String data = "";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[3].ToString() == cpf)
                {
                    data = reader[4].ToString();
                }
            }
            reader.Close();
            return data;
        }

        public String[] getFromFuncionario(String conta)
        {
            sql = "select * from funcionario where id_funcionario=" + conta + ";";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            String data = "";
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data += reader[i].ToString() + ";";
                }
            }
            reader.Close();
            return data.Split(";");
        }

        //-----------------------


        // Operaçoes Emprestimo
        public void setEmprestimo(String tabela, String conta, String agencia,String valor, String taxa)
        {
            sql = String.Format("update {0} set emprestimo = {1} , taxa = {4} where numconta = {2} and agencia = '{3}'", tabela,valor,conta,agencia,taxa);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void setEmprestimo(String tabela, String conta, String valor, String taxa)
        {
            sql = String.Format("update {0} set emprestimo = {1} , taxa = {3} where numconta = {2}", tabela, valor, conta, taxa);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        //-----------------------


        // Tabela de extrato 
        public void depositoExtrato(String conta, String valor)
        {
            sql = String.Format("INSERT INTO extrato values({0},'deposito',{1});", conta, valor);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void SaqueExtrato(String conta, String valor)
        {
            sql = String.Format("INSERT INTO extrato values({0},'saque',{1});", conta, valor);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public String getExtrato(String conta)
        {
            sql = String.Format("select tipo,valor from extrato where numconta  = {0};", conta);
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            String extrato = "";
            while (reader.Read())
            {
                extrato += reader[0].ToString() + ": R$" + String.Format("{0:N}", reader[1].ToString()) + "\n";
            }
            reader.Close();
            return extrato;
        }

        //-----------------------
    }
}
