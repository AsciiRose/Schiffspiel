﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Item : Objekt
    {
        private int wert;

        public Item(string bezeichnung, int positionX, int positionY, int wert, Bitmap bild)
            : base(bezeichnung, new Point(positionX, positionY), bild)
        {
            this.wert = wert;
        }

        public Item(string bezeichnung, Point position, int wert, Bitmap bild)
            : base(bezeichnung, position, bild)
        {
            this.wert = wert;
        }

        public int getWert()
        {
            return wert;
        }
    }
}