using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_overerving.Models
{
    public class Containerschip : Schip
    {
        #region Attributes
        public int Aantalcontainers { get; set; }
        public double Cargowaarde { get; set; }
        #endregion
        public Containerschip(double _lengte, double _breedte, double _tonnage, string _naam, int _aantalcontainers, double _cargowaarde) : base(_lengte, _breedte, _tonnage, _naam)
        {
            Aantalcontainers = _aantalcontainers;
            Cargowaarde = _cargowaarde;
        }
        public override string ToString()
        {
            return base.ToString() +"Dit is een Containerschip met "+Aantalcontainers+" containers en een Cargowaarde van: "+Cargowaarde;
        }
    }
}
