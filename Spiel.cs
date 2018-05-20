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
        private List<Objekt> feldObjekte;
        private List<Hindernis> feldHindernisse;
        private List<Item> feldItems;

        public Spiel(int breite, int hoehe)
        {
            this.breiteFeld = breite;
            this.hoeheFeld = hoehe;
            feldObjekte = new List<Objekt>();
            feldHindernisse = new List<Hindernis>();
            feldItems = new List<Item>();

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
            Point naechstePosition = new Point(
                spielerAktiv.getPosition().X,
                spielerAktiv.getPosition().Y - 1);

            if (canMoveTo(naechstePosition))
            {  
                spielerAktiv.moveUp();
                schritte--;
            }
        }

        public void spielerRunterlaufen()
        {
            Point naechstePosition = new Point(
                spielerAktiv.getPosition().X, 
                spielerAktiv.getPosition().Y + 1);

            if (canMoveTo(naechstePosition))
            {
                spielerAktiv.moveDown();
                schritte--;
            }
        }

        public void spielerLinkslaufen()
        {
            Point naechstePosition = new Point(
                spielerAktiv.getPosition().X - 1,
                spielerAktiv.getPosition().Y);

            if (canMoveTo(naechstePosition))
            {
                spielerAktiv.moveLeft();
                schritte--;
            }
        }

        public void spielerRechtslaufen()
        {
            Point naechstePosition = new Point(
                spielerAktiv.getPosition().X + 1,
                spielerAktiv.getPosition().Y);

            if (canMoveTo(naechstePosition))
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

        public void addFeldHindernis(Hindernis hindernis)
        {
            if (!isFeldBelegt(hindernis.getPosition()))
            {
                this.feldObjekte.Add(hindernis);
                this.feldHindernisse.Add(hindernis);
            }
        }
        public void addFeldItem(Item item)
        {
            if (!isFeldBelegt(item.getPosition()))
            {
                this.feldObjekte.Add(item);
                this.feldItems.Add(item);
            }
        }

        public void addSpieler(Spieler spieler)
        {
            if (!isFeldBelegt(spieler.getPosition()))
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
        }
        
        private void addFeldObjekt(Objekt objekt)
        {
            if (!isFeldBelegt(objekt.getPosition()))
                this.feldObjekte.Add(objekt);
        }

        private bool canMoveTo(Point position)
        {
            if (!isPosInFeld(position))
                return false;

            if (isFeldBelegt(position))
                return false;
            
            return true;
        }

        private bool isPosInFeld(Point position)
        {
            if (position.X < 0 || position.Y < 0)
                return false;
            if (position.X >= breiteFeld)
                return false;
            if (position.Y >= hoeheFeld)
                return false;

            return true;
        }

        private bool isFeldBelegt(Point feld)
        {
            foreach (Objekt objekt in feldObjekte)
            {
                if (objekt.getPosition() == feld)
                    return true;
            }

            return false;
        }

        private Objekt getObjektAufFeld(Point feld)
        {
            foreach (Objekt objekt in feldObjekte)
            {
                if (objekt.getPosition() == feld)
                    return objekt;
            }

            return null;
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
