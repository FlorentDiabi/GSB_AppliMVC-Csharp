namespace GSB_AppliMVC_Csharp
{
    using System;

    /// <summary>
    /// Classe de Gestion de date.
    /// </summary>
    public abstract class GestionDate
    {
        /// <summary>
        /// Retourne le mois précédent par rapport à la date actuelle.
        /// </summary>
        /// <returns>Mois précédent.</returns>
        public static string GetMoisPrecedent()
        {
            return GetMoisPrecedent(DateTime.Now);
        }

        /// <summary>
        /// Retourne le mois précédent par rapport à une date fournit.
        /// </summary>
        /// <param name="date">Date.</param>
        /// <returns>Mois précédent.</returns>
        public static string GetMoisPrecedent(DateTime date)
        {
            int month = (date.Month == 1) ? 12 : date.Month - 1;
            return (Convert.ToString(month).Length == 1) ? "0" + Convert.ToString(month) : Convert.ToString(month);
        }

        /// <summary>
        /// Retourne le mois suivant par rapport à la date actuelle.
        /// </summary>
        /// <returns>Mois suivant.</returns>
        public static string GetMoisSuivant()
        {
            return GetMoisSuivant(DateTime.Now);
        }

        /// <summary>
        /// Retourne le mois suivant par rapport à une date fournit.
        /// </summary>
        /// <param name="date">Date.</param>
        /// <returns>Mois suivant.</returns>
        public static string GetMoisSuivant(DateTime date)
        {
            int month = (date.Month == 12) ? 1 : date.Month + 1;
            return (Convert.ToString(month).Length == 1) ? "0" + Convert.ToString(month) : Convert.ToString(month);
        }

        /// <summary>
        /// Retourne vrai si le jour de la date actuelle se situe entre 2 jours.
        /// </summary>
        /// <param name="jourDebut">Jour de début.</param>
        /// <param name="jourFin">Jour de fin.</param>
        /// <returns>Vrai ou faux.</returns>
        public static bool Entre(int jourDebut, int jourFin)
        {
            return Entre(jourDebut, jourFin, DateTime.Now);
        }

        /// <summary>
        /// Retourne vrai si le jour de la date fournit se situe entre 2 jours.
        /// </summary>
        /// <param name="jourDebut">Jour de début.</param>
        /// <param name="jourFin">Jour de fin.</param>
        /// <param name="date">Date à comparer.</param>
        /// <returns>Vrai ou faux.</returns>
        public static bool Entre(int jourDebut, int jourFin, DateTime date)
        {
            return date.Day >= jourDebut && date.Day <= jourFin;
        }
    }
}
