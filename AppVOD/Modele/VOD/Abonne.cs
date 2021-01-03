using AppVOD.Modele.Filmo;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AppVOD.Modele.VOD
{
    /// <summary>
    /// Un abonne hérite de la classe Personne
    /// </summary>
    public class Abonne: Personne
    {

        private ObservableCollection<Souscription> souscriptions; // un abonné peut avoir 1..plusiuers souscriptions


        public Abonne() // le constructeur de base (celui de Personne) sera appelé avant
        {
            souscriptions = new ObservableCollection<Souscription>();
        }
  
        public ICollection<Souscription> Souscriptions
        {
            get { return souscriptions; }
        }
          

    }
}
