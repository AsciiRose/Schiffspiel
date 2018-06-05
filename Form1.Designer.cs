namespace Schiffspiel
{
    partial class Startseite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startseite));
            this.WMPStartVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.gBMenue = new System.Windows.Forms.GroupBox();
            this.pMenue = new System.Windows.Forms.Panel();
            this.btnAnleitung = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.pBVor = new System.Windows.Forms.PictureBox();
            this.pBZurueck = new System.Windows.Forms.PictureBox();
            this.pBLevel = new System.Windows.Forms.PictureBox();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLeveleditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMPStartVideo)).BeginInit();
            this.gBMenue.SuspendLayout();
            this.pMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBZurueck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // WMPStartVideo
            // 
            this.WMPStartVideo.Dock = System.Windows.Forms.DockStyle.Right;
            this.WMPStartVideo.Enabled = true;
            this.WMPStartVideo.Location = new System.Drawing.Point(203, 0);
            this.WMPStartVideo.Name = "WMPStartVideo";
            this.WMPStartVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPStartVideo.OcxState")));
            this.WMPStartVideo.Size = new System.Drawing.Size(1179, 665);
            this.WMPStartVideo.TabIndex = 1;
            this.WMPStartVideo.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMPBackgroundVideo_PlayStateChange);
            // 
            // gBMenue
            // 
            this.gBMenue.Controls.Add(this.pMenue);
            this.gBMenue.Controls.Add(this.pBVor);
            this.gBMenue.Controls.Add(this.pBZurueck);
            this.gBMenue.Controls.Add(this.pBLevel);
            this.gBMenue.Controls.Add(this.btnLevel);
            this.gBMenue.Controls.Add(this.btnStart);
            this.gBMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBMenue.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBMenue.ForeColor = System.Drawing.Color.White;
            this.gBMenue.Location = new System.Drawing.Point(0, 0);
            this.gBMenue.Name = "gBMenue";
            this.gBMenue.Size = new System.Drawing.Size(200, 665);
            this.gBMenue.TabIndex = 2;
            this.gBMenue.TabStop = false;
            this.gBMenue.Text = "Menü";
            // 
            // pMenue
            // 
            this.pMenue.Controls.Add(this.btnLeveleditor);
            this.pMenue.Controls.Add(this.btnAnleitung);
            this.pMenue.Controls.Add(this.btnBeenden);
            this.pMenue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenue.Location = new System.Drawing.Point(3, 438);
            this.pMenue.Name = "pMenue";
            this.pMenue.Size = new System.Drawing.Size(194, 224);
            this.pMenue.TabIndex = 3;
            // 
            // btnAnleitung
            // 
            this.btnAnleitung.ForeColor = System.Drawing.Color.Black;
            this.btnAnleitung.Location = new System.Drawing.Point(9, 76);
            this.btnAnleitung.Name = "btnAnleitung";
            this.btnAnleitung.Size = new System.Drawing.Size(176, 44);
            this.btnAnleitung.TabIndex = 1;
            this.btnAnleitung.Text = "Anleitung";
            this.btnAnleitung.UseVisualStyleBackColor = true;
            this.btnAnleitung.Click += new System.EventHandler(this.btnAnleitung_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.BackColor = System.Drawing.Color.DimGray;
            this.btnBeenden.ForeColor = System.Drawing.Color.White;
            this.btnBeenden.Location = new System.Drawing.Point(9, 141);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(176, 44);
            this.btnBeenden.TabIndex = 2;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = false;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // pBVor
            // 
            this.pBVor.Image = global::Schiffspiel.Properties.Resources.vor;
            this.pBVor.Location = new System.Drawing.Point(68, 318);
            this.pBVor.Name = "pBVor";
            this.pBVor.Size = new System.Drawing.Size(64, 64);
            this.pBVor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBVor.TabIndex = 5;
            this.pBVor.TabStop = false;
            this.pBVor.Click += new System.EventHandler(this.pBVor_Click);
            // 
            // pBZurueck
            // 
            this.pBZurueck.Image = global::Schiffspiel.Properties.Resources.zurueck;
            this.pBZurueck.Location = new System.Drawing.Point(68, 108);
            this.pBZurueck.Name = "pBZurueck";
            this.pBZurueck.Size = new System.Drawing.Size(64, 64);
            this.pBZurueck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBZurueck.TabIndex = 6;
            this.pBZurueck.TabStop = false;
            this.pBZurueck.Click += new System.EventHandler(this.pBZurueck_Click);
            // 
            // pBLevel
            // 
            this.pBLevel.Image = global::Schiffspiel.Properties.Resources.Kreuzfahrtschiff;
            this.pBLevel.Location = new System.Drawing.Point(12, 178);
            this.pBLevel.Name = "pBLevel";
            this.pBLevel.Size = new System.Drawing.Size(176, 132);
            this.pBLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLevel.TabIndex = 4;
            this.pBLevel.TabStop = false;
            this.pBLevel.Click += new System.EventHandler(this.pBLevel_Click);
            // 
            // btnLevel
            // 
            this.btnLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(103)))), ((int)(((byte)(53)))));
            this.btnLevel.ForeColor = System.Drawing.Color.White;
            this.btnLevel.Location = new System.Drawing.Point(12, 56);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(176, 44);
            this.btnLevel.TabIndex = 0;
            this.btnLevel.Text = "Level";
            this.btnLevel.UseVisualStyleBackColor = false;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(46)))), ((int)(((byte)(32)))));
            this.btnStart.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 388);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(176, 44);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "☠ Start ☠";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLeveleditor
            // 
            this.btnLeveleditor.ForeColor = System.Drawing.Color.Black;
            this.btnLeveleditor.Location = new System.Drawing.Point(9, 14);
            this.btnLeveleditor.Name = "btnLeveleditor";
            this.btnLeveleditor.Size = new System.Drawing.Size(176, 44);
            this.btnLeveleditor.TabIndex = 3;
            this.btnLeveleditor.Text = "Leveleditor";
            this.btnLeveleditor.UseVisualStyleBackColor = true;
            this.btnLeveleditor.Click += new System.EventHandler(this.btnLeveleditor_Click);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1382, 665);
            this.Controls.Add(this.WMPStartVideo);
            this.Controls.Add(this.gBMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Startseite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schiffspiel";
            this.Load += new System.EventHandler(this.Startseite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMPStartVideo)).EndInit();
            this.gBMenue.ResumeLayout(false);
            this.gBMenue.PerformLayout();
            this.pMenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBVor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBZurueck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer WMPStartVideo;
        private System.Windows.Forms.GroupBox gBMenue;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Panel pMenue;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnAnleitung;
        private System.Windows.Forms.PictureBox pBLevel;
        private System.Windows.Forms.PictureBox pBVor;
        private System.Windows.Forms.PictureBox pBZurueck;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLeveleditor;
    }
}

// 