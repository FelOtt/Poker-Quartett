using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G8_Quartett
{
    public class cSpielverwaltung
    {
        public cSpieler spieler1 { get; private set; }
        public cSpieler computer { get; private set; }
        public int aktuellerSpieler { get; private set; }
        public string vergleichswert { get; private set; }
        public cDeck deck { get; private set; }
        public List<cKarte> gespielteKartenSpieler { get; private set; }
        public List<cKarte> gespielteKartenComputer { get; private set; }

        public void StarteSpiel()
        {
            deck = new cDeck();
            deck.erstelleDeck();
            deck.mischeDeck();

            gespielteKartenSpieler = new List<cKarte>();
            gespielteKartenComputer = new List<cKarte>();

            spieler1 = new cSpieler("Max");
            computer = new cSpieler("Bot");

            //Karten verteilen
            for (int i = 0; i < 52; i++)
            {
                if (i % 2 == 0)
                {
                    spieler1.zieheKarte(deck.zieheKarte());
                }
                else
                {
                    computer.zieheKarte(deck.zieheKarte());
                }
            }

            aktuellerSpieler = 1;
        }

        public void NaechsterSpieler(int spieler)
        {
            aktuellerSpieler = spieler;
        }

        public void SpielerKarteSpielen(int vergleichswert)
        {
            //vergleichswert 0 -> Wert und 1 -> Farbe
            gespielteKartenSpieler.Add(spieler1.kartenHand[0]);
            spieler1.kartenHand.Remove(spieler1.kartenHand[0]);
            gespielteKartenComputer.Add(computer.kartenHand[0]);
            computer.kartenHand.Remove(computer.kartenHand[0]);


            if (vergleichswert == 0)
            {
                //Wenn Kartenwert von Spieler größer dann Karten an Spieler
                if (gespielteKartenSpieler[gespielteKartenSpieler.Count - 1].wert > gespielteKartenComputer[gespielteKartenComputer.Count - 1].wert)
                {
                    spieler1.kartenHand.AddRange(gespielteKartenSpieler);
                    spieler1.kartenHand.AddRange(gespielteKartenComputer);
                    gespielteKartenSpieler.Clear();
                    gespielteKartenComputer.Clear();
                    if (aktuellerSpieler == 2)
                    {
                        MessageBox.Show("Computer hat Wert gewählt!\r\nSpieler gewinnt");
                    }
                    else
                    {
                        MessageBox.Show("Spieler gewinnt");
                    }
                    NaechsterSpieler(1);
                }
                //Wenn Kartenwert von Spieler kleiner dann Karten an Computer
                else if (gespielteKartenSpieler[gespielteKartenSpieler.Count - 1].wert < gespielteKartenComputer[gespielteKartenComputer.Count - 1].wert)
                {
                    computer.kartenHand.AddRange(gespielteKartenSpieler);
                    computer.kartenHand.AddRange(gespielteKartenComputer);
                    gespielteKartenSpieler.Clear();
                    gespielteKartenComputer.Clear();
                    if (aktuellerSpieler == 2)
                    {
                        MessageBox.Show("Computer hat Wert gewählt!\r\nComputer gewinnt");
                    }
                    else
                    {
                        MessageBox.Show("Computer gewinnt");
                    }
                    NaechsterSpieler(2);
                }
            }
            else
            {
                //Wenn Kartenfarbe von Spieler größer dann Karten an Spieler
                if (gespielteKartenSpieler[gespielteKartenSpieler.Count - 1].farbe > gespielteKartenComputer[gespielteKartenComputer.Count - 1].farbe)
                {

                    spieler1.kartenHand.AddRange(gespielteKartenSpieler);
                    spieler1.kartenHand.AddRange(gespielteKartenComputer);
                    gespielteKartenSpieler.Clear();
                    gespielteKartenComputer.Clear();
                    if (aktuellerSpieler == 2)
                    {
                        MessageBox.Show("Computer hat Farbe gewählt!\r\nSpieler gewinnt");
                    }
                    else
                    {
                        MessageBox.Show("Spieler gewinnt");
                    }
                    NaechsterSpieler(1);
                }
                //Wenn Kartenfarbe von Spieler kleiner dann Karten an Computer
                else if (gespielteKartenSpieler[gespielteKartenSpieler.Count - 1].farbe < gespielteKartenComputer[gespielteKartenComputer.Count - 1].farbe)
                {
                    computer.kartenHand.AddRange(gespielteKartenSpieler);
                    computer.kartenHand.AddRange(gespielteKartenComputer);
                    gespielteKartenSpieler.Clear();
                    gespielteKartenComputer.Clear();
                    if (aktuellerSpieler == 2)
                    {
                        MessageBox.Show("Computer hat Farbe gewählt!\r\nComputer gewinnt");
                    }
                    else
                    {
                        MessageBox.Show("Computer gewinnt");
                    }
                    NaechsterSpieler(2);
                }
            }
        }

        public void SpielBeenden()
        {
            string gewinner = "";
            if (spieler1.kartenHand.Count == 0)
            {
                gewinner = "Computer";
            }
            else
            {
                gewinner = "" + spieler1.name;
            }
            MessageBox.Show("Spiel beendet\r\nGewinner: " + gewinner);
        }

    }
}