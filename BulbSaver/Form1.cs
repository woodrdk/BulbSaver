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
                        
            double rate = Convert.ToDouble(tbPowerRate.Text);
            int howManyB = Convert.ToInt32(tbBulbs.Text);
            double howManyh = Convert.ToDouble(tbHours.Text);
            int watts = Convert.ToInt32(tbWatts.Text);
            double currCost = 0;
            double ledApprox = 0;

            tbLedCost.Text = Convert.ToString(ledApprox);
            tbCC.Text = Convert.ToString(currCost);
            
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
            if (tbWatts.Text == null)
            {
                MessageBox.Show("Please enter how many hours");

            }
                  
            

        }
    }
}
