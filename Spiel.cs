using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace grundspiel
{
    class Spiel
    {
        private Random rand;
        private Spieler spieler1, spieler2;
        private Spieler spielerAktiv;
        private int breiteFeld;
        private int hoeheFeld;

        public Spiel(int breite, int hoehe)
        {
            this.breiteFeld = breite;
            this.hoeheFeld = hoehe;

            rand = new Random();
            spieler1 = new Spieler("Spieler1", 4,3);
            spieler2 = new Spieler("Spieler2",1,2);

            spielerAktiv = spieler1;
        }

        public int getBreite()
        {
            return breiteFeld;
        }

        public int getHoehe()
        {
            return hoeheFeld;
        }

        public bool canMoveTo(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < breiteFeld && y < hoeheFeld)
                if (!objectInField(x, y))
                    return true;

            return false;
        }

        // muss implementiert werden
        public bool objectInField(int x, int y)
        {
            
              return false;
        }

        public void wuerfeln()
        {
            spielerAktiv.setSchritte(rand.Next(1, 7));
        }

        public String getSpielerAktivName()
        {
            return spielerAktiv.getBezeichnung();
        }

        public int getSpielerAktivSchritte()
        {
            return spielerAktiv.getSchritte();
        }

        public void spielerWechseln()
        {
            if (spielerAktiv == spieler1)
                spielerAktiv = spieler2;
            else
                spielerAktiv = spieler1;

            spielerAktiv.resetSchritte();
        }

        public void spielerHochlaufen()
        {
            if (spielerAktiv.getSchritte() > 0)
                if (canMoveTo(spielerAktiv.getPosition().X, spielerAktiv.getPosition().Y - 1))
                {  
                    spielerAktiv.moveUp();
                    spielerAktiv.schrittRunterzaehlen();
                }
        }

        public void spielerRunterlaufen()
        {
            if (spielerAktiv.getSchritte() > 0)
                if (canMoveTo(spielerAktiv.getPosition().X, spielerAktiv.getPosition().Y + 1))
                {
                    spielerAktiv.moveDown();
                    spielerAktiv.schrittRunterzaehlen();
                }
        }

        public void spielerLinkslaufen()
        {
            if (spielerAktiv.getSchritte() > 0)
                if (canMoveTo(spielerAktiv.getPosition().X - 1, spielerAktiv.getPosition().Y))
                {
                    spielerAktiv.moveLeft(); 
                    spielerAktiv.schrittRunterzaehlen();
                }
        }

        public void spielerRechtslaufen()
        {
            if (spielerAktiv.getSchritte() > 0)
                if (canMoveTo(spielerAktiv.getPosition().X + 1, spielerAktiv.getPosition().Y))
                {
                    spielerAktiv.moveRight();
                    spielerAktiv.schrittRunterzaehlen();
                }
        }

        public Spieler getSpieler1()
        {
            return spieler1;
        }

        public Spieler getSpieler2()
        {
            return spieler2;
        }
    }
}
