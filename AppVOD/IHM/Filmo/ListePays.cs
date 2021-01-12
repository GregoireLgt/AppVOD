using System;
using System.Collections.ObjectModel;
using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo
{
    public class ListePays : ObservableCollection<Pays>
    {
        public ListePays()
        {
            foreach (Pays p in Enum.GetValues(typeof(Pays)))
                Add(p);
        }
    }
}
