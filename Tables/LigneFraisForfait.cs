using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC.Tables
{
    class LigneFraisForfait
    {
        private string idVisiteur;
        private string mois;
        private string idFraisForfait;
        private int quantite;

        public LigneFraisForfait(string idVisiteur, string mois, string idFraisForfait, int quantite)
        {
            this.idVisiteur = idVisiteur;
            this.mois = mois;
            this.idFraisForfait = idFraisForfait;
            this.quantite = quantite;
        }

        public string IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public string Mois { get => mois; set => mois = value; }
        public string IdFraisForfait { get => idFraisForfait; set => idFraisForfait = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
