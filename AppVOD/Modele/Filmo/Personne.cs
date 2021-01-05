
namespace AppVOD.Modele.Filmo
{
    public abstract class Personne : ObservableObject
    {
        private string prenom;
        private string nom;

        protected Personne()
        {
            prenom = "Prénom"; // valeur par défaut
            nom = "Nom"; // valeur par défaut
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; ObjectChanged("Prenom"); }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; ObjectChanged("Nom"); }
        }

        public override string ToString()
        {
            return prenom + " " + nom.ToUpper();
        }

    }
}
