
namespace AppVOD.Modele.Filmo
{
    public class Role
    {
        private string personnage;
        private Acteur acteur;

        public string Personnage
        {
            get { return personnage; }
            set { personnage = value; }
        }

        public Acteur Acteur
        {
            get { return acteur; }
            set { acteur = value; }
        }

        public override string ToString()
        {
            return personnage + " (" + acteur + ")";
        }

    }
}
