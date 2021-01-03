using System.Windows;
using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo.Texte
{
    public partial class VueFilm : Window
    {
        private Film film;

        public VueFilm()
        {
            InitializeComponent();
            film = new Film();
            DataContext = film;
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            film.Titre = "Vertigo";
            film.Annee = 1967;
        }
    }
}
