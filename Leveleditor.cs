using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace grundspiel
{
    internal partial class Leveleditor : Form
    {
        private int[] groesse = { 7, 15 };
        private List<Objekt> hindernisse = new List<Objekt>();
        
        public Leveleditor()
        {

            InitializeComponent();
            zeichneBlancoFeld();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private int[] feldErmitteln(double x, double y)
        {
            int zeile = 0;
            int spalte = 0;

            x = 0 + (x - 70) * ((pictureBox1.Width) / (600));
            y = 0 + (y - 70) * ((pictureBox1.Height) / (7*40));

            zeile = (int) Math.Floor(y / 280 * groesse[0]);
            spalte = (int)Math.Floor(x / 600 * groesse[1]);

            int[] feld = new int[] { spalte, zeile };


            return feld;
        }

        

        private void btnErstellen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void kleinToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void großToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Leveleditor_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int[] klickPos = feldErmitteln(e.Location.X, e.Location.Y);
            if (klickPos[0] >= 0 && klickPos[0] < 15 && klickPos[1] >= 0 && klickPos[1] < 7)
            {
                Objekt hinzu = hindernisPlazieren(e.Location.X, e.Location.Y);

                hindernisse.Add(hinzu);
                zeichneBlancoFeld();
            }



        }

        private Objekt hindernisPlazieren(double x, double y)
        {
            Hindernis editor_hindernis;
            Item editor_item;
            int[] posFeld = feldErmitteln(x, y);


            if(rbMast.Checked == true)
            {
                editor_hindernis = new Hindernis("Mast", posFeld[0], posFeld[1], false, 0, Resource1.mast);
                return editor_hindernis;
            }

            if (rbZaun.Checked == true)
            {
                editor_hindernis = new Hindernis("Zaun", posFeld[0], posFeld[1], false, 0, Resource1.zaun);
                return editor_hindernis;
            }

            if (rbAnker.Checked == true)
            {
                editor_hindernis = new Hindernis("Anker", posFeld[0], posFeld[1], true, 3, Resource1.anker);
                return editor_hindernis;
            }

            if (rbTruhe.Checked == true)
            {
                editor_hindernis = new Hindernis("Truhe", posFeld[0], posFeld[1], true, 1, Resource1.kiste);
                return editor_hindernis;
            }

            if (rbPaddel.Checked == true)
            {
                editor_item = new Item("Paddel", posFeld[0], posFeld[1], 10, Resource1.item);
                return editor_item;
            }

            if (rbFernrohr.Checked == true)
            {
                editor_item = new Item("Fernrohr", posFeld[0], posFeld[1], 20, Resource1.item);
                return editor_item;
            }

            if (rbSteuer.Checked == true)
            {
                editor_item = new Item("Steuer", posFeld[0], posFeld[1], 15, Resource1.item);
                return editor_item;
            }

            return null;
        }

        private void zeichneBlancoFeld()
        {
            int breite = 15;
            int hoehe = 7;
            int zellGroeße = 600 / breite;
            int randSpielfeld = 70;
            int randZelle = 25 - breite * 2;
            if (randZelle < 0)
                randZelle = 0;

            Bitmap newImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(newImg);
            Pen pen = new Pen(Color.Black, 2);
            

            for (int i = 0; i < breite; i++)
            {
                for (int j = 0; j < hoehe; j++)
                    g.DrawRectangle(pen, randSpielfeld + zellGroeße * i, randSpielfeld + zellGroeße * j, zellGroeße, zellGroeße);
            }

            Bitmap objektBild;
            foreach (Objekt objekt in hindernisse)
            {
                objektBild = objekt.getBild();

                g.DrawImage(
                    objektBild,
                    randSpielfeld + randZelle + zellGroeße * objekt.getPosition().X,
                    randSpielfeld + randZelle + zellGroeße * objekt.getPosition().Y,
                    zellGroeße - randZelle * 2, zellGroeße - randZelle * 2);
            }

            pictureBox1.Image = newImg;
            pictureBox1.BackgroundImage = Resource1.Map002;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLeeren_Click(object sender, EventArgs e)
        {
            hindernisse.Clear();
            zeichneBlancoFeld();
        }

        public List<Objekt> getHindernisse()
        {
            return hindernisse;
        }
    }
}
