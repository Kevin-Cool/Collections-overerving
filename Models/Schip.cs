using System;
using System.Collections.Generic;

namespace Collections_overerving
{
    public abstract class Schip
    {
        #region Attributes
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public double Tonnage { get; set; }
        public string Naam { get; set; }
        #endregion
        public Schip() { }
        public Schip(double _lengte, double _breedte, double _tonnage, string _naam)
        {
            Lengte = _lengte;
            Breedte = _breedte;
            Tonnage = _tonnage;
            Naam = _naam;
        }
        public override string ToString()
        {
            return "Schip" + Naam + ", dit schip is  " + Lengte + " lang,  " + Breedte + " breedt en heeft een tonnage van:" + Tonnage;
        }
    }
}
