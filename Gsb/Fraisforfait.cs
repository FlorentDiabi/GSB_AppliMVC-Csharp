using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Fraisforfait
    {
        public Fraisforfait()
        {
            Lignefraisforfait = new HashSet<Lignefraisforfait>();
        }

        public string Id { get; set; }
        public string Libelle { get; set; }
        public decimal? Montant { get; set; }

        public virtual ICollection<Lignefraisforfait> Lignefraisforfait { get; set; }
    }
}
