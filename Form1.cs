using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Schiffspiel
{
    public partial class Startseite : Form
    {
        //Array für Levelbilder
        Image[] images = new Image[3];
        
        //Steuerelemente Anleitung
        //Button
        Button btnEnde = new Button();
        Button btnZurueck = new Button();
        //Panel
        Panel pAnteitungLeft = new Panel();
        Panel pAnteitungBottom = new Panel();
        //Label
        Label lbAnleitung = new Label();
        Label lbAnleitungTitel = new Label();
        //GroupBox
        GroupBox gBAnleitung = new GroupBox();

        public Startseite()
        {
            InitializeComponent();

            //Levelbilder füllen
            setImages(images);

            //Einstellungen der Steuerelemente setzen
            setAnleitungGroupBox();

            //GroupBox gBAnleitung nicht sichtbar
            gBAnleitung.Visible = false;
        }

        private void setImages(Image[] images)
        {
            //Setzen der Bilder
            images[0] = Properties.Resources.Kreuzfahrtschiff;
            images[1] = Properties.Resources.Piratenschiff;
            images[2] = Properties.Resources.Titanic;
        }

        private void WMPBackgroundVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //Abfrage: Ist Video beendet?
            if (e.newState == 8)
            {
                //Erstellen einer Dauerschleife für das Video
                WMPStartVideo.settings.setMode("loop", true);
            }
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            //Programm beenden
            Close();
        }

        private void pBZurueck_Click(object sender, EventArgs e)
        {
            //Durchlaufen der Bilder (Rückwärts)
            if (pBLevel.Image == images[0])
            {
                pBLevel.Image = images[2];
            }
            else if (pBLevel.Image == images[1])
            {
                pBLevel.Image = images[0];
            }
            else
            {
                pBLevel.Image = images[1];
            }
        }

        private void pBVor_Click(object sender, EventArgs e)
        {
            //Durchlaufen der Bilder (Vorwärts)
            if (pBLevel.Image == images[0])
            {
                pBLevel.Image = images[1];
            }
            else if (pBLevel.Image == images[1])
            {
                pBLevel.Image = images[2];
            }
            else
            {
                pBLevel.Image = images[0];
            }
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            //Abfrage, ob Levelauswahl sichtbar ist
            //Bei 556 nicht sichtbar
            if (pMenue.Height == 556)
            {
                //Höhe setzen
                pMenue.Height = 224;
            }
            else
            {
                //Höhe setzen
                pMenue.Height = 556;
            }
        }

        private void setAnleitungGroupBox()
        {
            //Angaben Button btnEnde
            btnEnde.Name = "btnEnde";
            btnEnde.Text = "Beenden";
            btnEnde.Height = 44;
            btnEnde.Width = 176;
            btnEnde.Font = new Font("Old English Text MT", 22, FontStyle.Bold);
            btnEnde.BackColor = Color.DimGray;
            btnEnde.ForeColor = Color.White;
            btnEnde.Location = new Point(576, 10);

            //Angaben Button btnZurueck
            btnZurueck.Name = "btnZurueck";
            btnZurueck.Text = "Zurück";
            btnZurueck.Height = 44;
            btnZurueck.Width = 176;
            btnZurueck.Font = new Font("Old English Text MT", 22, FontStyle.Bold);
            btnZurueck.BackColor = ColorTranslator.FromHtml("#7D2E20");
            btnZurueck.ForeColor = Color.White;
            btnZurueck.Location = new Point(310, 10);

            //Angaben Panel pAnteitungLeft
            pAnteitungLeft.Name = "pAnteitungLeft";
            pAnteitungLeft.Width = 50;
            pAnteitungLeft.Dock = DockStyle.Left;

            //Angaben Panel pAnteitungBottom
            pAnteitungBottom.Name = "pAnteitungBottom";
            pAnteitungBottom.Height = 64;
            pAnteitungBottom.Dock = DockStyle.Bottom;

            //Angaben Label lbAnleitung
            lbAnleitung.Name = "lbAnleitung";
            lbAnleitung.Text =  "\nZeile1   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile2   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile3   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile4   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile5   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile6   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile7   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile8   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile9   AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile10 AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile11 AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                                "\nZeile12 AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            lbAnleitung.AutoSize = true;
            lbAnleitung.Font = new Font("Old English Text MT", 20, FontStyle.Regular);
            lbAnleitung.ForeColor = Color.White;
            lbAnleitung.Dock = DockStyle.Fill;

            //Angaben Label lbAnleitungTitel
            lbAnleitungTitel.Name = "lbAnleitungTitel";
            lbAnleitungTitel.Text = "Anleitung";
            lbAnleitungTitel.AutoSize = true;
            lbAnleitungTitel.Font = new Font("Old English Text MT", 30, FontStyle.Bold);
            lbAnleitungTitel.ForeColor = Color.White;
            lbAnleitungTitel.Dock = DockStyle.Top;

            //Angaben GroupBox gBAnleitung
            gBAnleitung.Name = "gBAnleitung";
            gBAnleitung.Height = 565;
            gBAnleitung.Width = 1079;
            gBAnleitung.Location = new Point(50, 50);

            //Hinzufügen der Steuerelemente in die GroupBox gBAnleitung
            //Panel
            gBAnleitung.Controls.Add(pAnteitungLeft);
            gBAnleitung.Controls.Add(pAnteitungBottom);
            //Label
            gBAnleitung.Controls.Add(lbAnleitung);
            gBAnleitung.Controls.Add(lbAnleitungTitel);

            //Hinzufügen der Steuerelemente in das Panel pAnteitungBottom
            pAnteitungBottom.Controls.Add(btnZurueck);
            pAnteitungBottom.Controls.Add(btnEnde);

            //Hinzufügen der GroupBox gBAnleitung in die Form
            Controls.Add(gBAnleitung);

            //Einstellungen für Layout
            lbAnleitung.BringToFront();
            pAnteitungLeft.BringToFront();
            gBAnleitung.BringToFront();

            //Button Click Events
            btnEnde.Click += btnEnde_Click;
            btnZurueck.Click += btnZurueck_Click;
        }

        private void btnAnleitung_Click(object sender, EventArgs e)
        {
            WMPStartVideo.Dock = DockStyle.Fill;
            this.StartPosition = FormStartPosition.CenterScreen;
            
            this.Size = new System.Drawing.Size(1179, 665);

            gBMenue.Visible = false;
            gBAnleitung.Visible = true;

            setAnleitungGroupBox();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Hauptprogramm starten
        }

        private void pBLevel_Click(object sender, EventArgs e)
        {
            //Hauptprogramm starten
        }

        private void btnLeveleditor_Click(object sender, EventArgs e)
        {
            //Leveleditor starten
        }

        private void Startseite_Load(object sender, EventArgs e)
        {
            pMenue.Height = 556;
        }

        private void btnEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            WMPStartVideo.Dock = DockStyle.Right;
            this.StartPosition = FormStartPosition.CenterScreen;

            gBMenue.Visible = true;
            gBAnleitung.Visible = false;

            this.Size = new System.Drawing.Size(1382, 665);
        }
    }
}