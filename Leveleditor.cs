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
        int[] groesse;
        List<Hindernis> hindernisse = new List<Hindernis>();
        
        public Leveleditor(Hauptfenster aufrufer)
        {
            f1 = aufrufer;

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // feldErmitteln();

        }

        private int[] feldErmitteln(double x, double y)
        {
            int zeile = 0;
            int spalte = 0;

            zeile = (int) Math.Floor(x / pictureBox1.Width * groesse[1]);
            spalte = (int)Math.Floor(x / pictureBox1.Width * groesse[1]);

            int[] feld = new int[] { zeile, spalte };

            label3.Text = Convert.ToString(Math.Floor(x / pictureBox1.Width * groesse[1]));
            label4.Text = Convert.ToString(Math.Floor(y / pictureBox1.Height * groesse[0]));

            return feld;
        }

        private void renderFeldEditor(int hoehe, int breite)
        {
            Bitmap editorImg = new Bitmap(breite*30+1, hoehe*30+1);

            Graphics g = Graphics.FromImage(editorImg);

            Pen pen = new Pen(Color.Black, 1);

            for (int i = 0; i < breite; i++)
            {
                for (int j = 0; j < hoehe; j++)
                    g.DrawRectangle(pen,30 * i,30 * j, 30, 30);
            }

            pictureBox1.Size = editorImg.Size;
            pictureBox1.BackgroundImage = Resource1.Map002;
                
            pictureBox1.Image = editorImg;
        }

        private void btnErstellen_Click(object sender, EventArgs e)
        {
            
        }

        private void kleinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groesse = new int[] {5, 8};
            renderFeldEditor(5, 8);
        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groesse = new int[] { 7, 11 };
            renderFeldEditor(7, 11);
        }

        private void großToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groesse = new int[] { 10, 15 };
            renderFeldEditor(10, 15);
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

            if(radioButton1.Checked == true)
            {
                bezeichnung = "Kiste";
                beweglich = true;
            }

            if (radioButton2.Checked == true)
            {
                bezeichnung = "Wand";
                beweglich = false;
            }

            editor_hindernis = new Hindernis(bezeichnung, posFeld[1], posFeld[0], beweglich, 1, Resource1.hindernis);

            return editor_hindernis;
        }

        
    }
}
