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

            spiel = new Spiel(15, 7, 5);
            pictureBox1.BackgroundImage = Resource1.wasser;
            pbSpielende.Minimum = 0;
            pbSpielende.Value = 0;
            pbSpielende.Maximum = spiel.getSpielende();

            // Beispiel: Hindernis fest
            spiel.addFeldObjekt(new Hindernis("Mast", 1 * spiel.getBreite() / 4, spiel.getHoehe() / 2, false, 0, Resource1.mast));
            spiel.addFeldObjekt(new Hindernis("Mast", 2 * spiel.getBreite() / 4, spiel.getHoehe() / 2, false, 0, Resource1.mast));
            spiel.addFeldObjekt(new Hindernis("Mast", 3 * spiel.getBreite() / 4, spiel.getHoehe() / 2, false, 0, Resource1.mast));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));
            spiel.addFeldObjekt(new Hindernis("Zaun", spiel.getZufallFreiesFeld(), false, 0, Resource1.zaun));

            // Beispiel: Hindernis lose
            spiel.addFeldObjekt(new Hindernis("Anker", spiel.getZufallFreiesFeld(), true, 3, Resource1.anker));
            spiel.addFeldObjekt(new Hindernis("Truhe", spiel.getZufallFreiesFeld(), true, 1, Resource1.kiste));
            spiel.addFeldObjekt(new Hindernis("Truhe", spiel.getZufallFreiesFeld(), true, 1, Resource1.kiste));
            spiel.addFeldObjekt(new Hindernis("Truhe", spiel.getZufallFreiesFeld(), true, 1, Resource1.kiste));
            spiel.addFeldObjekt(new Hindernis("Truhe", spiel.getZufallFreiesFeld(), true, 1, Resource1.kiste));
            spiel.addFeldObjekt(new Hindernis("Truhe", spiel.getZufallFreiesFeld(), true, 1, Resource1.kiste));
            spiel.addFeldObjekt(new Hindernis("Truhe", spiel.getZufallFreiesFeld(), true, 1, Resource1.kiste));

            // Beispiel: Item
            spiel.addFeldObjekt(new Item("Paddel", spiel.getZufallFreiesFeld(), 10, Resource1.item));
            spiel.addFeldObjekt(new Item("Paddel", spiel.getZufallFreiesFeld(), 10, Resource1.item));
            spiel.addFeldObjekt(new Item("Paddel", spiel.getZufallFreiesFeld(), 10, Resource1.item));
            spiel.addFeldObjekt(new Item("Paddel", spiel.getZufallFreiesFeld(), 10, Resource1.item));
            spiel.addFeldObjekt(new Item("Seil", spiel.getZufallFreiesFeld(), 20, Resource1.item));
            spiel.addFeldObjekt(new Item("Fernrohr", spiel.getZufallFreiesFeld(), 25, Resource1.item));
            spiel.addFeldObjekt(new Item("Fernrohr", spiel.getZufallFreiesFeld(), 25, Resource1.item));
            spiel.addFeldObjekt(new Item("Steuer", spiel.getZufallFreiesFeld(), 15, Resource1.item));

            spiel.addSpieler(new Spieler(neuesSpielForm.getNameSpieler1(), new Point(-1, 1), Resource1.player1, neuesSpielForm.getFarbeSpieler1()));
            spiel.addSpieler(new Spieler(neuesSpielForm.getNameSpieler2(), new Point(-1, spiel.getHoehe()-2), Resource1.player2, neuesSpielForm.getFarbeSpieler2()));

            printToConsole("Neues Spiel gestartet");
            printToConsole("'" + neuesSpielForm.getNameSpieler1() + "' und '" + neuesSpielForm.getNameSpieler2() + "' spielen");

            gbSpieler1.Text = neuesSpielForm.getNameSpieler1();
            gbSpieler2.Text = neuesSpielForm.getNameSpieler2();

            spiel.startNewRound();
            updateLabels();
            enableButtons();
            setNewRoundButtons();
            zeichneFeld();
            pictureBox1.Show();
        }

        private void setNewRoundButtons()
        {
            btnWuerfeln.Enabled = false;
            btnSwitchPlayer.Enabled = true;
            btnSteuerLinks.Enabled = false;
            btnSteuerRechts.Enabled = false;
            btnSteuerLinks.BackColor = btnWuerfeln.BackColor;
            btnSteuerRechts.BackColor = btnWuerfeln.BackColor;

            if (spiel.getDarfWueferln())
            {
                btnWuerfeln.Enabled = true;
                btnWuerfeln.Select();
                btnSwitchPlayer.Enabled = false;

                if (spiel.getDarfSteuern())
                {
                    btnSteuerLinks.Enabled = true;
                    btnSteuerRechts.Enabled = true;
                    btnSteuerLinks.BackColor = Color.LightYellow;
                    btnSteuerRechts.BackColor = Color.LightYellow;
                }

                printToConsole(spiel.getSpielerAktivName() + " ist an der Reihe. Bitte würfeln oder Steuern.");
            }
        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            spiel.wuerfeln();
            updateLabels();
            setNewRoundButtons();
            printToConsole("Du hast eine " + spiel.getSchritte() + " gewürfelt. Mache deinen Zug.");
        }

        private void btnSwitchPlayer_Click(object sender, EventArgs e)
        {
            spiel.startNewRound();
            updateLabels();
            zeichneFeld();
            setNewRoundButtons();
            spielFortschritt();
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
                setNewRoundButtons();
            }
            else if (!spiel.getDarfWueferln())
            {
                btnSwitchPlayer.Select();
            }
        }

        private void updateLabels()
        {
            lblWuerfel.Text = spiel.getSchritte().ToString();
            lblSpieler.Text = spiel.getSpielerAktivName();
            lblSpieler.ForeColor = spiel.getSpielerAktivColor();
            lblPunkteSpieler1.Text = spiel.getSpieler1Punkte().ToString();
            lblPunkteSpieler2.Text = spiel.getSpieler2Punkte().ToString();

            lbInventarSpieler1.Items.Clear();
            foreach (string item in spiel.getSpieler1Inventar())
            {
                lbInventarSpieler1.Items.Add(item);
            }

            lbInventarSpieler2.Items.Clear();
            foreach (string item in spiel.getSpieler2Inventar())
            {
                lbInventarSpieler2.Items.Add(item);
            }


            List<string> consoleOutLines = spiel.getOutputLines();
            foreach (string line in consoleOutLines)
                printToConsole(line);
        }

        private void zeichneFeld()
        {
            int zellGroeße = 600 / spiel.getBreite();
            int randSpielfeld = 70;
            int randZelle = 25 - spiel.getBreite() * 2;
            if (randZelle < 0)
                randZelle = 0;

            Bitmap newImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(newImg);          
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush spieler1pinsel = new SolidBrush(spiel.getSpieler1Color());
            SolidBrush spieler2pinsel = new SolidBrush(spiel.getSpieler2Color());

            g.DrawImage(Resource1.Map002, 0, 0, pictureBox1.Width, pictureBox1.Height);

            for (int i = 0; i < spiel.getBreite(); i++)
            {
                for (int j = 0; j < spiel.getHoehe(); j++)
                    g.DrawRectangle(pen, randSpielfeld + zellGroeße * i, randSpielfeld + zellGroeße * j, zellGroeße, zellGroeße);
            }

            Bitmap objektBild;


            g.FillEllipse(spieler1pinsel, 
                randSpielfeld + (randZelle + 4) * 2 + zellGroeße * spiel.getSpieler1Pos().X,
                randSpielfeld + (randZelle + 4) * 2 + zellGroeße * spiel.getSpieler1Pos().Y,
                zellGroeße - (randZelle + 4) * 2 * 2, zellGroeße - (randZelle + 4) * 2 * 2);
            g.FillEllipse(spieler2pinsel,
                randSpielfeld + (randZelle + 4) * 2 + zellGroeße * spiel.getSpieler2Pos().X,
                randSpielfeld + (randZelle + 4) * 2 + zellGroeße * spiel.getSpieler2Pos().Y,
                zellGroeße - (randZelle + 4) * 2 * 2, zellGroeße - (randZelle + 4) * 2 * 2);

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
            setupNewGame();
            Leveleditor editor = new Leveleditor();
            editor.ShowDialog();

            if (editor.DialogResult != DialogResult.OK)
                return;
            Spieler tempSpieler1 = spiel.getSpieler1();
            Spieler tempSpieler2 = spiel.getSpieler2();
            spiel.setFeldObjekte(editor.getHindernisse());
            spiel.addFeldObjekt(tempSpieler1);
            spiel.addFeldObjekt(tempSpieler2);
            zeichneFeld();
          
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

        private void btnKippeHoch_Click(object sender, EventArgs e)
        {
            printToConsole(" >> STEUERBORD! " + spiel.getSpielerAktivName() + " schlägt das Steuer nach rechts zum Anschlag.");
            spiel.spielfeldKippen(new Point(0, -1));
            spiel.startNewRound();
            updateLabels();
            zeichneFeld();
            setNewRoundButtons();
        }

        private void btnKippeRunter_Click(object sender, EventArgs e)
        {
            printToConsole(" >> BACKBOARD! " + spiel.getSpielerAktivName() + " haut das Steuer komplett nach links rum.");
            spiel.spielfeldKippen(new Point(0, +1));
            spiel.startNewRound();
            updateLabels();
            zeichneFeld();
            setNewRoundButtons();
        }

        private void spielFortschritt()
        {
            pbSpielende.PerformStep();

            if (pbSpielende.Value == spiel.getSpielende())
            {
                String name = null;
                String punkte = null;

                if (spiel.getSpieler1Punkte() < spiel.getSpieler2Punkte())
                {
                    name = spiel.getSpieler2Name();
                    punkte = spiel.getSpieler2Punkte().ToString();
                }
                else if (spiel.getSpieler1Punkte() > spiel.getSpieler2Punkte())
                {
                    name = spiel.getSpieler1Name();
                    punkte = spiel.getSpieler1Punkte().ToString();
                }

                btnDown.Enabled = false;
                btnUp.Enabled = false;
                btnLeft.Enabled = false;
                btnRight.Enabled = false;
                btnSteuerLinks.Enabled = false;
                btnSteuerRechts.Enabled = false;
                btnSwitchPlayer.Enabled = false;
                btnWuerfeln.Enabled = false;
                lblSpieler.Text = "";

                string message = "Das Schiff ist in den Hafen eingelaufen.\n\n";

                if (name != null && punkte != null)
                    message += name + " hat mit " + punkte + " Punkten gewonnen und konnte sich als Kapitän durchsetzen!";
                else
                    message += "Unentschieden! Es konnte sich kein Pirat durchsetzen.";

                MessageBox.Show(message, "Spiel zu Ende", MessageBoxButtons.OK, MessageBoxIcon.Information);

                spiel = null;
            }
        }
    }
}
