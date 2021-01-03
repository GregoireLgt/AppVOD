using System.Windows;

using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo.Selection
{
    public partial class VueFilm : Window
    {
        public VueFilm()
        {
            InitializeComponent();

            Filmographie filmographie = new Filmographie();
            selectecteurMetteurEnScene.ItemsSource = filmographie.MetteursEnScene;

            MetteurEnScene hitchcock = new MetteurEnScene();
            hitchcock.Prenom = "Alfred";
            hitchcock.Nom = "Hitchcock";
            MetteurEnScene preminger = new MetteurEnScene();
            preminger.Prenom = "Otto";
            preminger.Nom = "Preminger";

            filmographie.Artistes.Add(hitchcock);
            filmographie.Artistes.Add(preminger);

            Film vertigo = new Film();
            this.DataContext = vertigo;
            vertigo.Titre = "Vertigo";
            vertigo.Annee = 1966;
            vertigo.MetteurEnScene = hitchcock;
        }
    }
}
