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

        public Spieler(string name, Point position)
            : base(name, position)
        {
            inventar = new List<Item>();
        }
        
    }
}
