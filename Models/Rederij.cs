using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections_overerving.Models
{
    public class Rederij
    {
        #region
        public string Naam { get; set; }
        public Dictionary<string, Vloot> Vloten { get; set; } = new Dictionary<string, Vloot>();
        public string[] Havens { get; set; }
        #endregion
        public Rederij() { }
        public Rederij(string _naam)
        {
            Naam = _naam;
        }
        public Rederij(string _naam, string[] _havens) : this(_naam)
        {
            Havens = _havens;
            Array.Sort(Havens);
            
        }
        #region Methodes
        public Vloot Get_Vloot_by_name(string vlootNaam)
        {
            return Vloten[vlootNaam];
        }
        public void Verplaats_schip(string schip,string vloot1,string vloot2)
        {
            Vloten[vloot2].Schepen.Add(schip, Vloten[vloot1].Schepen[schip]);
            Vloten[vloot1].Schepen.Remove(schip);
        }
        
        #endregion
    }
}
