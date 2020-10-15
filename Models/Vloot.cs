using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_overerving.Models
{
    class Vloot
    {
        #region
        public string Naam { get; set; }
        public Schip[] Schepen { get; set; }
        #endregion
        public Vloot() { }
        public Vloot(string _naam)
        {
            Naam = _naam;
        }
        public Vloot(string _naam, Schip[] _schepen) : this(_naam)
        {
            Schepen = _schepen;
        }
    }
}
