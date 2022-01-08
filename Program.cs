using GSB_AppliMVC_Csharp.Gsb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace GSB_AppliMVC_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new gsb_fraisContext();
            DbSet<Account> accounts = context.Account;
            Console.WriteLine("Affichage des comptes : ");
            foreach (Account account in accounts)
            {
                Console.WriteLine("[" + account.Id + "] " + account.Nom + " " + account.Prenom + ", " + account.EstVisiteur());
            }
            
        }
    }
}
