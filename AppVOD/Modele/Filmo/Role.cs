
namespace AppVOD.Modele.Filmo
{
    public class Role: ObservableObject
    {
        private string personnage;
        private Acteur acteur;

        public string Personnage
        {
            get { return personnage; }
            set { personnage = value; ObjectChanged("Personnage"); }
        }

        public Acteur Acteur
        {
            get { return acteur; }
            set { acteur = value; ObjectChanged("Acteur"); }
        }

        public override string ToString()
        {
            return personnage + " (" + acteur + ")";
        }

    }
}
