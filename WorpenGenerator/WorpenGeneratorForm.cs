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

        private void ButtonThrowDice_Click(object sender, EventArgs e)
        {
            DiceThrowsList.Items.Clear();
            Random random = new Random();

            int totalPips = 0;

            for (int i = 0; i < ThrowsNumUpDown.Value; i++)
            {
                int diceRoll = random.Next(1, ((int)PipsNumUpDown.Value));

                DiceThrowsList.Items.Add(diceRoll);

                totalPips += diceRoll;
            }

            TotalPipslabel.Text = totalPips.ToString();



        }
    }
}
