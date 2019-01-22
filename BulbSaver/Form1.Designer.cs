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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHowManyBulbs = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCurrentCost = new System.Windows.Forms.Label();
            this.lblLedCost = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(448, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(448, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 253);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblLedCost);
            this.Controls.Add(this.lblCurrentCost);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblHowManyBulbs);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHowManyBulbs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCurrentCost;
        private System.Windows.Forms.Label lblLedCost;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

