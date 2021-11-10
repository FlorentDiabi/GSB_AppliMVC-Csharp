using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC.Tables
{
    class FraisForfait
    {
        private string id;
        private string libelle;
        private decimal montant;

        public FraisForfait(string id, string libelle, decimal montant)
        {
            this.id = id;
            this.libelle = libelle;
            this.montant = montant;
        }

        public string Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public decimal Montant { get => montant; set => montant = value; }
    }
}
