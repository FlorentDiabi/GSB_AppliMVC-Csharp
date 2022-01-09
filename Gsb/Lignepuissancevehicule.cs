using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Lignepuissancevehicule
    {
        public string Idvisiteur { get; set; }
        public string Mois { get; set; }
        public int Idpuissancevehicule { get; set; }

        public virtual Fichefrais Fichefrais { get; set; }
        public virtual Puissancevehicule IdpuissancevehiculeNavigation { get; set; }
    }
}
