using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4
{
    public partial class RandomNumber : Form
    {
        Random generator = new Random();

        string RanF;
        int MaxI;
        int MinI;
        int Ran;
        double dMax;
        double dMin;
        double RanD;
        public RandomNumber()
        {
            InitializeComponent();
        }

        private void RandomNumber_Load(object sender, EventArgs e)
        {

        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            if (numMA.Value < numMI.Value)
            {
                lblRan.Text = "Please Enter Valid Values";

            }
            else
            {

                MaxI = Convert.ToInt32(numMA.Value);
                MinI = Convert.ToInt32(numMI.Value);



                Ran = generator.Next(MinI, MaxI);
                RanF = Convert.ToString(Ran);
                lblRan.Text = RanF;
            }

             
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {

            if (numMA.Value < numMI.Value)
            {
                lblRan.Text = "Please Enter Valid Values";

            }
            else
            {

                dMax = Convert.ToDouble(numMA.Value);
                dMin = Convert.ToDouble(numMI.Value);

                RanD = generator.NextDouble() * (dMax - dMin) + dMin;
                RanF = Convert.ToString(RanD);
                lblRan.Text = RanF;
            }



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
