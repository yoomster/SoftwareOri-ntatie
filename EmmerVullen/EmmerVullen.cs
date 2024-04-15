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
            int bucketSizeInCL = bucketSizeInL * 100;
            
            BucketProgressBar.Maximum = bucketSizeInCL;
            BucketProgressBar.Step =cupSizeInCL;

            int amountInBucketInCl = 0;
            bool isBucketFull = false;

            while (isBucketFull == false)
            {
                amountInBucketInCl += cupSizeInCL;
                BucketProgressBar.PerformStep();

                Thread.Sleep(100);
                Application.DoEvents();

                if (amountInBucketInCl >= bucketSizeInCL)
                {
                    isBucketFull = true;
                }
            }

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            BucketProgressBar.Step = 0;
            BucketProgressBar.Value = 0;
            BucketSizeTextBox.Text = string.Empty;
            CupSizeTextBox.Text = string.Empty;
        }
    }
}
