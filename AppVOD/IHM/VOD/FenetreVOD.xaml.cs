using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using AppVOD.IHM.Filmo;
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
        private Filmographie filmographie;

        /// <summary>
        /// Constructeur FenetreVOD
        /// </summary>
        public FenetreVOD()
        {
            InitializeComponent();
            vod = new AppVOD.Modele.VOD.VOD();
            abonne = new Abonne();
            DataContext = this;
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

        // Gestion des éléments (Abonnes et offres)
        private void AjouterElement(object sender, RoutedEventArgs e)
        {
            switch (onglets.SelectedIndex)
            {
                case 0:
                    Abonne abonne = new Abonne();
                    VOD.Abonnes.Add(abonne);
                    listeAbonnes.SelectedItem = abonne;
                    break;
                case 1:
                    Offre offre = new Offre();
                    VOD.Offres.Add(offre);
                    listeOffres.SelectedItem = offre;
                    break;
            }
        }

        private void AjouterElementPossible(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (VOD != null);
        }

        private void SupprimerElement(object sender, RoutedEventArgs e)
        {
            switch (onglets.SelectedIndex)
            {
                case 0:
                    Abonne abonne = (Abonne)listeAbonnes.SelectedItem;
                    VOD.Abonnes.Remove(abonne);
                    break;
                case 1:
                    Offre offre = (Offre)listeOffres.SelectedItem;
                    VOD.Offres.Remove(offre);
                    break;
            }
        }

        private void SupprimerElementPossible(object sender, CanExecuteRoutedEventArgs e)
        {
            ListView liste = null;
            if (onglets != null)
            {
                switch (onglets.SelectedIndex)
                {
                    case 0:
                        liste = listeAbonnes;
                        break;
                    case 1:
                        liste = listeOffres;
                        break;
                }
                e.CanExecute = (vod != null) && (liste.SelectedItem != null);
            }
            else
                e.CanExecute = false;
        }

        private void AjouterSouscription(object sender, RoutedEventArgs e)
        {
            FenetreSouscription fenetreSouscription = new FenetreSouscription();

            fenetreSouscription.selecteurOffre.ItemsSource = VOD.Offres; // n'affiche pas correctement le nom et le cout --> car Offres n'est pas une ICollectionView...
            bool? ok = fenetreSouscription.ShowDialog();
            if (ok == true)
            {
                Souscription souscriptionAAjouter = new Souscription(); // par defaut la date est la date du jour courant --> voir constructeur de Souscription
                souscriptionAAjouter.Offre = (Offre)fenetreSouscription.selecteurOffre.SelectedItem;  // permet de set l'offre de la souscription

                Abonne abonneSelectionne = (Abonne)listeAbonnes.SelectedItem;
                abonneSelectionne.Souscriptions.Add(souscriptionAAjouter);
            }
        }

        private void AjouterSouscriptionPossible(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (listeAbonnes.SelectedItem != null);

        }
        private void SupprimerSouscription(object sender, RoutedEventArgs e)
        {
            Abonne abonneSelectionne = (Abonne)listeAbonnes.SelectedItem;
            Souscription souscriptionASupprimer = (Souscription)listeSouscriptions.SelectedItem;
            abonneSelectionne.Souscriptions.Remove(souscriptionASupprimer);
        }

        private void SupprimerSouscriptionPossible(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (vod != null) && (listeSouscriptions.SelectedItem != null);
        }

        private void AjouterFilm(object sender, RoutedEventArgs e)
        {

            ListeGenres listeGenres = new ListeGenres(); // on recupere la liste des genres existants
            ListePays listePays = new ListePays(); // on recupere la liste des pays existants
            FenetreFilm fenetreFilm = new FenetreFilm(); 
            
            fenetreFilm.selecteurMetteurEnScene.ItemsSource = VOD.Filmographie.MetteursEnScene;
            fenetreFilm.selecteurGenre.ItemsSource = listeGenres;
            fenetreFilm.selecteurPays.ItemsSource = listePays;

            bool? ok = fenetreFilm.ShowDialog();
            if (ok == true)
            {
                Film film = new Film();
                film.Titre = fenetreFilm.titre.Text;
                film.Annee = Convert.ToInt32(fenetreFilm.annee.Text);
                film.Genre = (Genre)fenetreFilm.selecteurGenre.SelectedItem;
                film.Pays = (Pays)fenetreFilm.selecteurPays.SelectedItem;
                film.MetteurEnScene = (MetteurEnScene)fenetreFilm.selecteurMetteurEnScene.SelectedItem;

                Offre offreSelectionnee = (Offre)listeOffres.SelectedItem;
                offreSelectionnee.Films.Add(film);
            }
        }
        private void AjouterFilmPossible(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (listeOffres.SelectedItem != null);
        }

        private void SupprimerFilm(object sender, RoutedEventArgs e)
        {
            Offre offreSelectionnee = (Offre)listeOffres.SelectedItem;
            Film filmASupprimer = (Film)listeFilms.SelectedItem;
            offreSelectionnee.Films.Remove(filmASupprimer);
        }

        private void SupprimerFilmPossible(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (vod != null) && (listeFilms.SelectedItem != null);
        }
    }
       
}
