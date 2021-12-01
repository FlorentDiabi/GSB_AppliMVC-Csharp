using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC.Tables
{
    class Account
    {
        private string id;
        private string nom;
        private string prenom;
        private string login;
        private string mdp;
        private string adresse;
        private string cp;
        private string ville;
        private DateTime dateEmbauche;
        private string email;
        private string code;
        private int accountType;

        public Account(string id, string nom, string prenom, string login, string mdp, string adresse, string cp, string ville, string email, string code, int accountType)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.mdp = mdp;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.email = email;
            this.code = code;
            this.accountType = accountType;
        }


        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public string Email { get => email; set => email = value; }
        public string Code { get => code; set => code = value; }
        public int AccountType { get => accountType; set => accountType = value; }

    }
}
