using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Etat
    {
        public Etat()
        {
            Fichefrais = new HashSet<Fichefrais>();
        }

        public string Id { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<Fichefrais> Fichefrais { get; set; }
    }
}
