using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace AppVOD
{
    using AppVOD.Modele.VOD;
    using Modele.Filmo;
    using System.Diagnostics;

    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // TestPolymorphisme();
            // String fileName = "C:\\Users\\famil\\OneDrive\\Documents\\Gregoire_S9_Plateforme_dotNET\\AppVOD\\AppVOD\\MaFilmographie.xaml";
            // Filmographie f = Filmographie.Charger(fileName);

            modeVOD();
            //f.Enregistrer(fileName + "-save.xml");
        }

        public void TestPolymorphisme()
        {
            Personne a1 = new Acteur();
            Personne m1 = new MetteurEnScene();
            Debug.Assert(a1.ToString() == "Prénom NOM");
            Debug.Assert(m1.ToString() == "Prénom NOM");
            Object a2 = new Acteur();
            Object m2 = new MetteurEnScene();
            Debug.Assert(a2.ToString() == "Prénom NOM"); // échoue si Personne.ToString non polymorphe (new ToString())
            Debug.Assert(m2.ToString() == "Prénom NOM");
        }


        public void modeVOD()
        {
            String fileNameVOD = "C:\\Users\\famil\\OneDrive\\Documents\\Gregoire_S9_Plateforme_dotNET\\AppVOD\\AppVOD\\MaVOD.xaml";
            VOD vod = VOD.Charger(fileNameVOD);

            vod.Enregistrer(fileNameVOD + "-save.xml");

        }
    }

}
