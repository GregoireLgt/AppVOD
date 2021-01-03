using System.Windows;
using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo.Table
{
    public partial class VueFilms : Window
    {
        private Filmographie filmographie;

        public VueFilms()
        {
            InitializeComponent();

            filmographie = new Filmographie();
            listeFilms.ItemsSource = filmographie.Films;
        }

        private void Test(object sender, RoutedEventArgs e)
        {
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
