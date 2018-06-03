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
    public partial class Leveleditor : Form
    {
        private Hauptfenster f1;
        int[] groesse = { 7, 15 };
        List<Hindernis> hindernisse = new List<Hindernis>();
        
        public Leveleditor(Hauptfenster aufrufer)
        {
            f1 = aufrufer;

            InitializeComponent();
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

            int[] feld = new int[] { zeile, spalte };

            label3.Text = Convert.ToString(Math.Floor(x / 600 * groesse[1]));
            label4.Text = Convert.ToString(Math.Floor(y / 280 * groesse[0]));

            return feld;
        }

        

        private void btnErstellen_Click(object sender, EventArgs e)
        {
            zeichneBlancoFeld();
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
            Hindernis hinzu = hindernisPlazieren(e.Location.X, e.Location.Y);

            hindernisse.Add(hinzu);

            
        }

        private Hindernis hindernisPlazieren(double x, double y)
        {
            Hindernis editor_hindernis;
            int[] posFeld = feldErmitteln(x, y);

            string bezeichnung = "";
            bool beweglich = true;

            if(rbMast.Checked == true)
            {
                bezeichnung = "Kiste";
                beweglich = true;
            }

            if (rbZaun.Checked == true)
            {
                bezeichnung = "Wand";
                beweglich = false;
            }

            editor_hindernis = new Hindernis(bezeichnung, posFeld[1], posFeld[0], beweglich, 1, Resource1.hindernis);

            return editor_hindernis;
        }

        private void zeichneBlancoFeld()
        {
            int breite = 15;
            int hoehe = 7;
            int zellGroeße = 600 / breite;
            int randSpielfeld = 70;
            

            Bitmap newImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(newImg);
            Pen pen = new Pen(Color.Black, 2);
            

            for (int i = 0; i < breite; i++)
            {
                for (int j = 0; j < hoehe; j++)
                    g.DrawRectangle(pen, randSpielfeld + zellGroeße * i, randSpielfeld + zellGroeße * j, zellGroeße, zellGroeße);
            }

           
            

            pictureBox1.Image = newImg;
            pictureBox1.BackgroundImage = Resource1.Map002;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
