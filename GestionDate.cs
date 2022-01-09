using System;
using System.Collections.Generic;
using System.Text;

namespace GSB_AppliMVC_Csharp
{
    public abstract class GestionDate
    {
        public static string GetMoisPrecedent()
        {
            return GetMoisPrecedent(DateTime.Now);
        }

        public static string GetMoisPrecedent(DateTime date)
        {
            int month = (date.Month == 1) ? 12 : date.Month - 1;
            return (Convert.ToString(month).Length == 1) ? "0" + Convert.ToString(month) : Convert.ToString(month);
        }

        public static string GetMoisSuivant()
        {
            return GetMoisSuivant(DateTime.Now);
        }

        public static string GetMoisSuivant(DateTime date)
        {
            int month = (date.Month == 12) ? 1 : date.Month + 1;
            return (Convert.ToString(month).Length == 1) ? "0" + Convert.ToString(month) : Convert.ToString(month);
        }

        public static bool Entre(int jourDebut, int jourFin)
        {
            return Entre(jourDebut, jourFin, DateTime.Now);
        }

        public static bool Entre(int jourDebut, int jourFin, DateTime date)
        {
            return date.Day >= jourDebut && date.Day <= jourFin;
        }

    }
}
