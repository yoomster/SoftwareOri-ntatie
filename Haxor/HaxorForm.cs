using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haxor
{
    public partial class HaxorForm : Form
    {
        public HaxorForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string message = MessageBox.Text;

            string editedMessage;

            editedMessage = message.Replace("a", "4");
            editedMessage = editedMessage.Replace("s", "5");
            editedMessage = editedMessage.Replace("e", "3");
            editedMessage = editedMessage.Replace("v", "\\/");
            editedMessage = editedMessage.Replace("V", "\\/"); 
            editedMessage = editedMessage.Replace("m", "| V |");
            editedMessage = editedMessage.Replace("M", "| V |");


            Label.Text = editedMessage;

        }
    }
}
