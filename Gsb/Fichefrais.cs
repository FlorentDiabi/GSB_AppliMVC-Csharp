using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
