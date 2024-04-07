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
            HighestThrowLabel.Text = ShowHighestValue();
            LowestThrowLabel.Text = ShowLowestValue();
        }

        public string ShowHighestValue()
        {
            int maxNr = (int)DiceThrowsList.Items[0];

            for (int i = 1; i < DiceThrowsList.Items.Count; i++)
            {
                int currentValue = (int)DiceThrowsList.Items[i];
                if (currentValue > maxNr)
                {
                    maxNr = currentValue;
                }
            }

            return $"Hoogste worp: {maxNr}";
        }
        public string ShowLowestValue()
        {
            int minNr = (int)DiceThrowsList.Items[0];

            for (int i = 1; i < DiceThrowsList.Items.Count; i++)
            {
                int currentValue = (int)DiceThrowsList.Items[i];
                if (currentValue < minNr)
                {
                    minNr = currentValue;
                }
            }

            return $"Laagste worp: {minNr}";
        }


    }

}
