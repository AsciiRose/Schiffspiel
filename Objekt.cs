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


        public Objekt(string bezeichnung, Point position, Bitmap bild)
        {
            this.bezeichnung = bezeichnung;
            this.position = position;
            this.bild = bild;
            this.bild.MakeTransparent(Color.White);
        }

        public string getBezeichnung()
        {
            return this.bezeichnung;
        }

        public Point getPosition()
        {
            return this.position;
        }

        public void verschiebeUm(Point offset)
        {
            position.Offset(offset);
        }

        public Bitmap getBild()
        {
            return bild;
        }
    }
}

