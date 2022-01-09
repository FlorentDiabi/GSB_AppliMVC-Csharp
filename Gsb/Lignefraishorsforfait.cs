using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class Lignefraishorsforfait
    {
        public int Id { get; set; }
        public string Idvisiteur { get; set; }
        public string Mois { get; set; }
        public string Libelle { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Montant { get; set; }
    }
}
