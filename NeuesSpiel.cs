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
    public partial class NeuesSpiel : Form
    {
        private String defaultNameSpieler1;
        private String defaultNameSpieler2;

        private Color defaultColorSpieler1;
        private Color defaultColorSpieler2;

        public NeuesSpiel()
        {
            InitializeComponent();

            defaultNameSpieler1 = getNameSpieler1();
            defaultNameSpieler2 = getNameSpieler2();

            defaultColorSpieler1 = getFarbeSpieler1();
            defaultColorSpieler2 = getFarbeSpieler2();
        }

        public String getNameSpieler1()
        {
            return tbNameSpieler1.Text;
        }

        public String getNameSpieler2()
        {
            return tbNameSpieler2.Text;
        }

        public Color getFarbeSpieler1()
        {
            return pnlFarbeSpieler1.BackColor;
        }

        public Color getFarbeSpieler2()
        {
            return pnlFarbeSpieler2.BackColor;
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (getNameSpieler1() == getNameSpieler1())
            {
                MessageBox.Show("Die Namen dürfen nicht gleich sein. Bitte unterschiedliche Spielernamen vergeben.");
                return;
            }

            if (getNameSpieler1().Length < 3)
            {
                MessageBox.Show("Der Eingegebene Name für Spieler 1 ist zu kurz. Bitte drei oder mehr Zeichen eingeben.");
                return;
            }

            if (getNameSpieler1().Length > 14)
            {
                MessageBox.Show("Der Eingegebene Name für Spieler 1 ist zu lang. Bitte maximal 14 Zeichen eingeben.");
                return;
            }

            if (getNameSpieler2().Length < 3)
            {
                MessageBox.Show("Der Eingegebene Name für Spieler 2 ist zu kurz. Bitte drei oder mehr Zeichen eingeben.");
                return;
            }

            if (getNameSpieler2().Length > 14)
            {
                MessageBox.Show("Der Eingegebene Name für Spieler 2 ist zu lang. Bitte maximal 14 Zeichen eingeben.");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnEingabeZuruecksetzen_Click(object sender, EventArgs e)
        {
            tbNameSpieler1.Text = defaultNameSpieler1;
            tbNameSpieler2.Text = defaultNameSpieler2;
            pnlFarbeSpieler1.BackColor = defaultColorSpieler1;
            pnlFarbeSpieler2.BackColor = defaultColorSpieler2;

            tbNameSpieler1.Select();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pnlFarbeSpieler1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != colorDialog1.ShowDialog())
                return;

            pnlFarbeSpieler1.BackColor = colorDialog1.Color;
        }

        private void pnlFarbeSpieler2_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != colorDialog1.ShowDialog())
                return;

            pnlFarbeSpieler2.BackColor = colorDialog1.Color;
        }
    }
}
