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

        public Spieler(string name, Point position, Bitmap bild)
            : base(name, position, bild)
        {
            inventar = new List<Item>();
            punkte = 0;
        }

        public void addItem(Item item)
        {
            inventar.Add(item);
        }

        public int getPunkte()
        {
            return punkte;
        }

        public void addPunkte(int punkte)
        {
            this.punkte += punkte;
        }
    }
}
