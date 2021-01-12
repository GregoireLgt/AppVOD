using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AppVOD.IHM.VOD
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
        private static RoutedUICommand ajouterFilm;
        private static RoutedUICommand supprimerFilm;
        private static RoutedUICommand ajouterSouscription;
        private static RoutedUICommand supprimerSouscription;


        static CommandesVOD()
        {
            quitter = new RoutedUICommand("Quitter", "Quitter", typeof(CommandesVOD));
            ajouterElement = new RoutedUICommand("Ajouter élément", "AjouterElement", typeof(CommandesVOD));
            ajouterFilm = new RoutedUICommand("Ajouter film", "AjouterFilm", typeof(CommandesVOD));
            supprimerFilm = new RoutedUICommand("Supprimer film", "SupprimerFilm", typeof(CommandesVOD));
            ajouterSouscription = new RoutedUICommand("Ajouter souscription", "AjouterSouscription", typeof(CommandesVOD));
            supprimerSouscription = new RoutedUICommand("Supprimer souscription", "SupprimerSouscription", typeof(CommandesVOD));

        }

        public static RoutedUICommand Quitter
        {
            get { return quitter; }
        }

        public static RoutedUICommand AjouterElement
        {
            get { return ajouterElement; }
        }

        public static RoutedUICommand AjouterFilm
        {
            get { return ajouterFilm; }
        }
        public static RoutedUICommand SupprimerFilm
        {
            get { return supprimerFilm; }
        }

        public static RoutedUICommand AjouterSouscription
        {
            get { return ajouterSouscription; }
        }
        public static RoutedUICommand SupprimerSouscription
        {
            get { return supprimerSouscription; }
        }
    }
}
