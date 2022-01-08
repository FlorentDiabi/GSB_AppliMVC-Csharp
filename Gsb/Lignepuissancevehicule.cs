using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
