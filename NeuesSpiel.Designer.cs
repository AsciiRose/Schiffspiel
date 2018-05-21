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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameSpieler1 = new System.Windows.Forms.TextBox();
            this.tbNameSpieler2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEingabeLeeren = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spieler 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spieler 2:";
            // 
            // tbNameSpieler1
            // 
            this.tbNameSpieler1.Location = new System.Drawing.Point(94, 12);
            this.tbNameSpieler1.Name = "tbNameSpieler1";
            this.tbNameSpieler1.Size = new System.Drawing.Size(126, 20);
            this.tbNameSpieler1.TabIndex = 2;
            // 
            // tbNameSpieler2
            // 
            this.tbNameSpieler2.Location = new System.Drawing.Point(94, 53);
            this.tbNameSpieler2.Name = "tbNameSpieler2";
            this.tbNameSpieler2.Size = new System.Drawing.Size(126, 20);
            this.tbNameSpieler2.TabIndex = 3;
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
            // btnEingabeLeeren
            // 
            this.btnEingabeLeeren.Location = new System.Drawing.Point(12, 139);
            this.btnEingabeLeeren.Name = "btnEingabeLeeren";
            this.btnEingabeLeeren.Size = new System.Drawing.Size(99, 23);
            this.btnEingabeLeeren.TabIndex = 5;
            this.btnEingabeLeeren.Text = "Felder leeren";
            this.btnEingabeLeeren.UseVisualStyleBackColor = true;
            this.btnEingabeLeeren.Click += new System.EventHandler(this.btnEingabeLeeren_Click);
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
            // NeuesSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 172);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEingabeLeeren);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbNameSpieler2);
            this.Controls.Add(this.tbNameSpieler1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeuesSpiel";
            this.Text = "Neues Spiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEingabeLeeren;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNameSpieler1;
        private System.Windows.Forms.TextBox tbNameSpieler2;
    }
}