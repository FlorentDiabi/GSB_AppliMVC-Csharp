using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Fichefrais
    {
        public Fichefrais()
        {
            Lignefraisforfait = new HashSet<Lignefraisforfait>();
        }

        public string Idvisiteur { get; set; }
        public string Mois { get; set; }
        public int? Nbjustificatifs { get; set; }
        public decimal? Montantvalide { get; set; }
        public DateTime? Datemodif { get; set; }
        public string Idetat { get; set; }

        public virtual Etat IdetatNavigation { get; set; }
        public virtual Account IdvisiteurNavigation { get; set; }
        public virtual Lignepuissancevehicule Lignepuissancevehicule { get; set; }
        public virtual ICollection<Lignefraisforfait> Lignefraisforfait { get; set; }
    }
}
