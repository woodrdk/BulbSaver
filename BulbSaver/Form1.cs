using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulbSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double currCost = 0;
            double ledApprox = 0;

            double rate = Convert.ToDouble(tbPowerRate.Text); // rate 
            int howManyB = Convert.ToInt32(tbBulbs.Text);       // how many bulbs
            double howManyh = Convert.ToDouble(tbHours.Text);   // how many hours a day
            int watts = Convert.ToInt32(tbCurrWatt.Text);          // how many watts 
            

            double fixtWatts = watts * howManyB; // how many watts total

            double kwh = fixtWatts * howManyh / 1000;
            double monthlyKWH = kwh * 30;

            double aftFixtWatts = Convert.ToDouble(tbRepWatts.Text) * howManyB; // how many watts total
            double afterKwh = aftFixtWatts * howManyh / 1000;
            double afterMonthlyKWH = afterKwh * 30;

            currCost = kwh * rate;
            double monthlyCost = monthlyKWH * rate;
            double afterMonthlyCost = afterMonthlyKWH * rate;
            tbLedCost.Text = Convert.ToString(afterMonthlyCost);
            tbCC.Text = Convert.ToString(monthlyCost);
            tbSavings.Text = Convert.ToString(monthlyCost - afterMonthlyCost);
                      

            tbTotRepCost.Text = Convert.ToString(howManyB * Convert.ToDouble(tbCostLamp.Text));
            tbPayoffPer.Text = Convert.ToString((howManyB * Convert.ToDouble(tbCostLamp.Text)) / (monthlyCost - afterMonthlyCost));

            tbBeforeUsage.Text = Convert.ToString(monthlyKWH);
            tbAfterUsage.Text = Convert.ToString(afterMonthlyKWH);
            tbUsageSavings.Text = Convert.ToString(monthlyKWH - afterMonthlyKWH);
        }

        private void CheckValues()
        {
            if(tbPowerRate.Text == null)
            {
                MessageBox.Show("Please enter power rate");
            }
            if (tbBulbs.Text == null)
            {
                MessageBox.Show("Please enter how many bulbs");

            }
            if (tbHours.Text == null)
            {
                MessageBox.Show("Please enter how many hours");

            }
            if (tbRepWatts.Text == null)
            {
                MessageBox.Show("Please enter how many hours");

            }
                  
            

        }
    }
}
