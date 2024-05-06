using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G8_Quartett
{
    public class cDeck
    {
        public List<cKarte> karten { get; private set; }

        public cDeck()
        {
            karten = new List<cKarte>();
        }

        public void erstelleDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    karten.Add(new cKarte(i, j));
                }
            }
        }

        public void mischeDeck()
        {
            Random rnd = new Random();
            karten = karten.OrderBy(x => rnd.Next()).ToList();
        }

        public cKarte zieheKarte()
        {
            cKarte karte = karten[0];
            karten.RemoveAt(0);
            return karte;
        }
    }
}