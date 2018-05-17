using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Spieler : Objekt
    {
        private List<Objekt> inventar;
        private int schritte;

        public Spieler(string name, int positionX, int positionY)
            : base(name, positionX, positionY)
        {
            schritte = 0;
            inventar = new List<Objekt>();            
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
