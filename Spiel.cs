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

            spielerAktiv = null;
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
        
        public void wuerfeln()
        {
            schritte = rand.Next(1, 7);
            darfWuerfeln = false;
        }

        public String getSpielerAktivName()
        {
            return spielerAktiv.getBezeichnung();
        }

        public void spielerHochlaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X, spielerAktiv.getPosition().Y - 1))
            {  
                spielerAktiv.moveUp();
                schritte--;
            }
        }

        public void spielerRunterlaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X, spielerAktiv.getPosition().Y + 1))
            {
                spielerAktiv.moveDown();
                schritte--;
            }
        }

        public void spielerLinkslaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X - 1, spielerAktiv.getPosition().Y))
            {
                spielerAktiv.moveLeft();
                schritte--;
            }
        }

        public void spielerRechtslaufen()
        {
            if (canMoveTo(spielerAktiv.getPosition().X + 1, spielerAktiv.getPosition().Y))
            {
                spielerAktiv.moveRight();
                schritte--;
            }
        }

        public Point getZufallFreiesFeld()
        {
            Point position = new Point();

            do
            {
                position.X = rand.Next(0, breiteFeld);
                position.Y = rand.Next(0, hoeheFeld);
            } while (isFeldBelegt(position));

            return position;
        }

        public int getSchritte()
        {
            return schritte;
        }
        
        public bool getDarfWueferln()
        {
            return darfWuerfeln;
        }

        public List<Objekt> getFeldObjekte()
        {
            return feldObjekte;
        }

        public void addFeldObjekt(Objekt objekt)
        {
            if(!isFeldBelegt(objekt.getPosition()))
                this.feldObjekte.Add(objekt);
        }

        public void addSpieler(Spieler spieler)
        {
            if (spieler1 == null)
            {
                spieler1 = spieler;
                addFeldObjekt(spieler1);
            }
            else if (spieler2 == null)
            {
                spieler2 = spieler;
                addFeldObjekt(spieler2);
            }
        }

        private bool canMoveTo(int x, int y)
        {
            if (!isPosInFeld(x, y))
                return false;

            if (isFeldBelegt(new Point(x, y)))
                return false;
            
            return true;
        }

        private bool isPosInFeld(int x, int y)
        {
            if (x < 0 || y < 0)
                return false;
            if (x >= breiteFeld)
                return false;
            if (y >= hoeheFeld)
                return false;

            return true;
        }

        private bool isFeldBelegt(Point feld)
        {
            foreach (Objekt objekt in feldObjekte)
                if (objekt.getPosition() == feld)
                    return true;

            return false;
        }

        private void spielerAktivWechseln()
        {
            if (spielerAktiv == null)
            {
                if (rand.Next(1, 3) == 1)
                    spielerAktiv = spieler1;
                else spielerAktiv = spieler2;
            }

            if (spielerAktiv == spieler1)
                spielerAktiv = spieler2;
            else
                spielerAktiv = spieler1;
        }
    }
}
