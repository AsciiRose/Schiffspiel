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

            NeuesSpiel neuesSpielForm = new NeuesSpiel();
            neuesSpielForm.ShowDialog();

            if (neuesSpielForm.DialogResult != DialogResult.OK)
                return;

            spiel = new Spiel(10, 5);
            pictureBox1.BackgroundImage = Resource1.Map002;

            // Beispiel: Hindernis
            spiel.addFeldObjekt(new Hindernis("Mast", 4, 2, false, 0, Resource1.hindernis));
            spiel.addFeldObjekt(new Hindernis("Anker", 2, 4, true, 3, Resource1.hindernis));
            spiel.addFeldObjekt(new Hindernis("Truhe", 1, 1, true, 1, Resource1.hindernis));
            spiel.addFeldObjekt(new Hindernis("Truhe", 5, 3, true, 1, Resource1.hindernis));

            // Beispiel: Item
            spiel.addFeldObjekt(new Item("Paddel", 6, 3, 10, Resource1.item));
            spiel.addFeldObjekt(new Item("Paddel", 3, 1, 10, Resource1.item));
            spiel.addFeldObjekt(new Item("Fernrohr", 2, 1, 20, Resource1.item));
            spiel.addFeldObjekt(new Item("Steuer", 7, 0, 100, Resource1.item));

            spiel.addSpieler(new Spieler(neuesSpielForm.getNameSpieler1(), new Point(-1, 0), Resource1.player1));
            spiel.addSpieler(new Spieler(neuesSpielForm.getNameSpieler2(), new Point(-1, 4), Resource1.player2));

            printToConsole("Neues Spiel gestartet");
            printToConsole("'" + neuesSpielForm.getNameSpieler1() + "' und '" + neuesSpielForm.getNameSpieler2() + "' spielen");

            gbSpieler1.Text = neuesSpielForm.getNameSpieler1();
            gbSpieler2.Text = neuesSpielForm.getNameSpieler2();

            spiel.startNewRound();
            updateLabels();
            enableButtons();
            setNewRoundButtons();
            zeichneFeld();
        }

        private void setNewRoundButtons()
        {
            if(spiel.getDarfWueferln())
            {
                btnWuerfeln.Enabled = true;
                btnWuerfeln.Select();
                btnSwitchPlayer.Enabled = false;
                printToConsole(spiel.getSpielerAktivName() + " ist an der Reihe");
                printToConsole("Bitte würfeln");
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
            printToConsole("Du hast eine " + spiel.getSchritte() + " gewürfelt");
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
                zeichneFeld();
                updateLabels();
            }
            else if (!spiel.getDarfWueferln())
            {
                btnSwitchPlayer.Select();
                printToConsole(spiel.getSpielerAktivName() + " hat keine Schritte mehr, bitte an den nächsten Spieler übergeben.");
            }
        }

        private void updateLabels()
        {
            lblWuerfel.Text = spiel.getSchritte().ToString();
            lblSpieler.Text = spiel.getSpielerAktivName();
            lblPunkteSpieler1.Text = spiel.getSpieler1Punkte().ToString();
            lblPunkteSpieler2.Text = spiel.getSpieler2Punkte().ToString();
            List<string> consoleOutLines = spiel.getOutputLines();
            foreach (string line in consoleOutLines)
                printToConsole(line);
        }

        private void zeichneFeld()
        {
            int zellGroeße = 60;
            int randSpielfeld = 70;
            int randZelle = 7;

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
                    randSpielfeld + randZelle + zellGroeße * objekt.getPosition().X,
                    randSpielfeld + randZelle + zellGroeße * objekt.getPosition().Y,
                    zellGroeße - randZelle * 2, zellGroeße - randZelle * 2);
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

        private void Hauptfenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (spiel != null)
            {
                DialogResult resultBeenden = MessageBox.Show("Aktuell läuft noch ein Spiel. Willst du das Spiel wirklich beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (resultBeenden != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void printToConsole(String message)
        {
            string output = "[" + DateTime.Now.ToLongTimeString() + "] " + message + "\n";
            tbConsole.AppendText(output);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spielBeenden();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            spielBeenden();
        }

        private void spielBeenden()
        {
            this.Close();
        }
    }
}
