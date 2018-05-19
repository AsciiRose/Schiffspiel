﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Hindernis : Objekt
    {
        private bool beweglich;

        public Hindernis(string bezeichnung, int positionX, int positionY, bool beweglich, Bitmap bild)
            : base(bezeichnung, new Point(positionX, positionY), bild)
        {
            this.beweglich = beweglich;
        }

    }
}
