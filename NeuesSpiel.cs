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
        public NeuesSpiel()
        {
            InitializeComponent();
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

        private void btnEingabeLeeren_Click(object sender, EventArgs e)
        {
            tbNameSpieler1.Text = String.Empty;
            tbNameSpieler2.Text = String.Empty;
            tbNameSpieler1.Select();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
