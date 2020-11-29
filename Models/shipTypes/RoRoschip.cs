using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_overerving.Models
{
    public class RoRoschip : Schip
    {
        #region Attributes
        public int Aantal_autos { get; set; }
        public int Aantal_trucks { get; set; }
        public double Cargowaarde { get; set; }
        #endregion
        public RoRoschip(double _lengte, double _breedte, double _tonnage, string _naam, int _aantal_autos, int _aantal_trucks, double _cargowaarde) : base(_lengte, _breedte, _tonnage, _naam)
        {
            Aantal_autos = _aantal_autos;
            Aantal_trucks = _aantal_trucks;
            Cargowaarde = _cargowaarde;
        }
        public override string ToString()
        {
            return base.ToString() + "Dit is een RoRoschip met " + Aantal_autos + " aantal autos en " + Aantal_trucks + "aantal trucks, de cargowaarde is:" + Cargowaarde;
        }
    }
}
