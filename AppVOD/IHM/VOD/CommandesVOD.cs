using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AppVOD.IHM.Filmo
{
    /// <summary>
    ///
    /// Commandes actionnables sur la VOD (à utiliser dans la FenetreVOD.xaml en les assignant à des éléments de l'interface)
    /// 
    /// </summary>
    public class CommandesVOD
    {
        private static RoutedUICommand quitter;
        private static RoutedUICommand ajouterElement;
        private static RoutedUICommand ajouterRole;
        private static RoutedUICommand supprimerRole;

        static CommandesVOD()
        {
            quitter = new RoutedUICommand("Quitter", "Quitter", typeof(CommandesVOD));
            ajouterElement = new RoutedUICommand("Ajouter élément", "AjouterElement", typeof(CommandesVOD));
            ajouterRole = new RoutedUICommand("Ajouter rôle", "AjouterRole", typeof(CommandesVOD));
            supprimerRole = new RoutedUICommand("Supprimer rôle", "SupprimerRole", typeof(CommandesVOD));
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
