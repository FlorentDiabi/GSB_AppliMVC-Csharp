using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnexionSQL connexionSQL = new ConnexionSQL();
            connexionSQL.Ouvrir();
            Console.WriteLine(connexionSQL.SelectAllAccounts());
            Dictionary<string, string> parametres = new Dictionary<string, string>();
            parametres.Add("puissance", "9CV");
            parametres.Add("typevehicule", "Essence");
            parametres.Add("prixkm", "0.3");

            connexionSQL.Insert("puissancevehicule", parametres);
            connexionSQL.Fermer();
            Console.ReadKey();
        }
    }
}
