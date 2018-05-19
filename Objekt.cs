using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace grundspiel
{
    class Objekt
    {
        private string bezeichnung;
        private Bitmap bild;
        private Point position;


        public Objekt(string bezeichnung, Point position)
        {
            this.bezeichnung = bezeichnung;
            this.position = position;
        }

        public string getBezeichnung()
        {
            return this.bezeichnung;
        }

        public Point getPosition()
        {
            return this.position;
        }

        public void moveRight()
        {
            position.X++;
        }

        public void moveDown()
        {
            position.Y++;
        }

        public void moveLeft()
        {
            position.X--;
        }

        public void moveUp()
        {
            position.Y--;
        }
    }
}

