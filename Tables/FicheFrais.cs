using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC.Tables
{
    class FicheFrais
    {
        private string idVisiteur;
        private string mois;
        private int nbJustificatifs;
        private decimal montantvalide;
        private DateTime datemodif;
        private string idEtat;

        public FicheFrais(string idVisiteur, string mois, int nbJustificatifs, decimal montantvalide, DateTime datemodif, string idEtat)
        {
            this.idVisiteur = idVisiteur;
            this.mois = mois;
            this.nbJustificatifs = nbJustificatifs;
            this.montantvalide = montantvalide;
            this.datemodif = datemodif;
            this.idEtat = idEtat;
        }

        public string IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public string Mois { get => mois; set => mois = value; }
        public int NbJustificatifs { get => nbJustificatifs; set => nbJustificatifs = value; }
        public decimal Montantvalide { get => montantvalide; set => montantvalide = value; }
        public DateTime Datemodif { get => datemodif; set => datemodif = value; }
        public string IdEtat { get => idEtat; set => idEtat = value; }
    }
}
