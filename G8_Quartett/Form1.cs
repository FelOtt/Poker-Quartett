using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G8_Quartett
{
    public partial class Window : Form
    {
        cSpielverwaltung spiel = new cSpielverwaltung();
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            spiel.StarteSpiel();

            LabelAktualisieren();

            lstSpielerGespielt.Items.Clear();
            lstComputerGespielt.Items.Clear();

            lstKarten.Items.Clear();
            foreach (cKarte karte in spiel.spieler1.kartenHand)
            {
                lstKarten.Items.Add(karte.ToString());
            }
        }

        private void btnBenutzeWert_Click(object sender, EventArgs e)
        {
            AktualisiereListe();

            spiel.SpielerKarteSpielen(0);

            LabelAktualisieren();
            lstKarten.Items.Clear();
            foreach (cKarte karte in spiel.spieler1.kartenHand)
            {
                lstKarten.Items.Add(karte.ToString());
            }
            
            if (spiel.aktuellerSpieler == 2)
            {
                ComputerZug();
            }
        }

        private void btnBenutzeFarbe_Click(object sender, EventArgs e)
        {
            AktualisiereListe();
            spiel.SpielerKarteSpielen(1);

            LabelAktualisieren();
            lstKarten.Items.Clear();
            foreach (cKarte karte in spiel.spieler1.kartenHand)
            {
                lstKarten.Items.Add(karte.ToString());
            }
            if (spiel.aktuellerSpieler == 2)
            {
                ComputerZug();
            }
        }

        public void AktualisiereListe()
        {
            SpielEnde();

            lblKarte.Text = spiel.spieler1.kartenHand[0].ToString();

            lstSpielerGespielt.Items.Insert(0, spiel.spieler1.kartenHand[0].ToString());
            lstComputerGespielt.Items.Insert(0, spiel.computer.kartenHand[0].ToString());

            lstKarten.Items.Clear();
            foreach (cKarte karte in spiel.spieler1.kartenHand)
            {
                lstKarten.Items.Add(karte.ToString());
            }
        }

        public void ComputerZug()
        {
            AktualisiereListe();

            if (spiel.computer.kartenHand[0].wert+1 >= (spiel.computer.kartenHand[0].farbe + 1)*3)
            {
                spiel.SpielerKarteSpielen(0);
            }
            else
            {
                spiel.SpielerKarteSpielen(1);
            }

            if (spiel.aktuellerSpieler == 2)
            {
                ComputerZug();
            }
            else
            {
                LabelAktualisieren();
                lstKarten.Items.Clear();
                foreach (cKarte karte in spiel.spieler1.kartenHand)
                {
                    lstKarten.Items.Add(karte.ToString());
                }
            }
        }

        public void SpielEnde()
        {
            if (spiel.spieler1.kartenHand.Count == 0 || spiel.computer.kartenHand.Count == 0)
            {
                spiel.SpielBeenden();
                Close();
            }
        }

        private void btnNameEingeben_Click(object sender, EventArgs e)
        {
            spiel.spieler1.name = txtName.Text;
        }

        public void LabelAktualisieren()
        {
            if (spiel.spieler1.kartenHand[0].farbe == 0 || spiel.spieler1.kartenHand[0].farbe == 1)
            {
                lblKarte.ForeColor = Color.Red;
            }
            else
            {
                lblKarte.ForeColor = Color.Black;
            }
            lblKarte.Text = spiel.spieler1.kartenHand[0].ToString();
        }
    }
}
