using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AppVOD.Modele.Filmo
{
    public class Film
    {
        private string titre;
        private int annee;
        private Genre genre;
        private Pays pays;
        private MetteurEnScene metteurEnScene;
        private ICollection<Role> roles;

        public Film()
        {
            titre = "Titre";
            annee = 2000;
            roles = new List<Role>();
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public Pays Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        public MetteurEnScene MetteurEnScene
        {
            get { return metteurEnScene; }
            set { metteurEnScene = value; }
        }

        public ICollection<Role> Roles
        {
            get { return roles; }
        }

        public override string ToString()
        {
            return titre + " (" + annee + ")";
        }
    }
}
