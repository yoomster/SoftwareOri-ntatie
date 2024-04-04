using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrankjesSchema
{
    public partial class DrankjesForm : Form
    {
        public DrankjesForm()
        {
            InitializeComponent();
        }

        public int totalDrinks { get; set; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string drinkSort = DrinkSortTextBox.Text;
            string amountOfDrinksText = DrinkAmountTextBox.Text;
            bool isValidNr = int.TryParse(amountOfDrinksText, out int amountOfDrinks);

            if (!string.IsNullOrEmpty(drinkSort) && isValidNr)
            {

                for (int i = 1; i < amountOfDrinks+1; i++)
                {
                    DrinksList.Items.Add($"{drinkSort} {i}");
                }

                totalDrinks += amountOfDrinks;

                TotalDrinksLabel.Text = $"Totaal aantal drankjes: {totalDrinks}";
            }
            else if (string.IsNullOrEmpty(drinkSort))
            {
                MessageBox.Show("Incorrect, vul een drank naam in de eerste regel.");
            }
            else 
            {
                MessageBox.Show("Incorrect, vul het aantal drankjes in de tweede regel.");
            }
        }
    }
}
