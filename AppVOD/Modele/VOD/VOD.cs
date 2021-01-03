using System.Collections.ObjectModel;
using System.Collections.Generic;
using AppVOD.Modele.Filmo;
using System.Linq;
using System.Text;
using System.IO;
using System.Xaml;

namespace AppVOD.Modele.VOD
{
    public class VOD
    {
        private Filmographie filmographie; // une VOD est composée d'une unique filmographie
        private ObservableCollection<Abonne> abonnes; // une VOD est composée de 0..plusiuers abonnés
        private ObservableCollection<Offre> offres; // une VOD est composée de plusieurs offres

        public VOD()
        {
            abonnes = new ObservableCollection<Abonne>();
            offres = new ObservableCollection<Offre>();

            filmographie = new Filmographie();
        }


        public ICollection<Abonne> Abonnes
        {
            get { return abonnes; }
        }

        public ICollection<Offre> Offres
        {
            get { return offres; }
        }

        public Filmographie Filmographie
        {
            get { return filmographie; }
            set { filmographie = value; }
        }
        public static VOD Charger(string nomFichier)
        {
            TextReader reader = File.OpenText(nomFichier);
            VOD maVOD = (VOD)XamlServices.Load(reader);
            reader.Close();
            return maVOD;
        }

        public void Enregistrer(string nomFichier)
        {
            TextWriter writer = File.CreateText(nomFichier); // permet de créer un fichier texte au chemin considéré et renvoie un objet qui permet d'écrire dedans
            XamlServices.Save(writer, this);
            writer.Close();
        }

    }
}
