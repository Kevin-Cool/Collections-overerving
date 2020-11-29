using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections_overerving.Models
{
    public class Vloot
    {
        #region
        public string Naam { get; set; }
        public Dictionary<string, Schip> Schepen { get; set; } = new Dictionary<string, Schip>();
        #endregion
        public Vloot() { }
        public Vloot(string _naam)
        {
            Naam = _naam;
        }
        public Schip Vind_schip(string naam)
        {
            return Schepen[naam];
        }
        #region Methodes
        public string Geef_overzicht()
        {
            string returnString = "";
            foreach (Schip schip in Schepen.Values)
            {
                returnString += schip.ToString();
            }

            return returnString;
        }
        public double Geef_totaale_tonnage()
        {
            double aantal = 0;
            foreach (Schip schip in Schepen.Values)
            {
                aantal += schip.Tonnage;
            }
            return aantal;
        }
        public int Geef_totaale_Aantal_passagiers()
        {
            int aantal = 0;
            foreach (Schip schip in Schepen.Values)
            {
                if (schip.GetType().Equals("Collections_overerving.Models.Cruiseschip"))
                {
                    Cruiseschip tempschip = (Cruiseschip)schip;
                    aantal += tempschip.Aantal_passagiers;
                }else if (schip.GetType().Equals("Collections_overerving.Models.Veerboot"))
                {
                    Veerboot tempschip = (Veerboot)schip;
                    aantal += tempschip.Aantal_passagiers;
                }
            }
            return aantal;
        }
        public double Geef_totaale_cargowaarde()
        {
            double aantal = 0;
            foreach (Schip schip in Schepen.Values)
            {
                switch (schip.GetType().ToString())
                {
                    case "Collections_overerving.Models.Containerschip":
                        Containerschip tempContainerschip = (Containerschip)schip;
                        aantal += tempContainerschip.Cargowaarde;
                        break;
                    case "Collections_overerving.Models.RoRoschip":
                        RoRoschip tempRoRoschip = (RoRoschip)schip;
                        aantal += tempRoRoschip.Cargowaarde;
                        break;
                    case "Collections_overerving.Models.Olietanker":
                        Olietanker tempOlietanker = (Olietanker)schip;
                        aantal += tempOlietanker.Cargowaarde;
                        break;
                    case "Collections_overerving.Models.Gastanker":
                        Gastanker tempGastanker = (Gastanker)schip;
                        aantal += tempGastanker.Cargowaarde;
                        break;
                    default:
                        break;
                }
            }
            return aantal;
        }
        public double Geef_totaale_volume_van_tankers()
        {
            double aantal = 0;
            foreach (Schip schip in Schepen.Values)
            {
                switch (schip.GetType().ToString())
                {
                    case "Collections_overerving.Models.Olietanker":
                        Olietanker tempOlietanker = (Olietanker)schip;
                        aantal += tempOlietanker.Volume;
                        break;
                    case "Collections_overerving.Models.Gastanker":
                        Gastanker tempGastanker = (Gastanker)schip;
                        aantal += tempGastanker.Volume;
                        break;
                    default:
                        break;
                }
            }
            return aantal;
        }
        #endregion
    }
}
