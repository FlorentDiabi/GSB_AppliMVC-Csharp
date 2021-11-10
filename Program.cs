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
            Console.WriteLine(connexionSQL.SelectUnAccount("a131"));
            connexionSQL.Fermer();
            Console.ReadKey();
        }
    }
}
