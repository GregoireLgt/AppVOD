using System.Windows;
using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo.Enumeration
{
    public partial class VueFilm : Window
    {
        private Film film;

        public VueFilm()
        {
            InitializeComponent();
            film = new Film();
            this.DataContext = film;
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            film.Titre = "Vertigo";
            film.Annee = 1967;
            film.Genre = Genre.Policier;
        }
    }
}
