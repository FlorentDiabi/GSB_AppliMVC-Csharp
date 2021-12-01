using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSB_AppliMVC.Tables;
using MySql.Data.MySqlClient;

namespace GSB_AppliMVC
{
    class ConnexionSQL
    {
        private MySqlConnection connexion;
        private static ConnexionSQL instance;

        public ConnexionSQL()
        {
            string host = ConfigurationManager.AppSettings["SQlSERVER"];
            string port = ConfigurationManager.AppSettings["PORT"];
            string db = ConfigurationManager.AppSettings["database"];
            string login = ConfigurationManager.AppSettings["username"];
            string pwd = ConfigurationManager.AppSettings["mdp"];
            string csMysql = ConfigurationManager.ConnectionStrings["SqlConnexion"].ToString();
            string format = String.Format(csMysql, host, port, db, login, pwd);
            this.connexion = new MySqlConnection(format);
        }

        public static ConnexionSQL getInstance()
        {
            if (ConnexionSQL.instance == null)
            {
                ConnexionSQL.instance = new ConnexionSQL();
            }
            return ConnexionSQL.instance;
        }
        public void Ouvrir()
        {
            try
            {
                this.connexion.Open();
                Console.WriteLine("Vous êtes bien connecté");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Fermer()
        {
            try
            {
                this.connexion.Close();
                ConnexionSQL.instance = null;
                Console.WriteLine("Vous êtes bien déconnecté");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Insert(string tableName, Dictionary<string, string> listeParams)
        {
            string sql = "insert into @tableName (";
            foreach (KeyValuePair<string, string> param in listeParams)
            {
                sql += param.Key;
                sql += ", ";
            }
            sql += ") values (";
            for (int i=0; i < listeParams.Count; i++)
            {
                sql += "?";
                if (i < listeParams.Count - 1)
                {
                    sql += ", ";
                }
            }
            sql += ")";
        }


        public List<Account> SelectAllAccounts()
        {
            string sql = "select * from account";

            try
            {
                List<Account> accounts = new List<Account>();
                MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = (String)reader["id"];
                    string nom = (String)reader["nom"];
                    string prenom = (String)reader["prenom"];
                    string login = (String)reader["login"];
                    string mdp = (String)reader["mdp"];
                    string adresse = (String)reader["adresse"];
                    string cp = (String)reader["cp"];
                    string ville = (String)reader["ville"];
                    string email = (String)reader["email"];
                    string code = (String)(reader["code"]);
                    int accountType = Convert.ToInt32(reader["accountType"]);

                    accounts.Add(new Account(id, nom, prenom, login, mdp, adresse, cp, ville, email, code, accountType));
                }
                
                reader.Close();
                return accounts;
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }






























        //public void SlectionnerAccount(string iD)
        //{
        //    string sql = "select * from account where id=@id";

        //    string id = "";
        //    string nom = "";
        //    string prenom = "";
        //    string login = "";
        //    string mdp = "";
        //    string adresse = "";
        //    string cp = "";
        //    string ville = "";
        //    string email = "";
        //    int code = 0;
        //    int accounttype = 0;

        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
        //        cmd.Parameters.AddWithValue("@id", iD);
        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            id = (String)reader["id"];
        //            nom = (String)reader["nom"];
        //            prenom = (String)reader["prenom"];
        //            login = (String)reader["login"];
        //            mdp = (String)reader["mdp"];
        //            adresse = (String)reader["adresse"];
        //            cp = (String)reader["cp"];
        //            ville = (String)reader["ville"];
        //            email = (String)reader["email"];
        //            code = Convert.ToInt32(reader["code"]);
        //            accounttype = Convert.ToInt32(reader["accounttype"]);
        //        }
        //        reader.Close();
        //    }

        //}

    }
}
