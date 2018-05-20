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
    public partial class Hauptfenster : Form
    {
        private Spiel spiel;

        public Hauptfenster()
        {
            InitializeComponent();
            spiel = null;
        }
        
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            setupNewGame();
        }

        private void setupNewGame()
        {
            if (spiel != null)
            {
                DialogResult resultNeuesSpiel = MessageBox.Show("Aktuell läuft noch ein Spiel. Willst du das aktuelle Spiel verwerfen und ein neues beginnen?", "Neues Spiel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if(resultNeuesSpiel != DialogResult.Yes)
                    return;
            }

            spiel = new Spiel(10, 5);

            // Beispiel: Hindernis
            spiel.addFeldObjekt(new Hindernis("Mast", 4, 2, true, 1, Resource1.hindernis));

            // Beispiel: Item
            spiel.addFeldObjekt(new Item("Paddel", 6, 3, 10, Resource1.item));            

            // Beispiel: Spieler
            spiel.addSpieler(new Spieler("Spieler1", spiel.getZufallFreiesFeld(), Resource1.player1));
            spiel.addSpieler(new Spieler("Spieler2", spiel.getZufallFreiesFeld(), Resource1.player2));

            spiel.startNewRound();
            updateLabels();
            enableButtons();
            setNewRoundButtons();
            renderFeld();
        }

        private void setNewRoundButtons()
        {
            if(spiel.getDarfWueferln())
            {
                btnWuerfeln.Enabled = true;
                btnWuerfeln.Select();
                btnSwitchPlayer.Enabled = false;
            }
            else
            {
                btnWuerfeln.Enabled = false;
                btnSwitchPlayer.Enabled = true;
            }
        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            spiel.wuerfeln();
            updateLabels();
            setNewRoundButtons();
        }

        private void btnSwitchPlayer_Click(object sender, EventArgs e)
        {
            spiel.startNewRound();
            updateLabels();
            setNewRoundButtons();
        }

        private void enableButtons()
        {
            btnDown.Enabled = true;
            btnUp.Enabled = true;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
            btnWuerfeln.Enabled = true;
            btnSwitchPlayer.Enabled = true;
            btnEditor.Enabled = true;
            editorToolStripMenuItem.Enabled = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            spielerHochlaufen();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            spielerRunterlaufen();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            spielerLinkslaufen();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            spielerRechtslaufen();
        }

        private void Hauptfenster_KeyDown(object sender, KeyEventArgs e)
        {
            if (spiel != null)
            {
                if (e.KeyCode == Keys.W)
                    spielerHochlaufen();
                if (e.KeyCode == Keys.S)
                    spielerRunterlaufen();
                if (e.KeyCode == Keys.A)
                    spielerLinkslaufen();
                if (e.KeyCode == Keys.D)
                    spielerRechtslaufen();
            }
        }

        private void spielerHochlaufen()
        {
            Point richtungsVektor = new Point(0, -1);
            spielerLaufen(richtungsVektor);
        }

        private void spielerRunterlaufen()
        {
            Point richtungsVektor = new Point(0, 1);
            spielerLaufen(richtungsVektor);
        }

        private void spielerLinkslaufen()
        {
            Point richtungsVektor = new Point(-1, 0);
            spielerLaufen(richtungsVektor);
        }

        private void spielerRechtslaufen()
        {
            Point richtungsVektor = new Point(1, 0);
            spielerLaufen(richtungsVektor);
        }

        private void spielerLaufen(Point richtungsVektor)
        {
            if (spiel.getSchritte() > 0)
            {
                spiel.spielerLaufen(richtungsVektor);
                renderFeld();
                updateLabels();
            }
            else
                btnSwitchPlayer.Select();
        }

        private void updateLabels()
        {
            lblWuerfel.Text = spiel.getSchritte().ToString();
            lblSpieler.Text = spiel.getSpielerAktivName();
        }

        private void renderFeld()
        {
            int zellGroeße = 80;
            int randSpielfeld = 10;

            Bitmap newImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(newImg);          
            Pen pen = new Pen(Color.Black, 2);

            for (int i = 0; i < spiel.getBreite(); i++)
            {
                for (int j = 0; j < spiel.getHoehe(); j++)
                    g.DrawRectangle(pen, randSpielfeld + zellGroeße * i, randSpielfeld + zellGroeße * j, zellGroeße, zellGroeße);
            }

            Bitmap objektBild;

            foreach (Objekt objekt in spiel.getFeldObjekte())
            {
                objektBild = objekt.getBild();

                g.DrawImage(
                    objektBild,
                    randSpielfeld + zellGroeße * objekt.getPosition().X + (zellGroeße - objektBild.Width)/2,
                    randSpielfeld + zellGroeße * objekt.getPosition().Y + (zellGroeße - objektBild.Height)/2);
            }

            pictureBox1.Image = newImg;
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            startEditor();
        }

        private void startEditor()
        {
            Leveleditor editor = new Leveleditor(this);
            editor.ShowDialog();
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setupNewGame();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startEditor();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hauptfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (spiel != null)
            {
                DialogResult resultBeenden = MessageBox.Show("Aktuell läuft noch ein Spiel. Willst du das Spiel wirklich beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (resultBeenden != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
    }
}
