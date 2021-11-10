using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_AppliMVC.Tables
{
    class PuissanceVehicule
    {
        private int id;
        private string puissance;
        private string typeVehicule;
        private decimal prixKm;

        public PuissanceVehicule(int id, string puissance, string typeVehicule, decimal prixKm)
        {
            this.id = id;
            this.puissance = puissance;
            this.typeVehicule = typeVehicule;
            this.prixKm = prixKm;
        }

        public int Id { get => id; set => id = value; }
        public string Puissance { get => puissance; set => puissance = value; }
        public string TypeVehicule { get => typeVehicule; set => typeVehicule = value; }
        public decimal PrixKm { get => prixKm; set => prixKm = value; }
    }
}
