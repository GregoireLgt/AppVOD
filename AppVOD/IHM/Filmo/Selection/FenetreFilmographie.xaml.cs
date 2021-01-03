using System.Windows;
using AppVOD.Modele.Filmo;


namespace AppVOD.IHM.Filmo.Selection
{
    public partial class FenetreFilmographie : Window
    {
        public FenetreFilmographie()
        {
            InitializeComponent();

            Filmographie filmographie = new Filmographie();
            listeFilms.ItemsSource = filmographie.Films;

            Film vertigo = new Film();
            vertigo.Titre = "Vertigo";
            vertigo.Annee = 1966;
            Film murder = new Film();
            murder.Titre = "Anatomy of a Murder";
            murder.Annee = 1967;

            filmographie.Films.Add(vertigo);
            filmographie.Films.Add(murder);
        }
    }
}
