using System;
using System.Collections.ObjectModel;
using AppVOD.Modele.Filmo;

namespace AppVOD.IHM.Filmo
{
    public class ListePays : ObservableCollection<string>
    {
        public ListePays()
        {
            foreach (string s in Enum.GetNames(typeof(Pays)))
                Add(s);
        }
    }
}
