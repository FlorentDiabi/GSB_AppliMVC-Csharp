using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Puissancevehicule
    {
        public Puissancevehicule()
        {
            Lignepuissancevehicule = new HashSet<Lignepuissancevehicule>();
        }

        public int Id { get; set; }
        public string Puissance { get; set; }
        public string Typevehicule { get; set; }
        public decimal Prixkm { get; set; }

        public virtual ICollection<Lignepuissancevehicule> Lignepuissancevehicule { get; set; }
    }
}
