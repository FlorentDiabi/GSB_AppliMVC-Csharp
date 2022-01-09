using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Account
    {
        public Account()
        {
            Fichefrais = new HashSet<Fichefrais>();
        }

        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }
        public string Adresse { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public DateTime? Dateembauche { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public int AccountType { get; set; }

        public bool EstComptable()
        {
            return this.AccountType == 2;
        }

        public bool EstVisiteur()
        {
            return this.AccountType == 1;
        }

        public virtual ICollection<Fichefrais> Fichefrais { get; set; }
    }
}
