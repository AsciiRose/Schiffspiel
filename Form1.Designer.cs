namespace grundspiel
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblWuerfel
            // 
            this.lblWuerfel.AutoSize = true;
            this.lblWuerfel.Location = new System.Drawing.Point(686, 485);
            this.lblWuerfel.Name = "lblWuerfel";
            this.lblWuerfel.Size = new System.Drawing.Size(13, 13);
            this.lblWuerfel.TabIndex = 1;
            this.lblWuerfel.Text = "--";
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Enabled = false;
            this.btnWuerfeln.Location = new System.Drawing.Point(757, 480);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(75, 23);
            this.btnWuerfeln.TabIndex = 2;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.btnWuerfeln_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Moves:";
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(516, 461);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(559, 485);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(37, 23);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(516, 508);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(473, 485);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(37, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblSpieler
            // 
            this.lblSpieler.AutoSize = true;
            this.lblSpieler.Location = new System.Drawing.Point(686, 446);
            this.lblSpieler.Name = "lblSpieler";
            this.lblSpieler.Size = new System.Drawing.Size(48, 13);
            this.lblSpieler.TabIndex = 8;
            this.lblSpieler.Text = "Spieler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aktiv:";
            // 
            // btnSwitchPlayer
            // 
            this.btnSwitchPlayer.Enabled = false;
            this.btnSwitchPlayer.Location = new System.Drawing.Point(757, 441);
            this.btnSwitchPlayer.Name = "btnSwitchPlayer";
            this.btnSwitchPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchPlayer.TabIndex = 11;
            this.btnSwitchPlayer.Text = "Naechster";
            this.btnSwitchPlayer.UseVisualStyleBackColor = true;
            this.btnSwitchPlayer.Click += new System.EventHandler(this.btnSwitchPlayer_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(757, 532);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "Neues Spiel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(64, 474);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(75, 23);
            this.btnEditor.TabIndex = 13;
            this.btnEditor.Text = "Editor";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(847, 573);
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(863, 612);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(863, 612);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Spiel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
    }
}

