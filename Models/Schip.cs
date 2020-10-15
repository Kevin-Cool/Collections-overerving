using System;

namespace Collections_overerving
{
    public class Schip
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
    }
}
