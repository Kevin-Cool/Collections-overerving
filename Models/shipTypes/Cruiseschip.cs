using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_overerving.Models
{
    public class Cruiseschip : Schip
    {
        #region Attributes
        public int Aantal_passagiers { get; set; }
        public List<string> Traject { get; set; }
        #endregion
        public Cruiseschip(double _lengte, double _breedte, double _tonnage, string _naam, int _aantal_passagiers, List<string> _traject) : base(_lengte, _breedte, _tonnage, _naam)
        {
            Aantal_passagiers = _aantal_passagiers;
            Traject = _traject;
        }
        public override string ToString()
        {
            string temp = base.ToString() + "Dit is een Cruiseschip met " + Aantal_passagiers + " aantal passagiers en een traject van: ";
            foreach (string traject in Traject)
            {
                temp += traject + ",";
            }
            return temp;
        }
    }
}
