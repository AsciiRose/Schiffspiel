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
        private int schritte;

        public Spieler(string name, Point position)
            : base(name, position)
        {
            schritte = 0;
            inventar = new List<Item>();
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
    }
}
