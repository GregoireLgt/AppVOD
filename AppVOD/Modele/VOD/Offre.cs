using AppVOD.Modele.Filmo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AppVOD.Modele.VOD
{
    /// <summary>
    /// Une offre est caractérisée par son coût et les films qu'elle contient
    /// </summary>
    public class Offre
    {
        private float cout; // une offre est caractérisée par son cout

        private ObservableCollection<Film> films;


        public Offre()
        {
            films = new ObservableCollection<Film>();

        }

        public ICollection<Film> Films
        {
            get { return films; }
        }

        public float Cout // propriété Cout
        {
            get { return cout; }
            set { cout = value; }
        }

    }
}
