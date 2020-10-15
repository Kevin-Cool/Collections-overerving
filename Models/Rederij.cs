using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections_overerving.Models
{
    class Rederij
    {
        #region
        public string Naam { get; set; }
        public Vloot[] Vloten { get; set; }
        public string[] Havens { get; set; }
        #endregion
        public Rederij() { }
        public Rederij(string _naam)
        {
            Naam = _naam;
        }
        public Rederij(string _naam, Vloot[] _vloten, string[] _havens) : this(_naam)
        {
            Vloten = _vloten;
            Havens = _havens;
            Array.Sort(Havens);
            
        }
        #region Methodes
        public Vloot Get_Vloot_by_name(string vlootNaam)
        {
            return Vloten.FirstOrDefault(x => x.Naam == vlootNaam);
        }
        #endregion
    }
}
