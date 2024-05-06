using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G8_Quartett
{
    public class cKarte
    {
        public int farbe { get; private set; }
        public int wert { get; private set; }

        public cKarte(int pFarbe, int pWert)
        {
            farbe = pFarbe;
            wert = pWert;
        }

        public override string ToString()
        {
            string output = "";

            switch (wert)
            {
                case 0:
                    output += "2";
                    break;
                case 1:
                    output += "3";
                    break;
                case 2:
                    output += "4";
                    break;
                case 3:
                    output += "5";
                    break;
                case 4:
                    output += "6";
                    break;
                case 5:
                    output += "7";
                    break;
                case 6:
                    output += "8";
                    break;
                case 7:
                    output += "9";
                    break;
                case 8:
                    output += "10";
                    break;
                case 9:
                    output += "J";
                    break;
                case 10:
                    output += "Q";
                    break;
                case 11:
                    output += "K";
                    break;
                case 12:
                    output += "A";
                    break;
            }

            switch (farbe)
            {
                case 0:
                    output += "♦";
                    break;
                case 1:
                    output += "♥";
                    break;
                case 2:
                    output += "♠";
                    break;
                case 3:
                    output += "♣";
                    break;
            }
            return output;
        }
    }
}