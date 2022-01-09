using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Lignefraisforfait
    {
        public string Idvisiteur { get; set; }
        public string Mois { get; set; }
        public string Idfraisforfait { get; set; }
        public int? Quantite { get; set; }

        public virtual Fichefrais Fichefrais { get; set; }
        public virtual Fraisforfait IdfraisforfaitNavigation { get; set; }
    }
}
