using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorpenGenerator
{
    public partial class WorpenGeneratorForm : Form
    {
        public WorpenGeneratorForm()
        {
            InitializeComponent();
        }

        private void ThrowsNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            ThrowsNumUpDown.Minimum = 1;
            ThrowsNumUpDown.Maximum = 1000;
        }

        private void ThrowDiceButton_Click(object sender, EventArgs e)
        {
            //empty listbox
            DiceThrowsList.Items.Clear();
            //waardoor “aantal worpen” keer een willekeurig
            //getal van 1 t/m 6 wordt toegevoegd aan de ListBox.
        }
    }
}
