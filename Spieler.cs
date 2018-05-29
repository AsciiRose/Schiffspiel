using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Spieler : Objekt
    {
        private List<Item> inventar;
        private int punkte;
        private Color farbe;

        public Spieler(string name, Point position, Bitmap bild, Color farbe)
            : base(name, position, bild)
        {
            inventar = new List<Item>();
            punkte = 0;
            this.farbe = farbe;
        }

        public void addItem(Item item)
        {
            inventar.Add(item);
            punkte += item.getWert();
        }

        public Item entferneZufälligesItemAusInventar(Random r)
        {
            Item item = inventar.ElementAt(r.Next(0, inventar.Count));
            inventar.Remove(item);
            punkte -= item.getWert();
            return item;
        }

        public int getPunkte()
        {
            return punkte;
        }

        public void addPunkte(int punkte)
        {
            this.punkte += punkte;
        }

        public Color getFarbe()
        {
            return farbe;
        }

        public bool hatEinSteuer()
        {
            foreach (Item item in inventar)
                if (item.getBezeichnung() == "Steuer")
                    return true;

            return false;
        }
    }
}
