using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
