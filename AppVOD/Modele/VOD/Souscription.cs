using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVOD.Modele.VOD
{
    /// <summary>
    /// Une souscription représente l'offre qu'un abonné utilise
    /// </summary>
    public class Souscription: ObservableObject
    {

        private Offre offre; // role de l'offre par rapport à la souscription

        private DateTime date; // une souscription se caractérise par sa date


        public Souscription()
        {
            offre = new Offre();
            date = new DateTime();
            date = DateTime.Today;
        }

        public DateTime Date // propriété Date
        {
            get { return date; }
            set { date = value; ObjectChanged("Date"); }
        }


        public Offre Offre // Propriété Offre
        {
            get { return offre; }
            set { offre = value; ObjectChanged("Offre"); }
        }
    }

}
