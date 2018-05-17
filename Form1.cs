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
    public partial class Form1 : Form
    {
        Random r;
        Spieler spieler1, spieler2;

        Spieler spielerAktiv;

        int[,] feld;


        public Form1()
        {
            InitializeComponent();
            r = new Random();
            spieler1 = null;
            spieler2 = null;

            feld = new int[10, 5];

            renderFeld();
        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            spielerAktiv.setSchritte(r.Next(1, 7));
            updateLabels();
        }

        private void btnSwitchPlayer_Click(object sender, EventArgs e)
        {
            if (spielerAktiv == spieler1)
                changeActivePlayer(spieler2);
            else
                changeActivePlayer(spieler1);
            updateLabels();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            setupNewGame();
        }

        private void setupNewGame()
        {
            spieler1 = new Spieler("Spieler1", 4, 3);
            spieler2 = new Spieler("Spieler2", 5, 1);

            changeActivePlayer(spieler1);
            renderFeld();
        }

        private void changeActivePlayer(Spieler newActive)
        {
            spielerAktiv = newActive;
            spielerAktiv.resetSchritte();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            spielerAktiv.moveUp();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            spielerAktiv.moveRight();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            spielerAktiv.moveDown();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            spielerAktiv.moveLeft();
        }

        private bool canMoveTo(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < feld.GetLength(0) && y < feld.GetLength(1))
                if (!objectInField(x, y))
                    return true;

            return false;
        }


        private bool objectInField(int x, int y)
        {
            return false;
        }

        private bool move()
        {
            if (spielerAktiv.getSchritte() > 0)
            {
                spielerAktiv.schrittRunterzaehlen();
                lblWuerfel.Text = Convert.ToString(spielerAktiv.getSchritte());
                return true;
            }

            return false;
        }

        private void updateLabels()
        {
            lblWuerfel.Text = spielerAktiv.getSchritte().ToString();
            lblSpieler.Text = spielerAktiv.getBezeichnung();
        }


        private void renderFeld()
        {
            Bitmap newImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(newImg);
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush blue = new SolidBrush(Color.Blue);            
            Pen pen = new Pen(Color.Black, 2);

            for (int i = 0; i < feld.GetLength(0); i++)
            {
                for (int j = 0; j < feld.GetLength(1); j++)
                    g.DrawRectangle(pen, 10 + 80 * i, 10 + 80 * j, 80, 80);
            }           


            if (spieler1 != null && spieler2 != null)
            {
                g.FillEllipse(red, 10 + 80 * spieler1.getPosition().X, 10 + 80 * spieler1.getPosition().Y, 80, 80);
                g.FillEllipse(blue, 10 + 80 * spieler2.getPosition().X, 10 + 80 * spieler2.getPosition().Y, 80, 80);
            }

            pictureBox1.Image = newImg;
        }
    }
}
