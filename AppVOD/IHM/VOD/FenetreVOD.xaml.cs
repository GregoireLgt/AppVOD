using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using AppVOD.Modele.Filmo;
using AppVOD.Modele.VOD;
using Microsoft.Win32;

namespace AppVOD.IHM.VOD
{
    public partial class FenetreVOD : Window
    {
        private string fichier;
        private AppVOD.Modele.VOD.VOD vod;
        private Abonne abonne;
        //private Filmographie filmographie;

        public FenetreVOD()
        {
            InitializeComponent();
            vod = new AppVOD.Modele.VOD.VOD();
            abonne = new Abonne();
            DataContext = vod;
        }


        public AppVOD.Modele.VOD.VOD VOD
        {
            get { return vod; }
            set
            {
                vod = value;
                listeAbonnes.ItemsSource = vod.Abonnes;
                listeOffres.ItemsSource = vod.Offres;
            }
        }

        // Création

        private void Nouveau(object sender, RoutedEventArgs e)
        {
            VOD = new AppVOD.Modele.VOD.VOD();
        }

        private void Ouvrir(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dialogue = new OpenFileDialog();
            if (dialogue.ShowDialog() == true)
            {
                fichier = dialogue.FileName;
                VOD = AppVOD.Modele.VOD.VOD.Charger(fichier);
            }
        }

        // Enregsitement

        private void Enregistrer(object sender, ExecutedRoutedEventArgs e)
        {
            if (fichier == null)
                EnregistrerSous(sender, e);
            else
                VOD.Enregistrer(fichier);
        }

        private void EnregistrerSous(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialogue = new SaveFileDialog();
            if (dialogue.ShowDialog() == true)
            {
                fichier = dialogue.FileName;
                VOD.Enregistrer(fichier);
            }
        }

        private void EnregistrerPossible(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (VOD != null);
        }

        private void Quitter(object sender, RoutedEventArgs e)
        {
            Close();
        }


        // Evenements de selection

        private void AfficherAbonne(object sender, SelectionChangedEventArgs e)
        {
            Abonne abonne = (Abonne)listeAbonnes.SelectedItem;
            if (abonne != null) {
                //selecteurMetteursEnScene.SelectedItem = film.MetteurEnScene;
            }
        }

        private void AfficherOffre(object sender, SelectionChangedEventArgs e)
        {
            Offre offre = (Offre)listeOffres.SelectedItem;
            if (offre != null)
            {
                // TODO
            }
        }





        //    private void AfficherAbonne(object sender, SelectionChangedEventArgs e)
        //    {
        //        Abonne abonne = (Abonne)listeAbonnes.SelectedItem;
        //        if (film != null)
        //            selecteurMetteursEnScene.SelectedItem = film.MetteurEnScene;
        //    }

        //    private void DefinirMetteurEnScene(object sender, SelectionChangedEventArgs e)
        //    {
        //        Film film = (Film)listeFilms.SelectedItem;
        //        if (film != null)
        //        {
        //            MetteurEnScene metteurEnScene = (MetteurEnScene)selecteurMetteursEnScene.SelectedItem;
        //            film.MetteurEnScene = metteurEnScene;
        //        }
        //    }

        //    // Gestion des éléments (films, acteurs et metteurs en scène)

        //    private void AjouterElement(object sender, RoutedEventArgs e)
        //    {
        //        switch (onglets.SelectedIndex)
        //        {
        //            case 0:
        //                Film film = new Film();
        //                Filmographie.Films.Add(film);
        //                listeFilms.SelectedItem = film;
        //                break;
        //            case 1:
        //                MetteurEnScene metteurEnScene = new MetteurEnScene();
        //                Filmographie.Artistes.Add(metteurEnScene);
        //                listeMetteursEnScene.SelectedItem = metteurEnScene;
        //                break;
        //            case 2:
        //                Acteur acteur = new Acteur();
        //                Filmographie.Artistes.Add(acteur);
        //                listeActeurs.SelectedItem = acteur;
        //                break;
        //        }
        //    }

        //    private void AjouterElementPossible(object sender, CanExecuteRoutedEventArgs e)
        //    {
        //        e.CanExecute = (Filmographie != null);
        //    }

        //    private void SupprimerElement(object sender, RoutedEventArgs e)
        //    {
        //        switch (onglets.SelectedIndex)
        //        {
        //            case 0:
        //                Film film = (Film)listeFilms.SelectedItem;
        //                Filmographie.Films.Remove(film);
        //                break;
        //            case 1:
        //                MetteurEnScene metteurEnScene = (MetteurEnScene)listeMetteursEnScene.SelectedItem;
        //                Filmographie.Artistes.Remove(metteurEnScene);
        //                break;
        //            case 2:
        //                Acteur acteur = (Acteur)listeActeurs.SelectedItem;
        //                Filmographie.Artistes.Remove(acteur);
        //                break;
        //        }
        //    }

        //    private void SupprimerElementPossible(object sender, CanExecuteRoutedEventArgs e)
        //    {
        //        ListView liste = null;
        //        if (onglets != null)
        //        {
        //            switch (onglets.SelectedIndex)
        //            {
        //                case 0:
        //                    liste = listeFilms;
        //                    break;
        //                case 1:
        //                    liste = listeMetteursEnScene;
        //                    break;
        //                case 2:
        //                    liste = listeActeurs;
        //                    break;
        //            }
        //            e.CanExecute = (filmographie != null) && (liste.SelectedItem != null);
        //        }
        //        else
        //            e.CanExecute = false;
        //    }


        //    // Gestion des roles d'un film

        //    private void AjouterRole(object sender, RoutedEventArgs e)
        //    {
        //        FenetreRole fenetreRole = new FenetreRole();
        //        fenetreRole.selecteurActeur.ItemsSource = filmographie.Acteurs;
        //        bool? ok = fenetreRole.ShowDialog();
        //        if (ok == true)
        //        {
        //            Role role = new Role();
        //            role.Acteur = (Acteur)fenetreRole.selecteurActeur.SelectedItem;
        //            role.Personnage = fenetreRole.personnage.Text;
        //            Film film = (Film)listeFilms.SelectedItem;
        //            film.Roles.Add(role);
        //        }
        //    }

        //    private void AjouterRolePossible(object sender, CanExecuteRoutedEventArgs e)
        //    {
        //        e.CanExecute = (listeFilms.SelectedItem != null);
        //    }

        //    private void SupprimerRole(object sender, RoutedEventArgs e)
        //    {
        //        Role role = (Role)listeRoles.SelectedItem;
        //        Film film = (Film)listeFilms.SelectedItem;
        //        film.Roles.Remove(role);
        //    }

        //    private void SupprimerRolePossible(object sender, CanExecuteRoutedEventArgs e)
        //    {
        //        e.CanExecute = (listeRoles != null) && (listeRoles.SelectedItem != null);
        //    }

        //    private void onglets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //    {

        //    }
        //}
    }
}
