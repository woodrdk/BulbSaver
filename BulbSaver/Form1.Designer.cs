namespace BulbSaver
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblPowerCost = new System.Windows.Forms.Label();
            this.tbPowerRate = new System.Windows.Forms.TextBox();
            this.lblHowManyBulbs = new System.Windows.Forms.Label();
            this.tbBulbs = new System.Windows.Forms.TextBox();
            this.lblCurrentCost = new System.Windows.Forms.Label();
            this.lblLedCost = new System.Windows.Forms.Label();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbLedCost = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.tbWatts = new System.Windows.Forms.TextBox();
            this.lblWattts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(511, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(430, 215);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblPowerCost
            // 
            this.lblPowerCost.AutoSize = true;
            this.lblPowerCost.Location = new System.Drawing.Point(13, 13);
            this.lblPowerCost.Name = "lblPowerCost";
            this.lblPowerCost.Size = new System.Drawing.Size(120, 13);
            this.lblPowerCost.TabIndex = 2;
            this.lblPowerCost.Text = "Whats your power rate?";
            // 
            // tbPowerRate
            // 
            this.tbPowerRate.Location = new System.Drawing.Point(139, 10);
            this.tbPowerRate.Name = "tbPowerRate";
            this.tbPowerRate.Size = new System.Drawing.Size(100, 20);
            this.tbPowerRate.TabIndex = 3;
            // 
            // lblHowManyBulbs
            // 
            this.lblHowManyBulbs.AutoSize = true;
            this.lblHowManyBulbs.Location = new System.Drawing.Point(13, 44);
            this.lblHowManyBulbs.Name = "lblHowManyBulbs";
            this.lblHowManyBulbs.Size = new System.Drawing.Size(91, 13);
            this.lblHowManyBulbs.TabIndex = 4;
            this.lblHowManyBulbs.Text = "How many bulbs?";
            // 
            // tbBulbs
            // 
            this.tbBulbs.Location = new System.Drawing.Point(139, 44);
            this.tbBulbs.Name = "tbBulbs";
            this.tbBulbs.Size = new System.Drawing.Size(100, 20);
            this.tbBulbs.TabIndex = 5;
            // 
            // lblCurrentCost
            // 
            this.lblCurrentCost.AutoSize = true;
            this.lblCurrentCost.Location = new System.Drawing.Point(283, 17);
            this.lblCurrentCost.Name = "lblCurrentCost";
            this.lblCurrentCost.Size = new System.Drawing.Size(80, 13);
            this.lblCurrentCost.TabIndex = 6;
            this.lblCurrentCost.Text = "Current cost is: ";
            // 
            // lblLedCost
            // 
            this.lblLedCost.AutoSize = true;
            this.lblLedCost.Location = new System.Drawing.Point(283, 44);
            this.lblLedCost.Name = "lblLedCost";
            this.lblLedCost.Size = new System.Drawing.Size(159, 13);
            this.lblLedCost.TabIndex = 7;
            this.lblLedCost.Text = "Led Bulb cost would be approx: ";
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(448, 14);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(100, 20);
            this.tbCC.TabIndex = 8;
            // 
            // tbLedCost
            // 
            this.tbLedCost.Location = new System.Drawing.Point(448, 41);
            this.tbLedCost.Name = "tbLedCost";
            this.tbLedCost.Size = new System.Drawing.Size(100, 20);
            this.tbLedCost.TabIndex = 9;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(13, 88);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(92, 13);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "How many hours?";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(139, 81);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(100, 20);
            this.tbHours.TabIndex = 11;
            // 
            // tbWatts
            // 
            this.tbWatts.Location = new System.Drawing.Point(139, 118);
            this.tbWatts.Name = "tbWatts";
            this.tbWatts.Size = new System.Drawing.Size(100, 20);
            this.tbWatts.TabIndex = 13;
            // 
            // lblWattts
            // 
            this.lblWattts.AutoSize = true;
            this.lblWattts.Location = new System.Drawing.Point(13, 125);
            this.lblWattts.Name = "lblWattts";
            this.lblWattts.Size = new System.Drawing.Size(91, 13);
            this.lblWattts.TabIndex = 12;
            this.lblWattts.Text = "How many watts?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 253);
            this.Controls.Add(this.tbWatts);
            this.Controls.Add(this.lblWattts);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.tbLedCost);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.lblLedCost);
            this.Controls.Add(this.lblCurrentCost);
            this.Controls.Add(this.tbBulbs);
            this.Controls.Add(this.lblHowManyBulbs);
            this.Controls.Add(this.tbPowerRate);
            this.Controls.Add(this.lblPowerCost);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Welcome to the BulbSaver App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblPowerCost;
        private System.Windows.Forms.TextBox tbPowerRate;
        private System.Windows.Forms.Label lblHowManyBulbs;
        private System.Windows.Forms.TextBox tbBulbs;
        private System.Windows.Forms.Label lblCurrentCost;
        private System.Windows.Forms.Label lblLedCost;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbLedCost;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.TextBox tbWatts;
        private System.Windows.Forms.Label lblWattts;
    }
}

