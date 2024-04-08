using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmmerVullen
{
    public partial class EmmerVullen : Form
    {
        public EmmerVullen()
        {
            InitializeComponent();
        }

        private void ButtonFillBucket_Click(object sender, EventArgs e)
        {
            //1L = 100CL
            int.TryParse(BucketSizeTextBox.Text, out int bucketSizeInL);
            int.TryParse(CupSizeTextBox.Text, out int cupSizeInCL);
            int amountInBucketInCl = 0;
            bool isBucketFull = false;


            //BucketProgressBar.Maximum = ;

            while (isBucketFull == false)
            {
                amountInBucketInCl += cupSizeInCL;

                Thread.Sleep(100);
                Application.DoEvents();

                if (BucketProgressBar.Value >= bucketSizeInL)
                {
                    isBucketFull = true;
                }
            }

        }


    }
    record FluidAmountInML()
    {

    }
}
