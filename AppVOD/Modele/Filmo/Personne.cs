
namespace AppVOD.Modele.Filmo
{
    public abstract class Personne
    {
        private string prenom;
        private string nom;

        protected Personne()
        {
            prenom = "Prénom";
            nom = "Nom";
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public override string ToString()
        {
            return prenom + " " + nom.ToUpper();
        }

    }
}
