using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanDerBinckesBakfietsen
{
    public partial class BakfietsVerhuur : Form
    {
        public BakfietsVerhuur()
        {
            InitializeComponent();
        }

        private void ButtonCalculateCost_Click(object sender, EventArgs e)
        {
            int bikeCost = 0;
            int daysOfRental = (int)RentalDaysNumUpDown.Value; 

            string bikeChoice = ChoiceOfBikes.Text;

            if (string.IsNullOrEmpty(bikeChoice) )
                Console.WriteLine("De invoer is niet akkoord, selecteer 1");
            else if (bikeChoice == "Urban Arrow 4 pers. € 20")
                bikeCost = 20;
            else if(bikeChoice == "Urban Arrow 6 pers. € 30")
                bikeCost = 30;
            else if (bikeChoice == "Urban Arrow 4 pers. E-Bike € 40")
                bikeCost = 40;
            else if (bikeChoice == "Urban Arrow 6 pers. E-Bike € 60")
                bikeCost = 60;

            int extrasIndex = AccessoiresList.SelectedIndex;
            int costExtras = 0;
            int totalCost = (bikeCost * daysOfRental) + (costExtras * daysOfRental);
     
            string[] extraAccessores = { "Telefoonhouder", "Helm", "Regenhoes", "Babystoel" };
            AccessoiresList.Items.AddRange(extraAccessores);

            if (extrasIndex == 0)
                costExtras += 5;
            else if (extrasIndex == 1)
                costExtras += 10;
            else if (extrasIndex == 2)
                costExtras += 15;
            else if (extrasIndex == 3)
                costExtras += 20;

        }
    }
}

