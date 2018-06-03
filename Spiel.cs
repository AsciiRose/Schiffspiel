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
        private int countDownWelle;
        private int spielende;
        private int durationWelle;
        private bool darfWuerfeln;
        private bool darfSteuern;
        private List<Objekt> feldObjekte;
        private List<string> output;

        public Spiel(int breite, int hoehe, int runden)
        {
            this.breiteFeld = breite;
            this.hoeheFeld = hoehe;
            feldObjekte = new List<Objekt>();
            output = new List<string>();

            rand = new Random();
            spielende = 2 * runden;

            countDownWelle = rand.Next(1, 1+ spielende/2);
            durationWelle = rand.Next(0, 2+ spielende/8);
            spielerAktiv = null;
        }

        public void startNewRound()
        {
            schritte = 0;
            darfWuerfeln = true;
            spielerAktivWechseln();
            darfSteuern = spielerAktiv.hatEinSteuer();

            if(countDownWelle == 0)
            {
                output.Add(" >> Das Schiff fährt auf die Welle auf. FESTHALTEN!");
                spielfeldKippen(new Point(-1, 0));
            }
            else if (countDownWelle == 0 - durationWelle)
            {
                spielfeldKippen(new Point(1, 0));
                countDownWelle = rand.Next(1, 1+ spielende / 4);
                durationWelle = rand.Next(0, 2+ spielende / 16);
                output.Add(" >> Das Schiff fährt von der Welle ab. Geschafft!");
            }
            else if (countDownWelle == 3)
            {
                output.Add("Die See wird unruhig...");
            }
            else if (countDownWelle == 2)
            {
                output.Add("Eine große Welle ist am Horizont zu sehen!");
            }

            countDownWelle--;
        }

        public int getBreite()
        {
            return breiteFeld;
        }

        public int getSpielende()
        {
            return spielende;
        }
        public String getSpieler1Name()
        {
            return spieler1.getBezeichnung();
        }

        public String getSpieler2Name()
        {
            return spieler2.getBezeichnung();
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

        public Color getSpielerAktivColor()
        {
            return spielerAktiv.getFarbe();
        }

        public Color getSpieler1Color()
        {
            return spieler1.getFarbe();
        }

        public Color getSpieler2Color()
        {
            return spieler2.getFarbe();
        }

        public int getSpieler1Punkte()
        {
            return spieler1.getPunkte();
        }

        public int getSpieler2Punkte()
        {
            return spieler2.getPunkte();
        }

        public List<string> getSpieler1Inventar()
        {
            return spieler1.getInventarListe();
        }

        public List<string> getSpieler2Inventar()
        {
            return spieler2.getInventarListe();
        }

        public Point getSpieler1Pos()
        {
            return spieler1.getPosition();
        }

        public Point getSpieler2Pos()
        {
            return spieler2.getPosition();
        }
        
        public void spielerLaufen(Point richtungsVektor)
        {
            Point position = new Point(spielerAktiv.getPosition().X, spielerAktiv.getPosition().Y);
            position.Offset(richtungsVektor);

            if (!isPosInFeld(position))
                return;

            if (isFeldBelegt(position))
            {
                Objekt objekt = getObjektAufFeld(position);

                if (objekt.GetType() == typeof(Item))
                {
                    Item item = (Item)objekt;

                    sammleItem(spielerAktiv, item);
                    bewegeSpielerAktiv(richtungsVektor);
                }

                if (objekt.GetType() == typeof(Hindernis))
                {
                    Hindernis hindernis = (Hindernis)objekt;

                    if (hindernis.isBeweglich())
                        hindernisVerschieben(richtungsVektor, hindernis);
                }

                if (objekt.GetType() == typeof(Spieler))
                {
                    starteDuell();
                }
            }
            else
                bewegeSpielerAktiv(richtungsVektor);
        }

        public void spielfeldKippen(Point richtungsVektor)
        {
            bool gerutscht;
            bool naechstePosInFeld;
            bool naechstePosFrei;
            Item itemGesammeltSpieler1;
            Item itemGesammeltSpieler2;




            do
            {
                gerutscht = false;
                itemGesammeltSpieler1 = null;
                itemGesammeltSpieler2 = null;

                foreach (Objekt objekt in feldObjekte)
                {
                    Point position = new Point(objekt.getPosition().X, objekt.getPosition().Y);
                    position.Offset(richtungsVektor);
                    naechstePosInFeld = isPosInFeld(position);
                    naechstePosFrei = !isFeldBelegt(position);

                    if (objekt.GetType() == typeof(Hindernis))
                    {
                        Hindernis hindernis = (Hindernis)objekt;

                        if (hindernis.isBeweglich() && naechstePosFrei && naechstePosInFeld)
                        {
                            objekt.verschiebeUm(richtungsVektor);
                            gerutscht = true;
                        }
                    }

                    if (objekt.GetType() == typeof(Item))
                    {
                        if (naechstePosFrei && naechstePosInFeld)
                        {
                            objekt.verschiebeUm(richtungsVektor);
                            gerutscht = true;
                        }
                    }

                    if (objekt.GetType() == typeof(Spieler))
                    {
                        if (!naechstePosFrei)
                        {
                            if (getObjektAufFeld(position).GetType() == typeof(Item))
                            {
                                if (objekt.Equals(spieler1))
                                    itemGesammeltSpieler1 = (Item)getObjektAufFeld(position);
                                else if (objekt.Equals(spieler2))
                                    itemGesammeltSpieler2 = (Item)getObjektAufFeld(position);

                                objekt.verschiebeUm(richtungsVektor);
                                gerutscht = true;
                            }
                            else if (getObjektAufFeld(position).GetType() == typeof(Spieler))
                            {
                                starteDuell();
                            }
                        }
                        else if(naechstePosInFeld)
                        {
                            objekt.verschiebeUm(richtungsVektor);
                            gerutscht = true;
                        }
                    }
                }

                if (itemGesammeltSpieler1 != null)
                    sammleItem(spieler1, itemGesammeltSpieler1);

                if (itemGesammeltSpieler2 != null)
                    sammleItem(spieler2, itemGesammeltSpieler2);

            } while (gerutscht);
        }

        private void hindernisVerschieben(Point richtungsVektor, Hindernis hindernis)
        {
            Point hindernisPosition = new Point(hindernis.getPosition().X, hindernis.getPosition().Y);
            hindernisPosition.Offset(richtungsVektor);

            if (canMoveTo(hindernisPosition))
            {
                hindernis.verschiebeUm(richtungsVektor);
                bewegeSpielerAktiv(richtungsVektor);
            }
            else if (!isPosInFeld(hindernisPosition))
            {
                hindernisueberBoardWerfen(richtungsVektor, hindernis);
            }
        }

        private void hindernisueberBoardWerfen(Point richtungsVektor, Hindernis hindernis)
        {
            int gewicht = hindernis.getGewicht();
            int punkte = gewicht * 5;

            if (schritte - gewicht > 0)
            {
                schritte -= gewicht;
                feldObjekte.Remove(hindernis);
                bewegeSpielerAktiv(richtungsVektor);
                spielerAktiv.addPunkte(punkte);
                output.Add(spielerAktiv.getBezeichnung() + " nimmt alle Kraft zusammen, wirft " + hindernis.getBezeichnung() + " über Board und erhält " + punkte + " Punkte.");
            }
            else
                output.Add(hindernis.getBezeichnung() + " ist zu schwer, um ihn über Board zu werden. Dir fehlen " + (gewicht - schritte + 1) + " Bewegungspunkte.");
        }

        private void sammleItem(Spieler spieler, Item item)
        {
            spieler.addItem(item);
            feldObjekte.Remove(item);
            output.Add(spieler.getBezeichnung() + " hat ein " + item.getBezeichnung() + " gesammelt und erhält " + item.getWert() + " Punkte.");
        }

        private void bewegeSpielerAktiv(Point richtungsVektor)
        {
            spielerAktiv.verschiebeUm(richtungsVektor);
            schritte--;
        }

        private void starteDuell()
        {
            // TODO: Duell zwischen Spielern um Ruhm und Ehre. (Und um Items)
            output.Add(spielerAktiv.getBezeichnung() + " ist wohl auf Krawall gebürstet und möchte sich duellieren.");
            Spieler sieger;
            Spieler verlierer;
            if (rand.Next(2) == 0)
            {
                sieger = spieler1;
                verlierer = spieler2;
            }
            else
            {
                sieger = spieler2;
                verlierer = spieler1;
            }

            Item trophy = verlierer.entferneZufälligesItemAusInventar(rand);

            if (trophy != null)
            {
                output.Add(sieger.getBezeichnung() + " gewinnt das Duell und erobert ein " + trophy.getBezeichnung() + " von " + verlierer.getBezeichnung());
                sieger.addItem(trophy);
            }
            else
            {
                output.Add(sieger.getBezeichnung() + " gewinnt das Duell, aber " + verlierer.getBezeichnung() + " hat nur Sand in den Taschen...");
            }
            startNewRound();
        }

        public Point getZufallFreiesFeld()
        {
            Point position = new Point();

            do
            {
                position.X = rand.Next(1, breiteFeld);
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

        public bool getDarfSteuern()
        {
            return darfSteuern;
        }

        public List<Objekt> getFeldObjekte()
        {
            return feldObjekte;
        }

        public void setFeldObjekte(List<Objekt> objListe)
        {
            feldObjekte = objListe;
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
        
        public void addFeldObjekt(Objekt objekt)
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

            else if (spielerAktiv == spieler1)
                spielerAktiv = spieler2;
            else
                spielerAktiv = spieler1;
        }

        public List<string> getOutputLines()
        {
            List<String> returnList = output;
            output = new List<string>();
            return returnList;
        }
    }
}
