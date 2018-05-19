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
            renderFeld();
            updateLabels();
            enableButtons();
            setNewRoundButtons();
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

        private void spielerHochlaufen()
        {
            if (spiel.getSchritte() > 0)
            {
                spiel.spielerHochlaufen();
                renderFeld();
                updateLabels();
            }
            else
                btnSwitchPlayer.Select();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            spielerRechtslaufen();
        }

        private void spielerRechtslaufen()
        {
            if (spiel.getSchritte() > 0)
            {
                spiel.spielerRechtslaufen();
                renderFeld();
                updateLabels();
            }
            else
                btnSwitchPlayer.Select();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            spielerRunterlaufen();
        }

        private void spielerRunterlaufen()
        {
            if (spiel.getSchritte() > 0)
            {
                spiel.spielerRunterlaufen();
                renderFeld();
                updateLabels();
            }
            else
                btnSwitchPlayer.Select();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            spielerLinkslaufen();
        }

        private void spielerLinkslaufen()
        {
            if (spiel.getSchritte() > 0)
            {
                spiel.spielerLinkslaufen();
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
