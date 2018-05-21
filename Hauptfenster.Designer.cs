﻿namespace grundspiel
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWuerfel = new System.Windows.Forms.Label();
            this.btnWuerfeln = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblSpieler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSwitchPlayer = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWuerfel
            // 
            this.lblWuerfel.AutoSize = true;
            this.lblWuerfel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWuerfel.Location = new System.Drawing.Point(410, 602);
            this.lblWuerfel.Name = "lblWuerfel";
            this.lblWuerfel.Size = new System.Drawing.Size(18, 17);
            this.lblWuerfel.TabIndex = 1;
            this.lblWuerfel.Text = "--";
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Enabled = false;
            this.btnWuerfeln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnWuerfeln.Location = new System.Drawing.Point(696, 619);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(136, 62);
            this.btnWuerfeln.TabIndex = 2;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.btnWuerfeln_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Schritte:";
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUp.Location = new System.Drawing.Point(571, 585);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 28);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "⮝";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(612, 620);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(35, 28);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "⮞";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(571, 653);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 28);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "⮟";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(530, 620);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(35, 28);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "⮜";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblSpieler
            // 
            this.lblSpieler.AutoSize = true;
            this.lblSpieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpieler.Location = new System.Drawing.Point(410, 585);
            this.lblSpieler.Name = "lblSpieler";
            this.lblSpieler.Size = new System.Drawing.Size(64, 17);
            this.lblSpieler.TabIndex = 8;
            this.lblSpieler.Text = "Spieler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Am Zug:";
            // 
            // btnSwitchPlayer
            // 
            this.btnSwitchPlayer.Enabled = false;
            this.btnSwitchPlayer.Location = new System.Drawing.Point(696, 585);
            this.btnSwitchPlayer.Name = "btnSwitchPlayer";
            this.btnSwitchPlayer.Size = new System.Drawing.Size(136, 28);
            this.btnSwitchPlayer.TabIndex = 11;
            this.btnSwitchPlayer.Text = "Runde abschließen";
            this.btnSwitchPlayer.UseVisualStyleBackColor = true;
            this.btnSwitchPlayer.Click += new System.EventHandler(this.btnSwitchPlayer_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 585);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "Neues Spiel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.Enabled = false;
            this.btnEditor.Location = new System.Drawing.Point(12, 614);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(75, 23);
            this.btnEditor.TabIndex = 13;
            this.btnEditor.Text = "Editor";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.extrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.toolStripMenuItem1,
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "Spiel";
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpielToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Enabled = false;
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.Font = new System.Drawing.Font("Courier New", 8F);
            this.tbConsole.Location = new System.Drawing.Point(12, 464);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(820, 95);
            this.tbConsole.TabIndex = 15;
            this.tbConsole.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(12, 658);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(75, 23);
            this.btnBeenden.TabIndex = 16;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(845, 693);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnSwitchPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSpieler);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWuerfeln);
            this.Controls.Add(this.lblWuerfel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Hauptfenster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Spiel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hauptfenster_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hauptfenster_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWuerfel;
        private System.Windows.Forms.Button btnWuerfeln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblSpieler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSwitchPlayer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Button btnBeenden;
    }
}

