using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grundspiel
{
    class Hindernis : Objekt
    {
        private bool beweglich;

        public Hindernis(string bezeichnung, int positionX, int positionY, bool beweglich)
            : base(bezeichnung, positionX, positionY)
        {
            this.beweglich = beweglich;
        }

    }
}
