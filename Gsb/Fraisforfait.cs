using System;
using System.Collections.Generic;

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
