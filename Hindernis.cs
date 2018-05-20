using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Hindernis : Objekt
    {
        private bool beweglich;
        private int gewicht;

        public Hindernis(string bezeichnung, int positionX, int positionY, bool beweglich, int gewicht, Bitmap bild)
            : base(bezeichnung, new Point(positionX, positionY), bild)
        {
            this.beweglich = beweglich;
            this.gewicht = gewicht;
        }

        public bool isBeweglich()
        {
            return beweglich;
        }

        public int getGewicht()
        {
            return gewicht;
        }
    }
}
