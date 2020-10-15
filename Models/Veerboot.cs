using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_overerving.Models
{
    class Veerboot : Schip
    {
        #region Attributes
        public int Aantal_passagiers { get; set; }
        public string[] Traject { get; set; }
        #endregion
        public Veerboot(double _lengte, double _breedte, double _tonnage, string _naam, int _aantal_passagiers, string[] _traject) : base(_lengte, _breedte, _tonnage, _naam)
        {
            Aantal_passagiers = _aantal_passagiers;
            Traject = _traject;
        }
    }
}
