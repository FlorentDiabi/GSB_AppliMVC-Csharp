using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC.Tables
{
    class LigneFraisHorsForfait
    {
        private int id;
        private string idVisiteur;
        private string mois;
        private string libelle;
        private DateTime date;
        private decimal montant;

        public LigneFraisHorsForfait(int id, string idVisiteur, string mois, string libelle, DateTime date, decimal montant)
        {
            this.id = id;
            this.idVisiteur = idVisiteur;
            this.mois = mois;
            this.libelle = libelle;
            this.date = date;
            this.montant = montant;
        }

        public int Id { get => id; set => id = value; }
        public string IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public string Mois { get => mois; set => mois = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Montant { get => montant; set => montant = value; }
    }
}
