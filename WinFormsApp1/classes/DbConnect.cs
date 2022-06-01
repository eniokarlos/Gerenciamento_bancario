using System;
using Npgsql;

namespace WinFormsApp1
{
    internal class DbConnect
    {
        private NpgsqlConnection conn;
        private String sql;
        private NpgsqlCommand cmd;

        private String connectionPath = @"Server=localhost;Port=5432;User Id=postgres;Password=tardis;DataBase=postgres";

        public void connect()
        {
            try
            {
                conn = new NpgsqlConnection(connectionPath);
                conn.Open();
            }
            catch (NpgsqlException e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
            }
        }
        public void disconnect()
        {
            conn.Close();
        }
        public void insertCorrente(String numconta, String senha, String nome, String cpf, int saldo, double limite)
        {
            sql = String.Format("insert into conta_corrente values('{0}','{1}','{2}','{3}',{4},{5});", numconta, senha, nome, cpf, saldo, limite);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void insertPoupanca(String numconta, String senha, String nome, String cpf, double saldo)
        {
            sql = String.Format("insert into conta_poupanca values('{0}','{1}','{2}','{3}',{4});", numconta, senha, nome, cpf, saldo);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void setSaldoPoupanca(String conta, String saldo)
        {
            sql = String.Format("UPDATE conta_poupanca SET saldo = {0} WHERE numconta = '{1}';", saldo,conta);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void setSaldoCorrente(String conta, String saldo, String limite)
        {
            sql = String.Format("UPDATE conta_corrente SET saldo = {0}, limite = {2} WHERE numconta = '{1}';", saldo, conta, limite);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void depositoExtrato(String conta, String valor)
        {
            sql = String.Format("INSERT INTO extrato values('{0}','deposito',{1});", conta, valor);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void SaqueExtrato(String conta, String valor)
        {
            sql = String.Format("INSERT INTO extrato values('{0}','saque',{1});", conta, valor);
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public String getExtrato(String conta)
        {
            sql = String.Format("select tipo,valor from extrato where numconta  = '{0}';", conta);
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            String extrato = "";
            while (reader.Read())
            {
                extrato += reader[0].ToString()+": R$" + String.Format("{0:N}", reader[1].ToString())+"\n";
            }
            reader.Close();
            return extrato;
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
                    return true;
                }
            }
            reader.Close();
            return false;
        }
        public bool VerificarC(String conta, String senha)
        {
            sql = "select * from conta_corrente where numconta ='" + conta + "';";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == conta && reader[1].ToString() == senha)
                {
                    return true;
                }
            }
            reader.Close();
            return false;
        }
        public String[] getFromPoupanca(String conta)
        {
            sql = "select * from conta_poupanca where numconta ='" + conta + "';";
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
            conn.Close();
            return data.Split(";");
        }
        public String[] getFromCorrente(String conta)
        {
            sql = "select * from conta_corrente where numconta ='" + conta + "';";
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
    }
}
