using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
