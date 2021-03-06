﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_overerving.Models
{
    public class Gastanker : Schip
    {
        #region Attributes
        public double Cargowaarde { get; set; }
        public double Volume { get; set; }
        public GasType Lading { get; set; }
        #endregion
        public Gastanker(double _lengte, double _breedte, double _tonnage, string _naam, double _cargowaarde, double _volume, GasType _lading) : base(_lengte, _breedte, _tonnage, _naam)
        {
            Cargowaarde = _cargowaarde;
            Volume = _volume;
            Lading = _lading;
        }
        public override string ToString()
        {
            return base.ToString() + "Dit is een Gastanker met een cargowaarde van:" + Cargowaarde + " en een volume van: " + Volume + ", de lading is:"+Lading.ToString();
        }
    }
}
