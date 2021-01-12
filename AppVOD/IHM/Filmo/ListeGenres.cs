using System;
using System.Collections.ObjectModel;
using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo
{
    public class ListeGenres : ObservableCollection<Genre>
    {
        public ListeGenres()
        {
            foreach (Genre g in Enum.GetValues(typeof(Genre)))
                Add(g);
        }
    }
}
