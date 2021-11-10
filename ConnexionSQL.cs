using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        //public  List<string> SelectionnerTout(string tableName)
        //{
        //    string sql = "select * from  @tableName";
        //    List<string> resultat = new List<string>();

        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand(sql, this.connexion);
        //        cmd.Parameters.AddWithValue("@tableName", tableName);
        //        MySqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            resultat
        //        }
        //    }
        //} 

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
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
