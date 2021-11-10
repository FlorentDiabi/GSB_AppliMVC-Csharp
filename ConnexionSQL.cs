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


        public Account SelectUnAccount(string iD)
        {
            string sql = "select * from account where id = @id";

            string id = "";
            string nom = "";
            string prenom = "";
            string login = "";
            string mdp = "";
            string adresse = "";
            string cp = "";
            string ville = "";
            string email = "";
            string code = "";
            int accountType = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
                cmd.Parameters.AddWithValue("@id", iD);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = (String)reader["id"];
                    nom = (String)reader["nom"];
                    prenom = (String)reader["prenom"];
                    login = (String)reader["login"];
                    mdp = (String)reader["mdp"];
                    adresse = (String)reader["adresse"];
                    cp = (String)reader["cp"];
                    ville = (String)reader["ville"];
                    email = (String)reader["email"];
                    code = (String)(reader["code"]);
                    accountType = Convert.ToInt32(reader["accountType"]);
                }
                Account unAccount = new Account(id, nom, prenom, login, mdp, adresse, cp, ville, email, code, accountType);
                reader.Close();
                return unAccount;
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public List<object> SelectionnerTout(string tableName)
        {
            string sql = "select * from  @tableName";

            try
            {
                List<object> objetsSelectionnes = new List<object>();
                MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
                cmd.Parameters.AddWithValue("@tableName", "account");
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                int index = 0;
                while (reader.Read())
                {
                    List<string> param = new List<string>();
                    param.Add((String)reader[index]);
                    objetsSelectionnes.Add(GetInstance(tableName, param));
                    index++;
                }
                return objetsSelectionnes;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private object GetInstance(string str, List<string> param)
        {
            Type t = Type.GetType(str);
            return Activator.CreateInstance(t, param);
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
