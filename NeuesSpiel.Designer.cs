namespace grundspiel
{
    partial class NeuesSpiel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNameSpieler1 = new System.Windows.Forms.TextBox();
            this.tbNameSpieler2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEingabeZuruecksetzen = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlFarbeSpieler1 = new System.Windows.Forms.Panel();
            this.pnlFarbeSpieler2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbNameSpieler1
            // 
            this.tbNameSpieler1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameSpieler1.Location = new System.Drawing.Point(12, 12);
            this.tbNameSpieler1.Name = "tbNameSpieler1";
            this.tbNameSpieler1.Size = new System.Drawing.Size(208, 30);
            this.tbNameSpieler1.TabIndex = 2;
            this.tbNameSpieler1.Text = "Spieler 1";
            // 
            // tbNameSpieler2
            // 
            this.tbNameSpieler2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameSpieler2.Location = new System.Drawing.Point(12, 50);
            this.tbNameSpieler2.Name = "tbNameSpieler2";
            this.tbNameSpieler2.Size = new System.Drawing.Size(208, 30);
            this.tbNameSpieler2.TabIndex = 3;
            this.tbNameSpieler2.Text = "Spieler 2";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 98);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(208, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEingabeZuruecksetzen
            // 
            this.btnEingabeZuruecksetzen.Location = new System.Drawing.Point(12, 139);
            this.btnEingabeZuruecksetzen.Name = "btnEingabeZuruecksetzen";
            this.btnEingabeZuruecksetzen.Size = new System.Drawing.Size(99, 23);
            this.btnEingabeZuruecksetzen.TabIndex = 5;
            this.btnEingabeZuruecksetzen.Text = "Zurücksetzen";
            this.btnEingabeZuruecksetzen.UseVisualStyleBackColor = true;
            this.btnEingabeZuruecksetzen.Click += new System.EventHandler(this.btnEingabeZuruecksetzen_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlFarbeSpieler1
            // 
            this.pnlFarbeSpieler1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlFarbeSpieler1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFarbeSpieler1.Location = new System.Drawing.Point(195, 17);
            this.pnlFarbeSpieler1.Name = "pnlFarbeSpieler1";
            this.pnlFarbeSpieler1.Size = new System.Drawing.Size(20, 20);
            this.pnlFarbeSpieler1.TabIndex = 7;
            this.pnlFarbeSpieler1.Click += new System.EventHandler(this.pnlFarbeSpieler1_Click);
            // 
            // pnlFarbeSpieler2
            // 
            this.pnlFarbeSpieler2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlFarbeSpieler2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFarbeSpieler2.Location = new System.Drawing.Point(195, 55);
            this.pnlFarbeSpieler2.Name = "pnlFarbeSpieler2";
            this.pnlFarbeSpieler2.Size = new System.Drawing.Size(20, 20);
            this.pnlFarbeSpieler2.TabIndex = 8;
            this.pnlFarbeSpieler2.Click += new System.EventHandler(this.pnlFarbeSpieler2_Click);
            // 
            // NeuesSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 172);
            this.Controls.Add(this.pnlFarbeSpieler2);
            this.Controls.Add(this.pnlFarbeSpieler1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEingabeZuruecksetzen);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbNameSpieler2);
            this.Controls.Add(this.tbNameSpieler1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeuesSpiel";
            this.Text = "Neues Spiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEingabeZuruecksetzen;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNameSpieler1;
        private System.Windows.Forms.TextBox tbNameSpieler2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlFarbeSpieler1;
        private System.Windows.Forms.Panel pnlFarbeSpieler2;
    }
}