using System;
using System.Xml;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.ComponentModel;
using System.IO;
using System.Xaml;

namespace AppVOD.Modele.Filmo
{
    public class Filmographie
    {
        private ObservableCollection<Artiste> artistes;
        private ObservableCollection<Film> films;
        private CollectionViewSource metteursEnScene;
        private CollectionViewSource acteurs;

        public Filmographie()
        {
            artistes = new ObservableCollection<Artiste>();
            films = new ObservableCollection<Film>();

            acteurs = new CollectionViewSource();
            acteurs.Source = artistes;
            acteurs.View.Filter = (e => e is Acteur);

            metteursEnScene = new CollectionViewSource();
            metteursEnScene.Source = artistes;
            metteursEnScene.View.Filter = (e => e is MetteurEnScene);
        }

        public ICollection<Film> Films
        {
            get { return films; }
        }

        public ICollection<Artiste> Artistes
        {
            get { return artistes; }
        }

        public ICollectionView MetteursEnScene
        {
            get { return metteursEnScene.View; }
        }

        public ICollectionView Acteurs
        {
            get { return acteurs.View; }
        }

        // XAML : impact de l'ordre des propriétés Films et Artistes pour la sérialisation
        //  1) la première propriété dans le code source est définie comme une relation de composition/agrégation
        //  2) XAML remet dans l'ordre alphabétique

        public static Filmographie Charger(string nomFichier)
        {
            TextReader reader = File.OpenText(nomFichier);
            Filmographie filmographie = (Filmographie)XamlServices.Load(reader);
            reader.Close();
            return filmographie;
        }

        public void Enregistrer(string nomFichier)
        {
            TextWriter writer = File.CreateText(nomFichier); // permet de créer un fichier texte au chemin considéré et renvoie un objet qui permet d'écrire dedans
            XamlServices.Save(writer, this);
            writer.Close();
        }

    }
}
