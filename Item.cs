using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Item : Objekt
    {
        private int wert;

        public Item(string bezeichnung, int positionX, int positionY, int wert)
            : base(bezeichnung, positionX, positionY)
        {
            this.wert = wert;
        }
    }
}
