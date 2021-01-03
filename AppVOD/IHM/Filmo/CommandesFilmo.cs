using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AppVOD.IHM.Filmo
{
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

        public static RoutedUICommand Quitter
        {
            get { return quitter; }
        }

        public static RoutedUICommand AjouterElement
        {
            get { return ajouterElement; }
        }

        public static RoutedUICommand AjouterRole
        {
            get { return ajouterRole; }
        }

        public static RoutedUICommand SupprimerRole
        {
            get { return supprimerRole; }
        }
    }
}
