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

        public NeuesSpiel()
        {
            InitializeComponent();
            defaultNameSpieler1 = getNameSpieler1();
            defaultNameSpieler2 = getNameSpieler2();
        }

        public String getNameSpieler1()
        {
            return tbNameSpieler1.Text;
        }

        public String getNameSpieler2()
        {
            return tbNameSpieler2.Text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(getNameSpieler1().Length < 3)
            {
                MessageBox.Show("Der Eingegebene Name für Spieler 1 ist zu kurz. Bitte drei oder mehr Zeichen eingeben.");
                return;
            }

            if (getNameSpieler2().Length < 3)
            {
                MessageBox.Show("Der Eingegebene Name für Spieler 2 ist zu kurz. Bitte drei oder mehr Zeichen eingeben.");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnEingabeZuruecksetzen_Click(object sender, EventArgs e)
        {
            tbNameSpieler1.Text = defaultNameSpieler1;
            tbNameSpieler2.Text = defaultNameSpieler2;
            tbNameSpieler1.Select();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
