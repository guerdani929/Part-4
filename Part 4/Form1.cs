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
        int MaxI;
        int MinI;
        double dMax;
        double dMin;
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



                int Ran = generator.Next(MinI, MaxI);
                string RanF = Convert.ToString(Ran);
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

                double Ran = generator.NextDouble() * (dMax - dMin) + dMin;
                string RanF = Convert.ToString(Ran);
                lblRan.Text = RanF;
            }



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
