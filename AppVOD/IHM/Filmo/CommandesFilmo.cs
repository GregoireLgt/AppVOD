using System.Windows.Input;

namespace AppVOD.IHM.Filmo
{
    /// <summary>
    /// Commandes de la filmographie
    /// </summary>
    public class CommandesFilmo
    {
        private static RoutedUICommand quitter;
        private static RoutedUICommand ajouterElement;
        private static RoutedUICommand ajouterRole;
        private static RoutedUICommand supprimerRole;

        static CommandesFilmo()
        {
            quitter = new RoutedUICommand("Quitter", "Quitter", typeof(CommandesFilmo));
            ajouterElement = new RoutedUICommand("Ajouter élément", "AjouterElement", typeof(CommandesFilmo));
            ajouterRole = new RoutedUICommand("Ajouter rôle", "AjouterRole", typeof(CommandesFilmo));
            supprimerRole = new RoutedUICommand("Supprimer rôle", "SupprimerRole", typeof(CommandesFilmo));
        }

        /// <summary>
        /// Commande quitter
        /// </summary>
        public static RoutedUICommand Quitter
        {
            get { return quitter; }
        }

        /// <summary>
        /// Commande AjouterElement
        /// </summary>
        public static RoutedUICommand AjouterElement
        {
            get { return ajouterElement; }
        }

        /// <summary>
        /// Commande AjouterRole
        /// </summary>
        public static RoutedUICommand AjouterRole
        {
            get { return ajouterRole; }
        }

        /// <summary>
        /// Commande SupprimerRole
        /// </summary>
        public static RoutedUICommand SupprimerRole
        {
            get { return supprimerRole; }
        }
    }
}
