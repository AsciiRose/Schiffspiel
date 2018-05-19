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
        private int schritte;
        private bool darfWuerfeln;
        List<Objekt> feldObjekte;

        public Spiel(int breite, int hoehe)
        {
            this.breiteFeld = breite;
            this.hoeheFeld = hoehe;
            feldObjekte = new List<Objekt>();

            rand = new Random();
            spieler1 = new Spieler("Spieler1", generateRandomPositionOnField(), Resource1.player1);
            feldObjekte.Add(spieler1);
            spieler2 = new Spieler("Spieler2", generateRandomPositionOnField(), Resource1.player2);
            feldObjekte.Add(spieler2);

            spielerAktiv = null;
            startNewRound();
        }

        public void startNewRound()
        {
            schritte = 0;
            darfWuerfeln = true;
            spielerAktivWechseln();
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
                if (!feldBegehbar(x, y))
                    return true;

            return false;
        }

        public bool feldBegehbar(int x, int y)
        {
            Point feld = new Point(x, y);

            foreach (Objekt objekt in feldObjekte)
                if (objekt.getPosition() == feld)
                    return true;

            return false;
        }

        public void wuerfeln()
        {
            setSchritte(rand.Next(1, 7));
            darfWuerfeln = false;
        }

        public String getSpielerAktivName()
        {
            return spielerAktiv.getBezeichnung();
        }

        private void spielerAktivWechseln()
        {
            if(spielerAktiv == null)
            {
                if (rand.Next(1, 3) == 1)
                    spielerAktiv = spieler1;
                else spielerAktiv = spieler2;
            }

            if (spielerAktiv == spieler1)
                spielerAktiv = spieler2;
            else
                spielerAktiv = spieler1;

            resetSchritte();
        }

        public void spielerHochlaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X, spielerAktiv.getPosition().Y - 1))
            {  
                spielerAktiv.moveUp();
                schrittRunterzaehlen();
            }
        }

        public void spielerRunterlaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X, spielerAktiv.getPosition().Y + 1))
            {
                spielerAktiv.moveDown();
                schrittRunterzaehlen();
            }
        }

        public void spielerLinkslaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X - 1, spielerAktiv.getPosition().Y))
            {
                spielerAktiv.moveLeft(); 
                schrittRunterzaehlen();
            }
        }

        public void spielerRechtslaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X + 1, spielerAktiv.getPosition().Y))
            {
                spielerAktiv.moveRight();
                schrittRunterzaehlen();
            }
        }

        private Point generateRandomPositionOnField()
        {
            int x, y;

            do
            {
                x = rand.Next(0, breiteFeld);
                y = rand.Next(0, hoeheFeld);
            } while (feldBegehbar(x, y));

            return new Point(x, y);
        }

        public int getSchritte()
        {
            return schritte;
        }

        public void resetSchritte()
        {
            schritte = 0;
        }

        public void schrittRunterzaehlen()
        {
            schritte--;
        }

        public void setSchritte(int schritte)
        {
            this.schritte = schritte;
        }

        public bool getDarfWueferln()
        {
            return darfWuerfeln;
        }

        public void setDarfWuerfeln()
        {
            if (darfWuerfeln)
                darfWuerfeln = false;
            else
                darfWuerfeln = true;
        }

        public List<Objekt> getFeldObjekte()
        {
            return feldObjekte;
        }
    }
}
