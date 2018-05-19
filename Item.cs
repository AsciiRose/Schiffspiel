using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Item : Objekt
    {
        private int wert;

        public Item(string bezeichnung, int positionX, int positionY, int wert)
            : base(bezeichnung, new Point(positionX, positionY))
        {
            this.wert = wert;
        }
    }
}