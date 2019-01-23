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
            this.tbRepWatts = new System.Windows.Forms.TextBox();
            this.lblWattts = new System.Windows.Forms.Label();
            this.tbCostLamp = new System.Windows.Forms.TextBox();
            this.lblBulbCost = new System.Windows.Forms.Label();
            this.gbElecCosts = new System.Windows.Forms.GroupBox();
            this.lblSavings = new System.Windows.Forms.Label();
            this.tbSavings = new System.Windows.Forms.TextBox();
            this.lblTRC = new System.Windows.Forms.Label();
            this.lblPP = new System.Windows.Forms.Label();
            this.tbPayoffPer = new System.Windows.Forms.TextBox();
            this.tbTotRepCost = new System.Windows.Forms.TextBox();
            this.gbPaybackTimeline = new System.Windows.Forms.GroupBox();
            this.lblBeforeReplaceUsage = new System.Windows.Forms.Label();
            this.lblAfterReplaceUsage = new System.Windows.Forms.Label();
            this.lblUsageSavings = new System.Windows.Forms.Label();
            this.tbBeforeUsage = new System.Windows.Forms.TextBox();
            this.tbAfterUsage = new System.Windows.Forms.TextBox();
            this.tbUsageSavings = new System.Windows.Forms.TextBox();
            this.gbElecUsage = new System.Windows.Forms.GroupBox();
            this.tbCurrWatt = new System.Windows.Forms.TextBox();
            this.lblCurrWatt = new System.Windows.Forms.Label();
            this.gbElecCosts.SuspendLayout();
            this.gbPaybackTimeline.SuspendLayout();
            this.gbElecUsage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(40, 317);
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
            this.tbPowerRate.Location = new System.Drawing.Point(146, 10);
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
            this.tbBulbs.Location = new System.Drawing.Point(146, 44);
            this.tbBulbs.Name = "tbBulbs";
            this.tbBulbs.Size = new System.Drawing.Size(100, 20);
            this.tbBulbs.TabIndex = 5;
            // 
            // lblCurrentCost
            // 
            this.lblCurrentCost.AutoSize = true;
            this.lblCurrentCost.Location = new System.Drawing.Point(12, 27);
            this.lblCurrentCost.Name = "lblCurrentCost";
            this.lblCurrentCost.Size = new System.Drawing.Size(80, 13);
            this.lblCurrentCost.TabIndex = 6;
            this.lblCurrentCost.Text = "Current cost is: ";
            // 
            // lblLedCost
            // 
            this.lblLedCost.AutoSize = true;
            this.lblLedCost.Location = new System.Drawing.Point(12, 54);
            this.lblLedCost.Name = "lblLedCost";
            this.lblLedCost.Size = new System.Drawing.Size(159, 13);
            this.lblLedCost.TabIndex = 7;
            this.lblLedCost.Text = "Led Bulb cost would be approx: ";
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(177, 24);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(100, 20);
            this.tbCC.TabIndex = 8;
            // 
            // tbLedCost
            // 
            this.tbLedCost.Location = new System.Drawing.Point(177, 51);
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
            this.tbHours.Location = new System.Drawing.Point(146, 81);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(100, 20);
            this.tbHours.TabIndex = 11;
            // 
            // tbRepWatts
            // 
            this.tbRepWatts.Location = new System.Drawing.Point(146, 159);
            this.tbRepWatts.Name = "tbRepWatts";
            this.tbRepWatts.Size = new System.Drawing.Size(100, 20);
            this.tbRepWatts.TabIndex = 13;
            // 
            // lblWattts
            // 
            this.lblWattts.AutoSize = true;
            this.lblWattts.Location = new System.Drawing.Point(13, 166);
            this.lblWattts.Name = "lblWattts";
            this.lblWattts.Size = new System.Drawing.Size(117, 13);
            this.lblWattts.TabIndex = 12;
            this.lblWattts.Text = "Replacement wattage?";
            // 
            // tbCostLamp
            // 
            this.tbCostLamp.Location = new System.Drawing.Point(146, 185);
            this.tbCostLamp.Name = "tbCostLamp";
            this.tbCostLamp.Size = new System.Drawing.Size(100, 20);
            this.tbCostLamp.TabIndex = 15;
            // 
            // lblBulbCost
            // 
            this.lblBulbCost.AutoSize = true;
            this.lblBulbCost.Location = new System.Drawing.Point(14, 190);
            this.lblBulbCost.Name = "lblBulbCost";
            this.lblBulbCost.Size = new System.Drawing.Size(133, 13);
            this.lblBulbCost.TabIndex = 14;
            this.lblBulbCost.Text = "Cost per replacement bulb:";
            // 
            // gbElecCosts
            // 
            this.gbElecCosts.Controls.Add(this.tbSavings);
            this.gbElecCosts.Controls.Add(this.lblSavings);
            this.gbElecCosts.Controls.Add(this.tbLedCost);
            this.gbElecCosts.Controls.Add(this.lblCurrentCost);
            this.gbElecCosts.Controls.Add(this.lblLedCost);
            this.gbElecCosts.Controls.Add(this.tbCC);
            this.gbElecCosts.Location = new System.Drawing.Point(286, 13);
            this.gbElecCosts.Name = "gbElecCosts";
            this.gbElecCosts.Size = new System.Drawing.Size(294, 125);
            this.gbElecCosts.TabIndex = 16;
            this.gbElecCosts.TabStop = false;
            this.gbElecCosts.Text = "Electricity Costs";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(15, 88);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(48, 13);
            this.lblSavings.TabIndex = 10;
            this.lblSavings.Text = "Savings:";
            // 
            // tbSavings
            // 
            this.tbSavings.Location = new System.Drawing.Point(177, 80);
            this.tbSavings.Name = "tbSavings";
            this.tbSavings.Size = new System.Drawing.Size(100, 20);
            this.tbSavings.TabIndex = 11;
            // 
            // lblTRC
            // 
            this.lblTRC.AutoSize = true;
            this.lblTRC.Location = new System.Drawing.Point(14, 43);
            this.lblTRC.Name = "lblTRC";
            this.lblTRC.Size = new System.Drawing.Size(124, 13);
            this.lblTRC.TabIndex = 17;
            this.lblTRC.Text = "Total Replacement Cost:";
            // 
            // lblPP
            // 
            this.lblPP.AutoSize = true;
            this.lblPP.Location = new System.Drawing.Point(14, 69);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(70, 13);
            this.lblPP.TabIndex = 18;
            this.lblPP.Text = "Payoff Period";
            // 
            // tbPayoffPer
            // 
            this.tbPayoffPer.Location = new System.Drawing.Point(166, 62);
            this.tbPayoffPer.Name = "tbPayoffPer";
            this.tbPayoffPer.Size = new System.Drawing.Size(100, 20);
            this.tbPayoffPer.TabIndex = 19;
            // 
            // tbTotRepCost
            // 
            this.tbTotRepCost.Location = new System.Drawing.Point(166, 36);
            this.tbTotRepCost.Name = "tbTotRepCost";
            this.tbTotRepCost.Size = new System.Drawing.Size(100, 20);
            this.tbTotRepCost.TabIndex = 20;
            // 
            // gbPaybackTimeline
            // 
            this.gbPaybackTimeline.Controls.Add(this.tbTotRepCost);
            this.gbPaybackTimeline.Controls.Add(this.lblTRC);
            this.gbPaybackTimeline.Controls.Add(this.tbPayoffPer);
            this.gbPaybackTimeline.Controls.Add(this.lblPP);
            this.gbPaybackTimeline.Location = new System.Drawing.Point(292, 149);
            this.gbPaybackTimeline.Name = "gbPaybackTimeline";
            this.gbPaybackTimeline.Size = new System.Drawing.Size(288, 100);
            this.gbPaybackTimeline.TabIndex = 21;
            this.gbPaybackTimeline.TabStop = false;
            this.gbPaybackTimeline.Text = "Payback Timeline";
            // 
            // lblBeforeReplaceUsage
            // 
            this.lblBeforeReplaceUsage.AutoSize = true;
            this.lblBeforeReplaceUsage.Location = new System.Drawing.Point(57, 26);
            this.lblBeforeReplaceUsage.Name = "lblBeforeReplaceUsage";
            this.lblBeforeReplaceUsage.Size = new System.Drawing.Size(123, 13);
            this.lblBeforeReplaceUsage.TabIndex = 22;
            this.lblBeforeReplaceUsage.Text = "Before Replacing Lamps";
            // 
            // lblAfterReplaceUsage
            // 
            this.lblAfterReplaceUsage.AutoSize = true;
            this.lblAfterReplaceUsage.Location = new System.Drawing.Point(57, 48);
            this.lblAfterReplaceUsage.Name = "lblAfterReplaceUsage";
            this.lblAfterReplaceUsage.Size = new System.Drawing.Size(114, 13);
            this.lblAfterReplaceUsage.TabIndex = 23;
            this.lblAfterReplaceUsage.Text = "After Replacing Lamps";
            // 
            // lblUsageSavings
            // 
            this.lblUsageSavings.AutoSize = true;
            this.lblUsageSavings.Location = new System.Drawing.Point(103, 71);
            this.lblUsageSavings.Name = "lblUsageSavings";
            this.lblUsageSavings.Size = new System.Drawing.Size(45, 13);
            this.lblUsageSavings.TabIndex = 24;
            this.lblUsageSavings.Text = "Savings";
            // 
            // tbBeforeUsage
            // 
            this.tbBeforeUsage.Location = new System.Drawing.Point(192, 19);
            this.tbBeforeUsage.Name = "tbBeforeUsage";
            this.tbBeforeUsage.Size = new System.Drawing.Size(100, 20);
            this.tbBeforeUsage.TabIndex = 25;
            // 
            // tbAfterUsage
            // 
            this.tbAfterUsage.Location = new System.Drawing.Point(192, 45);
            this.tbAfterUsage.Name = "tbAfterUsage";
            this.tbAfterUsage.Size = new System.Drawing.Size(100, 20);
            this.tbAfterUsage.TabIndex = 26;
            // 
            // tbUsageSavings
            // 
            this.tbUsageSavings.Location = new System.Drawing.Point(192, 71);
            this.tbUsageSavings.Name = "tbUsageSavings";
            this.tbUsageSavings.Size = new System.Drawing.Size(100, 20);
            this.tbUsageSavings.TabIndex = 27;
            // 
            // gbElecUsage
            // 
            this.gbElecUsage.Controls.Add(this.tbBeforeUsage);
            this.gbElecUsage.Controls.Add(this.tbUsageSavings);
            this.gbElecUsage.Controls.Add(this.lblBeforeReplaceUsage);
            this.gbElecUsage.Controls.Add(this.tbAfterUsage);
            this.gbElecUsage.Controls.Add(this.lblAfterReplaceUsage);
            this.gbElecUsage.Controls.Add(this.lblUsageSavings);
            this.gbElecUsage.Location = new System.Drawing.Point(286, 268);
            this.gbElecUsage.Name = "gbElecUsage";
            this.gbElecUsage.Size = new System.Drawing.Size(312, 100);
            this.gbElecUsage.TabIndex = 28;
            this.gbElecUsage.TabStop = false;
            this.gbElecUsage.Text = "Electrical Usage";
            // 
            // tbCurrWatt
            // 
            this.tbCurrWatt.Location = new System.Drawing.Point(149, 118);
            this.tbCurrWatt.Name = "tbCurrWatt";
            this.tbCurrWatt.Size = new System.Drawing.Size(100, 20);
            this.tbCurrWatt.TabIndex = 30;
            // 
            // lblCurrWatt
            // 
            this.lblCurrWatt.AutoSize = true;
            this.lblCurrWatt.Location = new System.Drawing.Point(16, 125);
            this.lblCurrWatt.Name = "lblCurrWatt";
            this.lblCurrWatt.Size = new System.Drawing.Size(91, 13);
            this.lblCurrWatt.TabIndex = 29;
            this.lblCurrWatt.Text = "Current Wattage?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 380);
            this.Controls.Add(this.tbCurrWatt);
            this.Controls.Add(this.lblCurrWatt);
            this.Controls.Add(this.gbElecUsage);
            this.Controls.Add(this.gbPaybackTimeline);
            this.Controls.Add(this.gbElecCosts);
            this.Controls.Add(this.tbCostLamp);
            this.Controls.Add(this.lblBulbCost);
            this.Controls.Add(this.tbRepWatts);
            this.Controls.Add(this.lblWattts);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.tbBulbs);
            this.Controls.Add(this.lblHowManyBulbs);
            this.Controls.Add(this.tbPowerRate);
            this.Controls.Add(this.lblPowerCost);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Welcome to the BulbSaver App";
            this.gbElecCosts.ResumeLayout(false);
            this.gbElecCosts.PerformLayout();
            this.gbPaybackTimeline.ResumeLayout(false);
            this.gbPaybackTimeline.PerformLayout();
            this.gbElecUsage.ResumeLayout(false);
            this.gbElecUsage.PerformLayout();
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
        private System.Windows.Forms.TextBox tbRepWatts;
        private System.Windows.Forms.Label lblWattts;
        private System.Windows.Forms.TextBox tbCostLamp;
        private System.Windows.Forms.Label lblBulbCost;
        private System.Windows.Forms.GroupBox gbElecCosts;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox tbSavings;
        private System.Windows.Forms.Label lblTRC;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.TextBox tbPayoffPer;
        private System.Windows.Forms.TextBox tbTotRepCost;
        private System.Windows.Forms.GroupBox gbPaybackTimeline;
        private System.Windows.Forms.Label lblBeforeReplaceUsage;
        private System.Windows.Forms.Label lblAfterReplaceUsage;
        private System.Windows.Forms.Label lblUsageSavings;
        private System.Windows.Forms.TextBox tbBeforeUsage;
        private System.Windows.Forms.TextBox tbAfterUsage;
        private System.Windows.Forms.TextBox tbUsageSavings;
        private System.Windows.Forms.GroupBox gbElecUsage;
        private System.Windows.Forms.TextBox tbCurrWatt;
        private System.Windows.Forms.Label lblCurrWatt;
    }
}

