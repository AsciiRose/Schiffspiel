﻿using System;
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
        private Spiel spiel;

        public Form1()
        {
            InitializeComponent();
            spiel = null;
        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            spiel.wuerfeln();
            updateLabels();
        }

        private void btnSwitchPlayer_Click(object sender, EventArgs e)
        {
            spiel.spielerWechseln();
            updateLabels();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            setupNewGame();
        }

        private void setupNewGame()
        {
            spiel = new Spiel(10, 5);
            renderFeld();
            updateLabels();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            spiel.spielerHochlaufen();
            renderFeld();
            updateLabels();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            spiel.spielerRechtslaufen();
            renderFeld();
            updateLabels();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            spiel.spielerRunterlaufen();
            renderFeld();
            updateLabels();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            spiel.spielerLinkslaufen();
            renderFeld();
            updateLabels();
        }

        private void updateLabels()
        {
            lblWuerfel.Text = spiel.getSpielerAktivSchritte().ToString();
            lblSpieler.Text = spiel.getSpielerAktivName();
        }

        // zu ueberarbeiten
        private void renderFeld()
        {
            Bitmap newImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(newImg);
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush blue = new SolidBrush(Color.Blue);            
            Pen pen = new Pen(Color.Black, 2);

            for (int i = 0; i < spiel.getBreite(); i++)
            {
                for (int j = 0; j < spiel.getHoehe(); j++)
                    g.DrawRectangle(pen, 10 + 80 * i, 10 + 80 * j, 80, 80);
            }   

            if (spiel != null)
            {
                g.FillEllipse(red, 10 + 80 * spiel.getSpieler1().getPosition().X, 10 + 80 * spiel.getSpieler1().getPosition().Y, 80, 80);
                g.FillEllipse(blue, 10 + 80 * spiel.getSpieler2().getPosition().X, 10 + 80 * spiel.getSpieler2().getPosition().Y, 80, 80);
            }

            pictureBox1.Image = newImg;
        }
    }
}
