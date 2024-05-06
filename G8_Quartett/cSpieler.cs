using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G8_Quartett
{
    public class cSpieler
    {
        public string name { get; set; }
        public List<cKarte> kartenHand { get; private set; }

        public cSpieler(string pName)
        {
            name = pName;
            kartenHand = new List<cKarte>();
        }

        public void zieheKarte(cKarte karte)
        {
            kartenHand.Add(karte);
        }
    }
}