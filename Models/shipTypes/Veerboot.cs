using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_overerving.Models
{
    public class Veerboot : Schip
    {
        #region Attributes
        public int Aantal_passagiers { get; set; }
        public string[] Traject { get; set; }
        #endregion
        public Veerboot(double _lengte, double _breedte, double _tonnage, string _naam, int _aantal_passagiers, string[] _traject) : base(_lengte, _breedte, _tonnage, _naam)
        {
            Aantal_passagiers = _aantal_passagiers;

            if(Traject.Length == 2)
            {
                Traject = _traject;
            }
            else
            {
                throw new ArgumentException("Traject op en veerboot moet 2 stops hebben.");
            }
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
