using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexOfE
{
    public partial class IndexOfEForm : Form
    {
        public IndexOfEForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string message = MessageBox.Text;
            int index = message.IndexOf("e");
            string indexText = Convert.ToString(index);

            if (index == -1)
            {
                Label.Text = "-1";
            }
            else
            {
                Label.Text = indexText;
            }
        }
    }
}
