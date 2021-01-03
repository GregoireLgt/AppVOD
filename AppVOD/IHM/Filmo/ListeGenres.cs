using System;
using System.Collections.ObjectModel;
using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo
{
    public class ListeGenres : ObservableCollection<string>
    {
        public ListeGenres()
        {
            foreach (string s in Enum.GetNames(typeof(Genre)))
                Add(s);
        }
    }
}
