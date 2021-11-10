using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC.Tables
{
    class LignePuissanceVehicule
    {
        private string idVisiteur;
        private string mois;
        private int idPuissanceVehicule;

        public LignePuissanceVehicule(string idVisiteur, string mois, int idPuissanceVehicule)
        {
            this.idVisiteur = idVisiteur;
            this.mois = mois;
            this.idPuissanceVehicule = idPuissanceVehicule;
        }

        public string IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public string Mois { get => mois; set => mois = value; }
        public int IdPuissanceVehicule { get => idPuissanceVehicule; set => idPuissanceVehicule = value; }
    }
}
